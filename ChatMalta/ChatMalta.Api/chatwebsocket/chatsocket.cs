using Microsoft.Web.WebSockets;
using System;
using ChatMalta.Domain.Interfaces;
using ChatMalta.Domain.Entities;

namespace ChatMalta.Api.chatwebsocket
{
    public class ChatWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection _chatClients = new WebSocketCollection();
        private ISenderBusiness _bs;

        public ChatWebSocketHandler(ISenderBusiness bs)
        {
            _bs = bs;
        }

        public override void OnOpen()
        {
            _chatClients.Add(this);
        }

        public override void OnMessage(string message)
        {
            var obj = new Sender(message);
            _bs.Send(obj);

            _chatClients.Broadcast(DateTime.Now +" : " + message);
        }
    }
}