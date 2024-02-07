using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_Modul_1_Buikov
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

            Console.WriteLine("Введите число от 1 до 100");
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
                    Console.WriteLine("Это число не кратно 3 и 5");
                }
            }
            else
            {
                Console.WriteLine("число не находится в диапазоне от 1 до 100");
            }


            /* ЗАДАНИЕ 2
             Пользователь вводит с клавиатуры два числа. Первое
            число — это значение, второе число процент, который
             необходимо посчитать. Например, мыввели с клавиатуры
            90 и 10. Требуется вывести на экран 10 процентов от 90.
            Результат: 9.
            */
            Console.WriteLine("Введите номер:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент:");
            double percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат {number1 * (percent / 100)}");


            /* ЗАДАНИЕ 3
             * Пользователь вводит с клавиатуры четыре цифры.
            Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            сформировать число 1578.*/
            Console.WriteLine("введите четырёхзначный номер ");
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
            Console.WriteLine("Введите шестизначное число:");
            int sixNum = Convert.ToInt32(Console.ReadLine());

            if (sixNum >= 100000 && sixNum <= 999999)
            {
                Console.WriteLine("Введите два номера разрядов для обмена (например, 1 и 2):");
                int change1 = Convert.ToInt32(Console.ReadLine());
                int change2 = Convert.ToInt32(Console.ReadLine());

                if (change1 >= 1 && change1 <= 6 && change2 >= 1 && change2 <= 6)
                {
                    // разбивка числа на цифры
                    int[] digits = new int[6];
                    int tempNum = sixNum;

                    for (int i = 5; i >= 0; i--)
                    {
                        digits[i] = tempNum % 10;
                        tempNum /= 10;
                    }

                    // обмен цифр
                    int temp = digits[change1 - 1];
                    digits[change1 - 1] = digits[change2 - 1];
                    digits[change2 - 1] = temp;

                    // Сборка числа
                    int swappedNum = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        swappedNum = swappedNum * 10 + digits[i];
                    }

                    Console.WriteLine($"Число после обмена: {swappedNum}");
                }
                else
                {
                    Console.WriteLine("Некорректные номера разрядов для обмена.");
                }
            }
            else
            {
                Console.WriteLine("Введенное число не является шестизначным.");
            }


            /* ЗАДАЧА 5
            Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.
            Например, если введено 22.12.2021, приложение должно
            отобразить Winter Wednesday.    
             */

            Console.WriteLine("Введите дату, например 04.04.2024");
            string date = Console.ReadLine();
            string[] dateSplit = date.Split('.');

            string day = dateSplit[0];
            string month = dateSplit[1];
            string strMonth = null;
            int intMonth = Convert.ToInt32(month);

            if (intMonth >= 3 && intMonth <= 5)
            {
                strMonth = "Spring"; // весна
            }
            else if (intMonth >= 6 && intMonth <= 8)
            {
                strMonth = "Summer"; // лето
            }
            else if (intMonth >= 9 && intMonth <= 11)
            {
                strMonth = "Autumn"; // осень
            }
            else if (intMonth == 12 || intMonth <= 2)
            {
                strMonth = "Winter"; // зима
            }

            Console.WriteLine(strMonth);




        }
    }
}
