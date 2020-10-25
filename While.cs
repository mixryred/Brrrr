using System;
using System.Collections.Specialized;

namespace While
{
    public class While
    {
        static void Main(string[] args)
        {
            return;
        }

        public int While1(int a, int b)
        {
            int numOfSegments = 0;
            while (a - b > 0)
            {
                a -= b;
                numOfSegments++;
            }
            return (numOfSegments);
        }

        static void While5()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            while (a != 2)
            {
                a /= 2;
                b++;
            }
            Console.WriteLine(b);
        }

        static void While9()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b = 3;
            int c = 1;
            while (a < b + 1)
            {
                b *= 3;
                c++;
            }
            Console.WriteLine(b);
        }

        static void While13()
        {
            int A;
            A = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            double sum = 0;
            while (sum < A)
            {
                sum += 1.0 / b;
                b++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(--b);
        }

        static void While17()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                int b = a % 10;
                a = a / 10;
                Console.WriteLine(b);
            }
        }

        public string While21(int n)
        {
            while (a != 0)
            {
                int b = a % 10;
                a = a / 10;
                if (b % 2 == 1)
                {
                    return ("TRUE");
                }
            }
            return ("FALSE");
        }

        static void While25()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            while (true)
            {
                if (f1 > a)
                {
                    Console.WriteLine(f1);
                    break;
                }
                if (f2 > a)
                {
                    Console.WriteLine(f2);
                    break;
                }
                f1 = f1 + f2;
                f2 = f1 + f2;
            }
        }

        static void While29()
        {
            double E;
            E = Convert.ToDouble(Console.ReadLine());
            double Akm2 = 1;
            double Akm1 = 2;
            int a = 3;
            double Akm = (Akm2 + 2 * Akm1) / a;
            while (true)
            {
                if (Math.Abs(Akm - Akm1) < E)
                {
                    Console.WriteLine(a);
                    break;
                }
                Akm2 = Akm1;
                Akm1 = Akm;
                Akm = (Akm2 + 2 * Akm1) / a;
                a++;
            }
        }
    }
}
