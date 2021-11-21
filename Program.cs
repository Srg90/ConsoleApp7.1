using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;
            double c = 26;
            double S1;
            triangle1(a, b, c, out S1);
            Console.WriteLine("Площадь треугольника 1 составляет = {0}", S1);
            Console.WriteLine();
            double d = 18;
            double e = 19;
            double f = 25;
            double S2;
            triangle2(d, e, f, out S2);
            Console.WriteLine("Площадь треугольника 2 составляет = {0}", S2);
            Console.WriteLine();
            if (S1 > S2)
            {
                Console.WriteLine("Площадь треугольника 1 больше площади треугольника 2");
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь треугольника 2 больше площади треугольника 1");
            }    


            Console.ReadKey();
        }
        static void triangle1 (double a, double b, double c, out double S1)
        {
            Console.WriteLine("Треугольник 1 с параметрами сторон - 10, 20, 26");
            
            double p = (a + b + c) / 2;
            S1 = Math.Round((Math.Sqrt(p * (p-a) * (p-b) * (p-c))),2);
            
        }
        
        static void triangle2(double d, double e, double f, out double S2)
        {
            Console.WriteLine("Треугольник 2 с параметрами сторон - 18, 19, 25");
            
            double p = (d + e + f) / 2;
            S2 = Math.Round((Math.Sqrt(p * (p - d) * (p - e) * (p - f))),2);
            
        }
    }

}
