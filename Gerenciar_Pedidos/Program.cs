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

            
            OrderItem orderItem = new OrderItem();
            Order order = new Order();



            Console.WriteLine("Entre com os dados do Cliente : ");
            Console.Write("Nome : ");
            string name = Console.ReadLine();


            Console.Write("Email : ");
            string email = Console.ReadLine();


            Console.Write("Data de Aniversário (DD/MM/YYYY) : ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            DateTime moment = DateTime.Now;
            

            Console.WriteLine("Data do Pedido : " + order.Moment);
            Client client = new Client(name, email, birth);
            
            Console.Write("Digite o Status do produto de 1 a 4 : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Status : " + status);
            Console.WriteLine();

            order = new Order(moment, status, client);

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
                double priceproduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade : ");
                int quantityproduct = int.Parse(Console.ReadLine());

                Product product = new Product()
                {
                    Name = nameproduct,
                    Price = priceproduct

                };

              
                orderItem = new OrderItem(quantityproduct, priceproduct, product);

                
                order.AddItem(orderItem);

                

            }


            Console.WriteLine();
            Console.WriteLine(order);
           


        }
    }
}
