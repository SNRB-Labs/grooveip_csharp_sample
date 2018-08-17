using Com.Grooveip.Sdk.Model;
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
            
            string hash = HashGenerator.CreateSHA256(string.Format("{0}{1}{2}{3}", clientId, areaCode, requestId, secret));
            
            string url = string.Format("{0}/numbers/list/{1}" +
                "/areaCode/{2}/requestId/{3}/hash/{4}", baseUrl, clientId, areaCode, requestId, hash);

            return url;
        }

        public static NumberReserveRequest BuildNumberResesrveRequest(string number, string areaCode)
        {
            var request = new NumberReserveRequest
            {
                CustomerId = clientId,
                RequestId = GetRequestId(),
                PhoneNumber = number,
                AreaCode = areaCode
            };

            request.Hash = string.Format("{0}{1}{2}{3}{4}", clientId, number, areaCode, request.RequestId, secret);
            
            return request;
        }

        public static string GetNumberReserveUrl()
        {
            return string.Format("{0}/numbers/reserve", baseUrl);
        }

        private static string GetRequestId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
