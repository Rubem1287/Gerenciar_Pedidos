using System;
using System.Collections.Generic;
using System.Text;
using Gerenciar_Pedidos.Entities.Enums;


namespace Gerenciar_Pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment)
        {
            Moment = moment;
        }

        public Order(OrderStatus status, Client client, DateTime moment) : this (moment)
        {
            
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderitem)
        {
            Item.Add(orderitem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Item.Remove(orderItem);
        }

        public double total(int quantify, double price)
        {
            double sum = 0;

            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal(quantify, price);
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados do pedido : ");
            sb.Append("Hora do pedido : ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status do Pedido : ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente : ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.BirthDate.ToString("(dd/MM/yyyy)"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email.ToString());
            //sb.AppendLine("Itens do Pedido : ");
            //sb.Append(Product.Name.ToString());
            //sb.Append(", ");
            //sb.Append(Product.Price.ToString());
            //sb.Append(", ");
            //sb.Append(OrderItem.Quantify.ToString());
            //sb.Append(", ");

            return sb.ToString();


        }

        //public double Total(int quantify, double price)
        //{



        //    return;
        //}

        

    }
}
