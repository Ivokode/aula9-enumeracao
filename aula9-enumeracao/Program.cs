using System;
using aula9_enumeracao.Entities;
using aula9_enumeracao.Entities.Enums;

namespace aula9_enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 100,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
