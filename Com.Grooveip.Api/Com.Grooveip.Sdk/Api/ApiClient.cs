using Com.Grooveip.Sdk.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Api
{
    public class ApiClient
    {
        private const string secret = "myapisecret";
        private const int clientId = 1;
        private const string baseUrl = "http://staging-commercial.azurewebsites.net/api";

        public static string BuildInventoryUrl(int page, int quantity)
        {            
            string requestId = GetRequestId();

            string hash = HashGenerator.CreateSHA256(string.Format("{0}{1}{2}{3}{4}", clientId, page, quantity, requestId, secret));

            string url = string.Format("{0}/numbers/inventory/{1}/page/{2}/quantity/{3}/requestId/{4}/hash/{5}", baseUrl, clientId, page, quantity, requestId, hash);

            return url;
        }

        public static string BuildSearchUrl(string areaCode)
        {
            string requestId = GetRequestId();
            
            string hash = HashGenerator.CreateSHA256(string.Format("{0}{1}{2}{3}", baseUrl, clientId, areaCode, requestId));
            
            string url = HashGenerator.CreateSHA256(string.Format("{0}/numbers/list/{1}" +
                "/areaCode/{2}/requestId/{3}/hash/{4}", baseUrl, clientId, areaCode, requestId, hash));

            return url;
        }

        private static string GetRequestId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
