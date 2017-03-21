using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public static class Configuration
    {
        public static readonly string ClientId;
        public static readonly string ClientSecret;

        static Configuration()
        {
            Dictionary<string, string> config = Configuration.GetConfig();
            Configuration.ClientId = config["clientId"];
            Configuration.ClientSecret = config["clientSecret"];
        }

        public static Dictionary<string, string> GetConfig()
        {
            return new Dictionary<string, string>()
            {
                { "mode", "live" },
                { "connectionTimeout", "360000" },
                { "requestRetries", "1" },
                { "clientId", "Afvi7xg_I0hWPZu3Wyfj2SCt3oPpQyothk5OxTWs0hADf4hNqDj5ImYgno2v_EL_McM_5OzOPAgxFaDO"  },
                { "clientSecret", "EPIY2-x4b5g3Y4cNWWa6BWKWo1XzBd1yxXzbXegAqVQSHLvC_eeMmu4BsfEJtBg-D1mLdZRw2mhchoSA"  }
            };
        }

        private static string GetAccessToken()
        {           
            return new OAuthTokenCredential(Configuration.ClientId, Configuration.ClientSecret, Configuration.GetConfig()).GetAccessToken();
        }

        public static APIContext GetAPIContext(string accessToken)
        {
            APIContext apiContext = new APIContext(string.IsNullOrEmpty(accessToken) ? Configuration.GetAccessToken() : accessToken);
            apiContext.Config = Configuration.GetConfig();

            return apiContext;
        }
    }
}
