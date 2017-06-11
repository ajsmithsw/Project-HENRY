using System;
using System.Diagnostics;
using RestSharp;

namespace Henry.Core.Wit
{
    public static class WitMessageRequest
    {
        public static RestRequest Create(string message)
        {
            var request = Create();
            request.AddParameter("q", Uri.EscapeDataString(message));

            return request;
        }

        public static RestRequest Create()
        {
            var request = new RestRequest("message", Method.GET);
            request.AddHeader("Authorization", string.Format("Bearer {0}", Constants.WIT_KEY));
			request.AddHeader("Content-Type", "application/json");
			request.AddParameter("v", "20170307");

			return request;
        }
    }
}