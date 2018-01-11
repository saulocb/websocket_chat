using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;

namespace ChatMalta.Repository.Entities
{
    public class MessageRepository : BaseRepository<Message>, IBaseRepository<Message>
    {
    }
}
