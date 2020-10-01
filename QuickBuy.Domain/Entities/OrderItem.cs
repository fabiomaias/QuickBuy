using System;
namespace QuickBuy.Domain.Entities
{
    public class OrderItem: Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            if (ProductId == 0)
                AddMessageValidation("Não foi identificado a referência do produto");

            if (Quantity == 0)
                AddMessageValidation("Quantidade não informada");
        }
    }
}
