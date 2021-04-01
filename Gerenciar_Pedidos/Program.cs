using System;
using Gerenciar_Pedidos.Entities.Enums;
using Gerenciar_Pedidos.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace Gerenciar_Pedidos

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product;
            Product product1 = new Product();
            List<OrderItem> orderItem;
            OrderItem orderItem1 = new OrderItem();
            Order order = new Order();


            Console.WriteLine("Entre com os dados do Cliente : ");
            Console.Write("Nome : ");
            string name = Console.ReadLine();

            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("Data de Aniversário (DD/MM/YYYY) : ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Console.WriteLine("Data do Pedido : " + moment);
            Client client = new Client(name, email, birth);


            OrderStatus status = OrderStatus.Processando;
            Console.Write("Status : " + status);
            Console.WriteLine();

            Console.Write("Quantos produtos tem o pedido? ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int c = 0; c < n; c++)
            {
                count++;
                Console.WriteLine("Entre com os dados do pedido #" + count);
                Console.Write("Nome do Produto : ");
                string nameproduct = Console.ReadLine();

                Console.Write("Produto Preço : ");
                double priceprodutc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade : ");
                int quantifyproduct = int.Parse(Console.ReadLine());

                product1 = new Product(nameproduct, priceprodutc);
                orderItem1 = new OrderItem(quantifyproduct, priceprodutc);


            }

            
            
            Console.WriteLine(order);
            Console.WriteLine("Produtos do pedido : ");
            for (int c = 0; c < n; c++)
            {
               
                    Console.WriteLine(product1.Name
                    + ", " + product1.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantidade : " + orderItem1.Quantify
                    + ", Subtotal : $" + orderItem1.SubTotal(orderItem1.Quantify, orderItem1.Price));
                
                
            }


        }
    }
}
