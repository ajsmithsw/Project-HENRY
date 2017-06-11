using System;
using Henry.Core.Wit;
using RestSharp;

namespace Henry.Core
{
    public class WitTest
    {
        private RestClient _client;

        public WitTest()
        {
            _client = new RestClient("https://api.wit.ai");

        }

        public void TestMessage(string message)
        {
            var request = new RestRequest("message", Method.GET);
            request.AddHeader("Authorization", string.Format("Bearer {0}", Constants.Wit_ClientKey));
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("v", "20170307");
            request.AddParameter("q", message);

            IRestResponse response = _client.Execute(request);
            Console.WriteLine(response.Content);
        }

    }
}
