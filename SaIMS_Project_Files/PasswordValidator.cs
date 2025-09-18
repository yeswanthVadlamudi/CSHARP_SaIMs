using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeaApp
{
    internal class PasswordValidator
    {
        public  void ValidatePassword(string password)
        {
            List<char> invalid_chars = new List<char>();
            // Define the required characters
            string requiredCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#~£$%&*";

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password field is required, cannot be empty");
            }
            // Check if the password length is at least 10 characters
            if (password.Length < 10)
            {
                throw new ArgumentException("Password must be at least 10 characters long.");
            }

            // Check if the password contains all required characters
            foreach (char c in password)
            {
                if (!requiredCharacters.Contains(c))
                {
                    invalid_chars.Add(c);
                    string ch = string.Join(",", invalid_chars);
                    throw new ArgumentException($"Invalid character ' {ch} ' in password.");
                }
            }
        }
    }
}
