using System;
using WitAi;
using WitAi.Models;
using Henry.Core.Utils;

namespace Henry.Core.Services
{
    public class WitService : IWitService
    {
        private Wit _witClient;
        private string _sessionId;

        public WitService()
        {
            _witClient = new Wit(Constants.WIT_KEY);

            _sessionId = SessionId.Generate();
        }

        public string Converse(string msg)
        {
            var e = _witClient.Converse(_sessionId, msg, new WitContext());
            return e.Msg;
        }
    }
}
