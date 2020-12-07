using System;
using System.Globalization;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Client client = new Client(name, email, birthDate);


            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many item to this order? : ");
            int qtdOrder = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdOrder; i++) 
            {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                
                OrderItem items = new OrderItem(quantity, priceProduct, product);
                order.AddItem(items);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
