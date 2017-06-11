using System;
using RestSharp;

namespace Henry.Core.Wit
{
    public static class WitClient
    {
        private static RestClient _client = new RestClient(Constants.WIT_ENDPOINT);

        public static string Message(string message) 
        {
            var request = WitMessageRequest.Create(message);
			IRestResponse response = _client.Execute(request);
			return response.Content;
        }
    }
}
