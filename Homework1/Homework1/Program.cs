using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Каледин Захар Александрович


namespace Homework1
{
    class Lesson1
    {
        //метод для задания 3*
        static double Dist(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        //метод для задания 5в
        static void Print(string msg, int a, int b, ConsoleColor foregroundcolor)
        {
            Console.SetCursorPosition(a, b);
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }



        static void Main(string[] args)
        {
            /*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
             * В результате вся информация выводится в одну строчку.
             * а) используя склеивание;
             * б) используя форматированный вывод;
             * в) *используя вывод со знаком $.
             */

            #region Task1

            Console.Title = "Анкета";

            Console.WriteLine("Как вас зовут?");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("А ваша фамилия?");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас рост?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А вес?");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя - " + name + " " + lastName + ", " + "вам " + age + " лет, " + "ваш рост - " + height + " см, " + "а ваш вес - " + weight + " кг.");
            Console.WriteLine("{0} {1}, {2} лет, {3} см, {4} кг.", name, lastName, age, height, weight);
            Console.WriteLine($"{name} {lastName}, {age} лет, {height} см, {weight} кг.");

            Console.ReadLine();
            Console.Clear();

            #endregion

            /*2. Ввести вес и рост человека. 
             * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
             * где m — масса тела в килограммах, h — рост в метрах
             */

            #region Task2

            Console.Title = "ИМТ";

            Console.WriteLine("Введите ваш вес в кг:");
            int weight2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах:");
            double height2 = Convert.ToDouble(Console.ReadLine());

            double bmi = (weight2/(height2 * height2));

            Console.WriteLine("Ваш ИМТ равен {0:F2}", bmi);
            Console.ReadLine();
            Console.Clear();

            #endregion

            /* 3.
             * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
             * r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
             * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
             * б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
             */

            #region Task3, 3*

            Console.Title = "Расстояние между точками";

            Console.WriteLine("Введите координату X первой точки:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X второй точки:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine("{0:F2}", r);
            Console.WriteLine("{0:F2}", Dist(x1, y1, x2, y2));
            Console.ReadLine();
            Console.Clear();

            #endregion

            /*4. Написать программу обмена значениями двух переменных.
             * а) с использованием третьей переменной;
             * б) *без использования третьей переменной.
             */

            #region Task4

            Console.Title = "Обмен данными между переменными";

            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"{a}, {b}");
            Console.ReadLine();

            #endregion 
           
            #region Task4*
            int d = 5;
            int e = 10;

            (d, e) = (e, d);

            /*
             * или так:
             * d = d + e;
             * e = d - e;
             * d = d - e;
             * сам не догадался, оба варианта подсмотрел */


            Console.WriteLine($"{d}, {e}");
            Console.ReadLine();
            Console.Clear();

            #endregion

            /*5 а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
             *  б) Сделать задание, только вывод организуйте в центре экрана
             *  в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
             */

            #region Task5

            Console.Title = "Вывод имени, фамилии и города";

            Console.WriteLine("Захар Каледин, г. Москва.");
            Console.ReadLine();
            Console.Clear();
            
            //5б
            Console.SetCursorPosition(45, 15);
            Console.WriteLine("Захар Каледин, г. Москва.");
            Console.ReadLine();
            Console.Clear();

            
            //5в
            Print("Захар Каледин, г. Москва.", 45, 15, ConsoleColor.Blue);
            Console.ReadLine();

            #endregion
        }
    }
}
