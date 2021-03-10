using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        // Захар Каледин.
        //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
        struct Complex
        {
            
            public double im;

            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }

            public override string ToString()
            {
                if (im > 0)
                    return string.Format("{0}+{1}i", re, im);
                else
                    return string.Format("{0}{1}i", re, im);
            }

        }
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 2;
            complex1.im = 3;

            Console.WriteLine(complex1);

            Complex complex2;
            complex2.re = 1;
            complex2.im = -10;
            Console.WriteLine(complex2);

            Complex complex3 = complex1.Plus(complex2);
            Complex complex4 = complex1.Minus(complex2);

            Console.WriteLine($"Результат сложения комплексных чисел: {complex3}");
            Console.WriteLine($"Результат вычитания комплексных чисел: {complex4}");

            Console.ReadKey();
        }
    }
}
