using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.BAL.Utility
{
    public static class Utils
    {
        /// <summary>
        /// Gets the property value from the JToken.
        /// </summary>
        /// <typeparam name="T">The type of value to return.</typeparam>
        /// <param name="token">The token.</param>
        /// <param name="propertyName">The property name.</param>
        /// <returns>The value of the property.</returns>
        public static T GetPropertyValue<T>(JToken token, string propertyName)
        {
            try
            {
                if (token != null && token[propertyName] != null)
                {
                    return token[propertyName].Value<T>();
                }
            }
            catch (Exception ex)
            {

            }

            return default(T);
        }
    }
}
