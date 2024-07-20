using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToCopyFiles
{
    class ReadConfigData
    {
        public string getConfigValuee(string configName)
        {
            try
            {
                var connection =
                System.Configuration.ConfigurationManager.
                ConnectionStrings[configName].ConnectionString;

                return connection.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();

            }
        }
    }
}
