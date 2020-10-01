using System;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Interfaces;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository()
        {
        }
    }
}
