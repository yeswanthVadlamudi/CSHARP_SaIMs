using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;

namespace NeaApp
{
    public class Database_Config
    {
        public string get_ini()
        {
            var configuration_builder = new ConfigurationBuilder().AddIniFile("C:\\Users\\User\\Documents\\Visual Studio 2022\\projects\\NeaApp\\my_sql_config.ini");

            var configuration = configuration_builder.Build();

            var db_config = configuration.GetSection("MySqlconn");

            var c_string = $"server={db_config["Server"]};port={db_config["Port"]};database={db_config["Database"]};username={db_config["User"]};password={db_config["Password"]};pooling={db_config["Pooling"]}";

            return c_string;
        }

        


    }











}
