using System;
using System.Net.Http;
using IdentityModel.Client;
using Newtonsoft.Json.Linq;

namespace ClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string token = Test();
                Console.WriteLine(token);
                using ( var client = new HttpClient())
                {
                    client.SetBearerToken(token);

                    var response = client.GetAsync("http://localhost:40000/open/龚磊");
                    response.Wait();
                    if (!response.Result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(response.Result.StatusCode);
                    }
                    else
                    {
                        var content = response.Result.Content.ReadAsStringAsync();
                        content.Wait();

                        Console.WriteLine(content.Result);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.ReadKey();
        }

        public static string Test()
        {
            var client = new HttpClient();
            var disco = client.GetDiscoveryDocumentAsync("http://localhost:40004");
            disco.Wait();
            if (disco.Result.IsError)
            {
                Console.WriteLine(disco.Result.Error);
                return string.Empty;
            }
            var tokenResponse = client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.Result.TokenEndpoint,

                ClientId = "OcelotDemo",
                ClientSecret = "gongl01",
                Scope = "OcelotApi"
            });

            tokenResponse.Wait();
            if (tokenResponse.Result.IsError)
            {
                return string.Empty;
            }
            return tokenResponse.Result.AccessToken;
        }
    }
}
