using System;
using System.Text;

/*
 Існує модель системи «Рецепт». Модель дозволяє в незмінному
вигляді зберігати призначення лікаря і термін дії рецепту. Реалізувати
задачу, що дозволяє продовжувати термін дії вже існуючого рецепту.
*/


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Console.WriteLine("Введіть рецепт:");
            string rec_input;
            rec_input = Console.ReadLine();
            Console.WriteLine("Введіть термін дії у форматі дд-мм-рррр:");
            DateTime date_input;
            date_input = DateTime.Parse(Console.ReadLine());
            IRecipe rec = new Recipe(rec_input, date_input);
            Console.WriteLine("Текст рецепта: " + rec.GetDoctorAssigment());
            Console.WriteLine("Термін дій: " + rec.GetStringExpirationDate());


            Console.WriteLine("Введіть новий термін дії у форматі дд-мм-рррр:");
            string temp = Console.ReadLine();
            date_input = DateTime.Parse(temp);
            if (rec.GetExpirationDate() > date_input)
            {
                Console.WriteLine("Новий термін дії не дійсний!");
            }
            else
            {
                rec = new ExtendRecipe(rec, date_input);
                Console.WriteLine("Текст рецепта: " + rec.GetDoctorAssigment());
                Console.WriteLine("Новий термін дій: " + rec.GetStringExpirationDate() + "\n");
            }
        }

    }
}