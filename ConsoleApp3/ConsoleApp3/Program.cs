using System;

namespace Stopien3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, p, q, w, delta, u, v, fi;
            Console.Write("Wprowadź a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Wprowadź b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Wprowadź c: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Wprowadź d: ");
            d = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                w = -b / (3 * a);
                p = ((3 * a * Math.Pow(w, 2)) + (2 * b * w) + c) / a;
                q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
                delta = (Math.Pow(q, 2) / 4) + (Math.Pow(q, 3) / 27);

                Console.WriteLine(p + " " + w + " " + q);

                if (delta > 0)
                {
                    u = Math.Pow((-q / 2) + Math.Sqrt(delta), 1 / 3);
                    v = Math.Pow((-q / 2) - Math.Sqrt(delta), 1 / 3);

                    double x1 = u + v + w;
                    double x2 = -1 / 2 * (u + v) + w + (Math.Sqrt(3) / 2) * (u - v);
                    double x3 = -1 / 2 * (u + v) + w - (Math.Sqrt(3) / 2) * (u - v);

                    Console.WriteLine("Delta jest większa od zera, wynikiem jest jeden pierwiastek rzeczywisty oraz dwa zespolone:");
                    Console.WriteLine("x1: " + x1 + " - Wynik rzeczywisty");
                    Console.WriteLine("x2: " + x2 + "i" + " - Pierwszy wynik zespolony");
                    Console.WriteLine("x3: " + x3 + "i" + " - Drugi wynik zespolony");
                }
                else if (delta < 0)
                {
                    fi = Math.Acos((3 * q) / (2 * p * Math.Sqrt(-p / 3)));

                    double x1 = w + 2 * Math.Sqrt(-p / 3) * Math.Cos(fi / 3);
                    double x2 = w + 2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + (2 / 3) * Math.PI);
                    double x3 = w + 2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + (4 / 3) * Math.PI);

                    Console.WriteLine("Delta jest mniejsza od zera, wynikiem będą trzy pierwiastki rzeczywiste:");
                    Console.WriteLine("x1: " + x1);
                    Console.WriteLine("x2: " + x2);
                    Console.WriteLine("x3: " + x3);
                }
                else
                {
                    double x1 = w - 2 * Math.Pow(q / 2, (double)1 / 3);
                    double x23 = w + Math.Pow(q / 2, (double)1 / 3);

                    Console.WriteLine("Delta jest równa zero, wynikiem będą dwa pierwiastki rzeczywiste (z czego jeden podwójny");
                    Console.WriteLine("x1: " + x1);
                    Console.WriteLine("x23: " + x23 + " - pierwiastek podwójny");

                }
            }
        }
    }
}

