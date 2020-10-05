using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities.Valuables;

namespace QuickBuy.Repository.Config
{
    public class FormOfPaymentConfiguration: IEntityTypeConfiguration<FormOfPayment>
    {
        public FormOfPaymentConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<FormOfPayment> builder)
        {
            throw new NotImplementedException();
        }
    }
}
