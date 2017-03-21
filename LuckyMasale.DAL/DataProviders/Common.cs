using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LuckyMasale.DAL.DataProviders
{
    public static class Common
    {
        public static string FormatJsonString(string json)
        {
            if (String.IsNullOrEmpty(json))
            {
                return String.Empty;
            }

            if (!json.StartsWith("["))
            {
                return JObject.Parse(json).ToString();
            }

            json = "{\"list\":" + json + "}";

            string str = JObject.Parse(json).ToString();

            return str.Substring(13, str.Length - 14).Replace("\n ", "\n");
        }

        public static string GetRandomInvoiceNumber()
        {
            return new Random().Next(999999).ToString();
        }
    }
}
