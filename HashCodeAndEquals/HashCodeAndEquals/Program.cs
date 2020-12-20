using System;
using Entities;
namespace HashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Allison", Email = "allison@gmail.com" };

            Console.WriteLine(a.Equals(b));
          
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
