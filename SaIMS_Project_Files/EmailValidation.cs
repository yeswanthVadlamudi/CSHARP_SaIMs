using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NeaApp
{
    internal class EmailValidation
    {
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the email address by converting it to lowercase and removing any extra whitespace
                email = email.ToLower().Trim();

                // Split the email address into local part and domain part
                string[] parts = email.Split('@');
                if (parts.Length != 2)
                    return false;

                // Validate the local part (before the '@' symbol)
                string localPart = parts[0];
                if (string.IsNullOrWhiteSpace(localPart))
                    return false;

                // Validate the domain part (after the '@' symbol)
                string domainPart = parts[1];
                if (string.IsNullOrWhiteSpace(domainPart))
                    return false;

                // Split the domain part into subdomains
                string[] subdomains = domainPart.Split('.');
                if (subdomains.Length < 2)
                    return false;

                // Check that each subdomain is not empty or too long
                foreach (string subdomain in subdomains)
                {
                    if (string.IsNullOrWhiteSpace(subdomain) || subdomain.Length > 63)
                        return false;
                }

                // Check that the top-level domain (last subdomain) is not too short or too long
                string tld = subdomains[subdomains.Length - 1];
                if (tld.Length < 2 || tld.Length > 63)
                    return false;

                // Check that the email address does not contain any invalid characters
                if (!Regex.IsMatch(email, @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@[a-z0-9](?:[a-z0-9-]{0,61}[a-z0-9])?(?:\.[a-z0-9](?:[a-z0-9-]{0,61}[a-z0-9])?)*$"))
                    return false;

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }

    
}
