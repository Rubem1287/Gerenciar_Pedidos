using System;
using System.Collections.Generic;
using System.Text;
using Gerenciar_Pedidos.Entities.Enums;
using System.Globalization;


namespace Gerenciar_Pedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
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

        public double total()
        {
            double sum = 0;

            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados do pedido : ");
            sb.AppendLine("Hora do pedido : "+ Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido : "+Status);
            sb.AppendLine("Cliente : "+Client);
            sb.AppendLine("Itens do Pedido : ");
       
            foreach(OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Preço Total : $" + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();


        }
    }
}
