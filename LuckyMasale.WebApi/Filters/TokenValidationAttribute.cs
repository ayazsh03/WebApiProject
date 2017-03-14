using LuckyMasale.WebApi.Utility;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
//using LuckyMasale.Shared.DTO;
using LuckyMasale.Shared;
using System.Configuration;
using System.Web;
using Newtonsoft.Json.Linq;
//using LuckyMasale.Controllers;
using System.Net.Http.Headers;

namespace LuckyMasale.WebApi.Filters
{
    public class TokenValidationAttribute : ActionFilterAttribute, IActionFilter
    {
        public readonly string OAuthURL = ConfigurationManager.AppSettings["OAuthURL"];
        public readonly string OAuth2EndPoint = ConfigurationManager.AppSettings["OAuth2EndPoint"];
        public string veevaAccess_Token = "";
        public string veevaInstanceURL = "";
        private string access_token = "";
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenValidationAttribute"/> class.
        /// </summary>
        public TokenValidationAttribute()
        {
        }

        /// <summary>
        /// Every API request will come to this function to validate the token.
        /// </summary>
        /// <param name="actionContext">The http action context.</param>        
        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    try
        //    {
        //        if (actionContext.Request.RequestUri.LocalPath.Contains("/api/token") == false)
        //        {
        //            string x = GenerateToken(ref actionContext);
        //            //if (!this.IsTokenValid(ref actionContext))
        //            //{
        //            //    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
        //            //    {
        //            //        Content = new StringContent("Missing Authorization-Token")
        //            //    };
        //            //}
        //        }

        //        base.OnActionExecuting(actionContext);
        //    }
        //    catch (Exception ex)
        //    {
        //        actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
        //        {
        //            Content = new StringContent("Unauthorized User")
        //        };
        //        //this.logger.Log(Level.FatalError, ex.Message);
        //        return;
        //    }
        //}

        /// <summary>
        /// Action executed context.
        /// </summary>
        /// <param name="actionExecutedContext">The http action context.</param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //string token = Utils.GetHeader(actionExecutedContext.Request, "Token");
            //string userName = Utils.GetHeader(actionExecutedContext.Request, "UserName");
            //if (token != null)
            //{
            //    actionExecutedContext.Response.Headers.Add("Token", token);
            //}            
        }

        /// <summary>
        /// Validate token.
        /// </summary>
        /// <param name="actionContext">Http action context.</param>
        /// <returns>Verify token.</returns>
        public bool IsTokenValid(ref HttpActionContext actionContext)
        {
            bool result = false;

            return result;
        }

        //public string GenerateToken(ref HttpActionContext actionContext)
        //{
        //    try
        //    {
        //        var tokenResponse = "";
        //        var tokenController = actionContext.Request.GetDependencyScope().GetService(typeof(TokenController)) as TokenController;

        //        Task task = Task.Run(async () =>
        //        {                
        //            //parameter initialization
        //            var veevaConsumerKey = ConfigurationManager.AppSettings["veevaConsumerKey"];
        //            var veevaConsumerSecret = ConfigurationManager.AppSettings["veevaConsumerSecret"];
        //            var veevaUserName = ConfigurationManager.AppSettings["veevaUserName"];
        //            var veevaPassword = ConfigurationManager.AppSettings["veevaPassword"];

        //            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        //            string parameters = "grant_type=password&client_id=" + HttpUtility.UrlEncode(veevaConsumerKey)
        //              + "&client_secret=" + HttpUtility.UrlEncode(veevaConsumerSecret) + "&username=" + HttpUtility.UrlEncode(veevaUserName)
        //              + "&password=" + HttpUtility.UrlEncode(veevaPassword);

        //            var uri = new Uri(ConfigurationManager.AppSettings["OAuth2EndPoint"] + "?" + parameters);

        //            //Client instance initialization
        //            using (HttpClient authClient = new HttpClient())
        //            {
        //                authClient.DefaultRequestHeaders.Accept.Clear();

        //                //response await
        //                HttpResponseMessage message
        //                    = await authClient.PostAsync(uri, new StringContent(parameters));
        //                authClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //                tokenResponse = await message.Content.ReadAsStringAsync();
        //                //var strResponse = await message.Content.ReadAsAsync<TokenData>();
        //                JObject authObj = JObject.Parse(tokenResponse);
        //                access_token = (string)authObj["access_token"];
        //                veevaInstanceURL = (string)authObj["instance_url"];
                        
        //                Token token = new Token();
        //                token.AccessToken = access_token;
        //                token.InstanceURL = veevaInstanceURL;
        //                token.Id = (string)authObj["id"];
        //                token.AccessTokenType = (string)authObj["token_type"];
        //                token.IssuedAt = (string)authObj["issued_at"];
        //                token.Signature = (string)authObj["signature"];

        //                var result = await tokenController.InsertToken(token);
        //            }
        //        });

        //        task.Wait();
        //    }
        //    catch (Exception)
        //    {
        //        actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
        //    }

        //    return access_token;
        //}
    }
}
