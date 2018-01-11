using System;
using System.Collections.Generic;
using ChatMalta.Domain;

namespace ChatMalta.Repository
{
    public abstract class BaseRepository<T> where T: EntityBase
    {
        protected static List<T> DB = new List<T>();
        
        public IEnumerable<T> GetAll()
        {
            return DB;
        }

        public void Save(T obj)
        {
            DB.Add(obj);        
        }
    }
}
