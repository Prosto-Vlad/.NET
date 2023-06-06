using System;
using System.Text;


namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть назву спорядження");
            string name_eq = Console.ReadLine();
            Console.WriteLine("Введіть базову ціну");
            double base_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Оберіть спосіб прокату.\n1 - стандартний\n2 - пільговий\n3 - штрафний");
            int spos = Convert.ToInt32(Console.ReadLine());
            Strategy str1 = new Standard();
            switch (spos)
            {
                case 1:
                    str1 = new Standard();
                    break;
                case 2:
                    str1 = new Preferential();
                    break;
                case 3:
                    str1 = new Penalties();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Оберіть умови прокату.\n1 - стандартний\n2 - пільговий\n3 - штрафний");
            int um = Convert.ToInt32(Console.ReadLine());
            Strategy str2 = new Standard();
            switch (um)
            {
                case 1:
                    str2 = new Standard();
                    break;
                case 2:
                    str2 = new Preferential();
                    break;
                case 3:
                    str2 = new Penalties();
                    break;
                default:
                    break;
            }
            Equipment test = new Equipment(name_eq, str1, str2, base_cost);
            test.PrintInfo();
        }
    }
}