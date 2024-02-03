using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__practika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задание 1
            Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 без
            остатка) нужно вывести слово Fizz. Если число кратно 5
            нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
            вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
            вывести само число.
            Если пользователь ввел значение не в диапазоне от 1
            до 100 требуется вывести сообщение об ошибке.
            */

            Console.WriteLine("Enter a number from 1 to 100");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number > 1 && number < 100)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 3 != 0 && number % 5 != 0)
                {
                    Console.WriteLine("The number is not a multiple of 3 and 5");
                }
            }
            else
            {
                Console.WriteLine("The number is not in the range from 1 to 100");
            }

            /* ЗАДАНИЕ 2
             Пользователь вводит с клавиатуры два числа. Первое
            число — это значение, второе число процент, который
             необходимо посчитать. Например, мыввели с клавиатуры
            90 и 10. Требуется вывести на экран 10 процентов от 90.
            Результат: 9.
            */
            Console.WriteLine("Enter number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percent:");
            double percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result {number1 * (percent / 100)}");

            /* ЗАДАНИЕ 3
             * Пользователь вводит с клавиатуры четыре цифры.
            Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            сформировать число 1578.*/
            Console.WriteLine("enter four numbers ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            string numResult = Convert.ToString((Convert.ToString(num1) + Convert.ToString(num2) + Convert.ToString(num3) + Convert.ToString(num4)));
            Console.WriteLine(Convert.ToInt32(numResult));

            /* ЗАДАНИЕ 4
             Пользователь вводит шестизначное число. После чего
            пользователь вводит номера разрядов для обмена цифр.
            Например, если пользователь ввёл один и шесть — это
            значит, что надо обменять местами первую и шестую
            цифры.
            Число 723895 должно превратиться в 523897.
            Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке
             */
        }
    }
}
