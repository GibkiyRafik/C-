using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3__класс_комплексных_чисел_
{

    // 1.б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

    class Complex
    {
        private double im;

        private double re;

        public double Im
        {
            set {im = value;}
            get {return im;}
        }

        public double Re
        {
            set {re = value;}
            get {return re;}
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex x)
        {
            return new Complex(re + x.re, im + x.im);
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public Complex Product(Complex x)
        {
            return new Complex(re * x.re - (im * x.im), im * x.re + re * x.im);
        }

        public override string ToString()
        {
            if (im > 0)
                return string.Format("{0}+{1}i", re, im);
            else
                return string.Format("{0}{1}i", re, im);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите действительную часть числа 1");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Введите мнимую часть числа 1 (отбросив i)");
            double.TryParse(Console.ReadLine(), out double b);

            Complex complex01 = new Complex(a, b);
            Console.WriteLine($"Первое число - {complex01}");

            Console.WriteLine("Введите действительную часть числа 2");
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine("Введите мнимую часть числа 2 (отбросив i)");
            double.TryParse(Console.ReadLine(), out double d);

            Complex complex02 = new Complex(c, d);
            Console.WriteLine($"Второе число - {complex02}");

            Complex complex3 = complex01.Plus(complex02);
            Console.WriteLine($"Результат сложения комплексных чисел: {complex3}");

            Complex complex4 = complex01.Minus(complex02);
            Console.WriteLine($"Результат вычитания комплексных чисел: {complex4}");

            Complex complex5 = complex01.Product(complex02);
            Console.WriteLine($"Результат умножения комплексных чисел: {complex5}");

            Console.ReadKey();

        }
    }
}
