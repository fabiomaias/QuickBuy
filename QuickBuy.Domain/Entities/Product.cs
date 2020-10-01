using System;
namespace QuickBuy.Domain.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddMessageValidation("O Nome não pode ser vazio");

            if (string.IsNullOrEmpty(Description))
                AddMessageValidation("A Descrição não pode ser vazia");

        }
    }
}
