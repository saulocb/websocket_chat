using System.Collections.Generic;
using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;
using System.Linq;

namespace ChatMalta.Api.Business
{
    public class SenderBusiness : ISenderBusiness
    {
        private readonly IBaseRepository<Sender> _repository;
        private readonly IBaseRepository<Message> _msgRepository;
        
        public SenderBusiness(IBaseRepository<Sender> senderRepo, IBaseRepository<Message> msgRepo)
        {
            _msgRepository = msgRepo;
            _repository = senderRepo;
        }

        public bool Send(Sender obj)
        {
            _repository.Save(obj);
            return true;
        }
    }
}
