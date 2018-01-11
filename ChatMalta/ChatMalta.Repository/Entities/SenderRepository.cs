using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;

namespace ChatMalta.Repository.Entities
{
    public class SenderRepository : BaseRepository<Sender>, IBaseRepository<Sender>
    {
        private readonly IBaseRepository<Message> msgRepository;
        public SenderRepository()
        {
            msgRepository = new MessageRepository();
        }

        public new void Save(Sender objMessage)
        {
            msgRepository.Save(objMessage.Message);
            base.Save(objMessage);
        }
    }
}
