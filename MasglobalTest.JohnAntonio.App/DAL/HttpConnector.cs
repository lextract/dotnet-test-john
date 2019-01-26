using System.Net.Http;
using System.Net.Http.Headers;

namespace MasglobalTest.JohnAntonio.App.DAL
{
    internal class HttpConnector
    {
        private static HttpClient client;
        public static HttpClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return client;
            }
        }
    }
}
