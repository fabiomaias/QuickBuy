using System;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Interfaces;

namespace QuickBuy.Repository.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository()
        {
        }
    }
}
