using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        //O status do pedido é um enum 
        public OrderStatus Status { get; set; }
        //Como são varios pedidos serão armazenados em uma lista e já esta inicializada por garantia
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }
        public Order() { }

        //Items não preisam ser colocado no construtor
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                //sum += item.subTotal(); ou
                sum = sum + item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: ");
            sb.Append(Total());
            return sb.ToString();
            
        }
    }
}
