using System;

namespace DZ3seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string first = Console.ReadLine();
            int number1 = int.Parse(first);
            if ((number1 % 2) == 0)
            {
                Console.WriteLine("Вы ввели четное число!");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число!");
            }
        }
    }
}
