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
            Console.OutputEncoding = Encoding.UTF8;
            Recipe rec = new Recipe("temptemptmeptmep", new DateTime(2000,3,2));
            Console.WriteLine(rec.GetDoctorAssigment() + " " + rec.GetExpirationDate().ToString());

            rec = new ExtendRecipe(DateTime.Now, rec);
            Console.WriteLine(rec.GetDoctorAssigment() + " " + rec.GetExpirationDate().ToString());

            rec = new ExtendRecipe(new DateTime(2043, 3, 2), rec);
            Console.WriteLine(rec.GetDoctorAssigment() + " " + rec.GetExpirationDate().ToString());

            rec = new ExtendRecipe(new DateTime(2234, 3, 2), rec);
            Console.WriteLine(rec.GetDoctorAssigment() + " " + rec.GetExpirationDate().ToString());
        }

    }
}