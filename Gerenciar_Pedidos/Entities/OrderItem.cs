using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciar_Pedidos.Entities.Enums
{
    class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantify, double price)
        {
            Quantify = quantify;
            Price = price;
            
        }

        public double SubTotal(int quantify, double price)
        {
            return quantify * price;
        }
    }
}
