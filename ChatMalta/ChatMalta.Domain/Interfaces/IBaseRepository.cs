using System.Collections.Generic;

namespace ChatMalta.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        void Save(T obj);
        IEnumerable<T> GetAll();
    }
}
