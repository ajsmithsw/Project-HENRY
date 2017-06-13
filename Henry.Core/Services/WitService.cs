using System;
using WitAi;
using WitAi.Models;

namespace Henry.Core.Services
{
    public class WitService : IWitService
    {
        private Wit _witClient;

        public WitService()
        {
            _witClient = new Wit(Constants.WIT_KEY);
        }

        public string Message(string msg)
        {
            var response = _witClient.Message(msg);
            return response.Text;
        }
    }
}
