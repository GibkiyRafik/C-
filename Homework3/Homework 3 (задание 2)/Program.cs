using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3__задание_2_
{
    class Program
    {

        ////2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        ////б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        //При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

        
        public static int Numbers(ref int summ)
        {
            int a;
            do
            {
                Console.WriteLine("Введите число. Введите 0 для окончания работы.");
                bool res = int.TryParse(Console.ReadLine(), out a);
                if (res == false)
                {
                    Console.WriteLine("Вы должны ввести целое число");
                    Numbers(ref summ);
                }

                else
                    Check(a, ref summ);
            }

            while (a != 0);

            return summ;
        }
        public static void Check(int a, ref int summ)
        {
            if (a % 2 != 0 && a > 0)
                summ = a + summ;
        }

        static void Main(string[] args)
        {
            int summ = 0;
            Numbers(ref summ);
            
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {summ}");
            Console.ReadKey();
        }
    }
}
