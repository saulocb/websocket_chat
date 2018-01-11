using System;
using System.Collections.Generic;
using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;

namespace ChatMalta.Repository.Entities
{
    public class UserRepository : BaseRepository<User>, IBaseRepository<User>
    {}
}
