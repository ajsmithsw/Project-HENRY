using System;
using RestSharp;

namespace Henry.Core.Wit
{
    public static class WitMessageRequest
    {
        public static RestRequest Create(string message)
        {
            var request = Create();
            request.AddParameter("q", message);

            return request;
        }

        public static RestRequest Create()
        {
            var request = new RestRequest("message", Method.GET);
            request.AddHeader("Authorization", string.Format("Bearer {0}", Constants.Wit_ClientKey));
			request.AddHeader("Content-Type", "application/json");
			request.AddParameter("v", "20170307");

			return new RestRequest();
        }
    }
}