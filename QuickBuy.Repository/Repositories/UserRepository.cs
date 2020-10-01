using System;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Interfaces;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
