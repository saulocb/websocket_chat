using ChatMalta.Api.chatwebsocket;
using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;
using Microsoft.Web.WebSockets;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatMalta.Api.Controllers
{
    public class ChatController : ApiController
    {
        public readonly ISenderBusiness _bs;

        public ChatController(ISenderBusiness business)
        {
            _bs = business;
        }

        public HttpResponseMessage Get()
        {
            System.Web.HttpContext.Current.AcceptWebSocketRequest(new ChatWebSocketHandler(_bs));
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }
        
        public void Post(Sender value)
        {
            _bs.Send(value);
        }        
    }
}
