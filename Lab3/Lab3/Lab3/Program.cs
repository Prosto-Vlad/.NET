using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TransportVehicle ven = new TransportVehicle();
            Console.WriteLine("Який вид странспорту ви хочете падготувати для відравлення?\n1 Bus\n2 Taxi");
            string res = Console.ReadLine();
            if (res == "1")
            {
                ven.SetType("Bus");
                Console.WriteLine("Скільки дітей ви хочете загрузити?(1-30)");
                Console.WriteLine("Скільки дітей ви хочете загрузити?(1-30)");
                Console.WriteLine("Скільки дітей ви хочете загрузити?(1-30)");
            }
            if (res == "2")
            {

            }
            else
            {
                Console.WriteLine("Вибачте, але такого виду транспорту немає.");
            }
        }

    }
}