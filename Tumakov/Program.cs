using System;


namespace Tumakov
{
    internal class Program
    {
        static void Main()
        {
            //Лабораторная 2.1 
            // Спрашиваем имя и приветствуем
            Console.WriteLine("Лабораторная 2.1");

            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            Console.WriteLine("\n");
            //Лабораторная 2.2
            // Дано два целых числа, если второе не ноль, то выводим частное
            Console.WriteLine("Лабораторная 2.2");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y == 0)
            {
                Console.WriteLine("На ноль не делю");
            }
            else
            {
                Console.WriteLine($"{x / y}");
            }

            Console.WriteLine("\n");
            // Номер 2.1
            // Дана буква, вывести следующую по алфавиту (Если последняя, то будет выведена первая)
            Console.WriteLine("Номер 2.1");

            char letter = Convert.ToChar(Console.ReadLine());
            if (letter <= 'z')
            {
                Console.WriteLine($"{(char)((letter + 1 - 'a') % 26 + 'a')}");
            }
            else
            {
                Console.WriteLine($"{(char)((letter + 1 - 'A') % 26 + 'A')}");
            }

            Console.WriteLine("\n");
            // Номер 2.2
            // Даны коэффициенты квадратного уравнения. Решить его
            Console.WriteLine("Номер 2.2");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discrim = b * b - 4 * a * c;

            if (discrim < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, в действит. числах решений нет");
            }
            else
            {
                if (discrim == 0)
                {
                    Console.WriteLine($"Один корень: {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"Первый корень: {(-b - Math.Pow(discrim, 0.5)) / (2 * a)}, второй корень: {(-b + Math.Pow(discrim, 0.5)) / (2 * a)}");
                }
            }
            Console.WriteLine("Да здравствуют костыли.\nВведите что-нибудь для выхода, а то у меня консоль сразу закрывалась");
            Console.ReadLine();
        }
    }
}
