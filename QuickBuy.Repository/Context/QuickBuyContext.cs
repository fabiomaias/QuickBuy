using System;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Entities.Valuables;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<FormOfPayment> FormOfPayments { get; set; }

    }
}
