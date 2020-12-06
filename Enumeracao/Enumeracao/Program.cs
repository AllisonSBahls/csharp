using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;
namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,

                //Designando a ordem desejada ao meu status usando o enum
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

            //Conversão de STRING para ENUM;
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversão de ENUM para STRING;
            // Definido o tipo do enum que recebera a conversão e declarado seu tipo de conversão. 
            //entre parenteses deve estar o Status que deseja converter, lebrando que deve ser igual ao nome;
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
