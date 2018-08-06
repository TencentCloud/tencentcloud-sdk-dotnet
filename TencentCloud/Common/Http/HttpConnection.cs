using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloud.Common.Http
{
    public class HttpConnection
    {
        private IClient client;

        public HttpConnection(string baseUrl, int timeout,string proxy="")
        {
            if (!string.IsNullOrEmpty(proxy))
            {
                client = new FluentClient(baseUrl, new WebProxy(proxy));
            }
            else
            {
                client = new FluentClient(baseUrl);
            }
            client.BaseClient.Timeout = TimeSpan.FromSeconds(timeout);
            client.SetOptions(new FluentClientOptions() { });
        }

        public async Task<IResponse> GetRequest(string url, Dictionary<string, string> param)
        {        
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{url}?");

            foreach (KeyValuePair<string, string> kvp in param)
            {
                urlBuilder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }

            IResponse response = await client.GetAsync(urlBuilder.ToString().TrimEnd('&'));
            return response;
        }

        public async Task<IResponse> PostRequest(string url, Dictionary<string, string> param)
        {
            // set up
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage message = new HttpRequestMessage(method, url);
            var postbody = new FormUrlEncodedContent(param);
            message.Content = postbody;

            IRequest request =  this.client.SendAsync(message);
            var response = await request.AsResponse();
            return response;
        }
    }
}
