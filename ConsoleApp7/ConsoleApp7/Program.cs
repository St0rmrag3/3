using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {//1
            
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            if (a1 > b1)
            {
                Console.WriteLine(a1);
            }
            else
            {
                Console.WriteLine(b1);
            }




            //2


            
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            if (a2 < b2)
            {
                if (a2 < c2)
                {
                    Console.WriteLine(a2);
                }
                else Console.WriteLine(c2);

            }
            else if (b2 < a2)
            {
                if (b2 < c2)
                {
                    Console.WriteLine(b2);
                }
                else
                {
                    Console.WriteLine(c2);
                }
            }


            //3

           
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            if (a3 < b3)
            {
                if (a3 < c3)
                {
                    if (c3 < b3)
                    {
                        Console.WriteLine(a3 + " " + c3 + " " + b3);
                    }
                    else Console.WriteLine(a3 + " " + b3 + " " + c3);

                }
                else Console.WriteLine(c3 + " " + a3 + " " + b3);
            }
            else
            {
                if (b3 > c3)
                {
                    Console.WriteLine(c3 + " " + b3 + " " + a3);

                }
                else Console.WriteLine(b3 + " " + c3 + " " + a3);
            }





            //4

            
            int a4 = int.Parse(Console.ReadLine());
            int b4 = int.Parse(Console.ReadLine());
            int c4 = int.Parse(Console.ReadLine());

            int i = 0;
            if (a4 > 0) { i += 1; }
            if (b4 > 0) { i += 1; }
            if (c4 > 0) { i += 1; }
            Console.WriteLine(i);



            //5


            
            int x5 = int.Parse(Console.ReadLine());       
            int y5 = int.Parse(Console.ReadLine());
            if (x5 > 0 && y5 > 0)
            {
                Console.WriteLine("1 четверть");

            }
            if (x5 < 0 && y5 > 0)
            {
                Console.WriteLine("2 четверть");
            }
            if (x5 < 0 && y5 < 0)
            {
                Console.WriteLine("3 четверть");

            }

            if (x5 > 0 && y5 < 0)
            {
                Console.WriteLine("4 четверть");
            }

            //6
            double x3; double a; double b; double c; double d; double x1; double x2;
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            d = (b * b) - 4 * (a * c);

            if (d < 0)
            {
                Console.WriteLine("d<0");
            }
            else if (d == 0)
            {
                x3 = (-b) / (2 * a);
                Console.WriteLine("x=" + x3);
            }
            else if (d > 0)
            {
                x1 = ((-b) + (Math.Sqrt(d))) / (2 * a);
                x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 =" + x2);


            }


           //7

            int y6 = int.Parse(Console.ReadLine());
            if (y6 % 4 == 0)
            {
                if (y6 % 100 == 0)
                {
                    if (y6 % 400 == 0)
                    {
                        Console.WriteLine("Да");
                    }
                    else Console.WriteLine("Нет");
                }
                else { Console.WriteLine("Да"); }
            }
            else { Console.WriteLine("Нет"); }




            //8

            

            string i8 = Console.ReadLine();
            string b8 = i8.Substring(2, 1);
            string d8 = i8.Substring(3, 1);
            string p8 = d8 + b8;

            if (i8.Substring(0, 2) == p8)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Net");
            }



            //9

           
            int x10 = int.Parse(Console.ReadLine());
            int x20 = int.Parse(Console.ReadLine());
            int y10 = int.Parse(Console.ReadLine());
            int y20 = int.Parse(Console.ReadLine());
            if ((x10 * x20 > 0) && (y10 * y20 > 0))
            {
                Console.WriteLine("Координаты на одной плоскости");

            }
            else
            {
                Console.WriteLine("Координаты не на одной плоскости");
            }




            //10

            Console.WriteLine("Введите числа");
            int i11 = int.Parse(Console.ReadLine());
            int b11 = int.Parse(Console.ReadLine());
            int c11 = int.Parse(Console.ReadLine());
            if (i11 % 2 == 0 || b11 % 2 == 0 || c11 % 2 == 0)
            {
                Console.WriteLine("Есть четное");
            }
            else { Console.WriteLine("Четного нет"); }
            if (i11 % 2 != 0 || b11 % 2 != 0 || b11 % 2 != 0)
            {
                Console.WriteLine("Есть нечетное");
            }
            else { Console.WriteLine("Нечетного нет"); }

            
        }
    }
}
