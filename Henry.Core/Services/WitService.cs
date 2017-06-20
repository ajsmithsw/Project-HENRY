using System;
using WitAi;
using WitAi.Models;

namespace Henry.Core.Services
{
    public class WitService : IWitService
    {
        Wit _witClient;
        WitActions _actions;

        public WitService()
        {
            _actions = new WitActions();
            _actions["send"] = Send;
            _actions["time"] = TellTheTime;

            _witClient = new Wit("2PDIOI3QNKWLN5HQMSQLZJT4DYUSZ2RT", _actions)
            {
                WIT_API_VERSION = "20170307"
            };
        }

        public void BeginInteraction()
        {
            _witClient.Interactive();
        }

        //public void Converse(string msg)
        //{
        //    var res = _witClient.Converse(_sessionId, msg, new WitContext());
        //}

        WitContext Send(ConverseRequest request, ConverseResponse response)
        {
            Console.WriteLine(request.Message);

            return request.Context;
        }

        WitContext TellTheTime(ConverseRequest request, ConverseResponse response)
        {
            request.Context.Add("currentTime", DateTime.Now.ToShortTimeString());

            return request.Context;
        }
    }
}
