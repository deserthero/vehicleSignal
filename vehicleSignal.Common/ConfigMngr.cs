using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleSignal.Common
{
    public class ConfigMngr
    {
        /// <summary>
        /// Get appSettings value from configuration file
        /// </summary>
        /// <typeparam name="T">Type of the expected value</typeparam>
        /// <param name="key">key of appSettings to get value of</param>
        /// <returns>value of appSettings key</returns>
        /// <exception cref="NullReferenceException">If appSettings configuration key is not found in web.config</exception>
        public static T GetAppSettingsValue<T>(string key)
        {
            var value = System.Configuration.ConfigurationManager.AppSettings[key];
            if (value == null)
                throw new NullReferenceException();
            else
                return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Get appSettings value from configuration file, and returns the default value if not found.
        /// </summary>
        /// <typeparam name="T">Type of the expected value</typeparam>
        /// <param name="key">key of appSettings to get value of</param>
        /// <param name="defaultValue">the default value</param>
        /// <returns>value of appSettings key</returns>
        /// <exception cref="NullReferenceException">If appSettings configuration key is not found in web.config</exception>
        public static T GetAppSettingsValueOrDefault<T>(string key, T defaultValue)
        {
            var value = System.Configuration.ConfigurationManager.AppSettings[key];
            if (value == null)
                return defaultValue;
            else
                return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
