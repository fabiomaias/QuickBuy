using System;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Repositories;

namespace QuickBuy.Repository
{
    public class Client
    {
        public Client()
        {
            var userRepository = new UserRepository();
            var user = new User();

            userRepository.Add(user);
        }
    }
}
