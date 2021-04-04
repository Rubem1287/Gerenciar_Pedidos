using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciar_Pedidos.Entities.Enums
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string nameproduct, double priceproduct)
        {
            Name = nameproduct;
            Price = priceproduct;
        }

    }
}
