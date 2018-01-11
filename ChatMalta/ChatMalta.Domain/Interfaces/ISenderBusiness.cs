using ChatMalta.Domain.Entities;
using System.Collections.Generic;

namespace ChatMalta.Domain.Interfaces
{
    public interface ISenderBusiness
    {
        bool Send(Sender objMessage);
    }
}
