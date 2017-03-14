using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LuckyMasale.WebApi.Utility
{
    public static class Utils
    {
        ///// <summary>
        ///// Get Header.
        ///// </summary>
        ///// <param name="request">Request message.</param>
        ///// <param name="key">Key to find.</param>
        ///// <returns>Return header value.</returns>
        //public static string GetHeader(HttpRequestMessage request, string key)
        //{
        //    IEnumerable<string> keys = null;
        //    if (!request.Headers.TryGetValues(key, out keys))
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        string[] values = new List<string>(keys).ToArray();
        //        return values[0];
        //    }
        //}

        /// <summary>
        /// Get User IP.
        /// </summary>
        /// <param name="request">Request message.</param>
        /// <param name="key">Key to find.</param>
        /// <returns>Return header value.</returns>
        public static string GetUserIP(System.Web.HttpContextWrapper httpContextWrapper)
        {
            var request = httpContextWrapper.Request;
            var userIPGroup = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            string userIP = string.Empty;
            if (!string.IsNullOrEmpty(userIPGroup))
            {
                string[] rangeIP = userIPGroup.Split(',');
                int le = rangeIP.Length - 1;
                userIP = rangeIP[le];
            }
            else
            {
                userIP = request.ServerVariables["REMOTE_ADDR"];
            }

            return userIP;
        }
    }
}