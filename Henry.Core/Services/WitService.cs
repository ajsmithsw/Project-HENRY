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
        private WitActions _actions;

        public WitService()
        {
            _sessionId = SessionId.Generate();

            _actions = new WitActions();
            _actions["send"] = Send;
            _actions["time"] = TellTheTime;

            _witClient = new Wit("2PDIOI3QNKWLN5HQMSQLZJT4DYUSZ2RT", _actions)
            {
                WIT_API_VERSION = "20170307"
            };
        }

        public void Go()
        {
            _witClient.Interactive(_sessionId);
        }

        public void Converse(string msg)
        {
            var res = _witClient.Converse(_sessionId, msg, new WitContext());
        }

        private WitContext Send(ConverseRequest request, ConverseResponse response)
        {
            Console.WriteLine("HENRY > {0}", request.Message);

            return request.Context;
        }

        private WitContext TellTheTime(ConverseRequest request, ConverseResponse response)
        {
            request.Context.Add("currentTime", DateTime.Now.ToShortTimeString());

            return request.Context;
        }
    }
}
