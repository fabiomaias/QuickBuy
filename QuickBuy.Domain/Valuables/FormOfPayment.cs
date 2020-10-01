using System;
using QuickBuy.Domain.Entities.Enumerables;

namespace QuickBuy.Domain.Entities.Valuables
{
    public class FormOfPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBillet
        {
            get { return Id == (int)TypeFormPaymentEnum.Billet; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)TypeFormPaymentEnum.CreditCard; }
        }
        public bool IsDeposit
        {
            get { return Id == (int)TypeFormPaymentEnum.Deposit; }
        }
        public bool IsUndefined
        {
            get { return Id == (int)TypeFormPaymentEnum.Undefined; }
        }
    }
}
