using System;
using System.Collections.Generic;
using System.Linq;
using QuickBuy.Domain.Entities.Valuables;

namespace QuickBuy.Domain.Entities
{
    public class Order: Entity
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public DateTime EstimateDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PublicPlace { get; set; }
        public int AddressNumber { get; set; }

        public int FormOfPaymentId { get; set; }
        public FormOfPayment FormOfPayment { get; set; }

        /// <summary>
        /// Pedido deve ter ao menos um ou muitos itens
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            CleanMessagesValidation();
            if (!OrderItems.Any())
                AddMessageValidation("Crítica: Pedido não pode ficar sem item.");

            if (string.IsNullOrEmpty(CEP))
                AddMessageValidation("Crítica: o Campo CEP é obrigatório");
        }
    }

}
