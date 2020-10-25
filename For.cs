using System;
using System.Transactions;

namespace For
{
    public class For
    {
        static void Main(string[] args)
        {
            return;
        }

        static void For1()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(b);
            }
        }

        static void For5()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            for (decimal i = 0.1M; i < 1; i += 0.1M)
            {
                Console.WriteLine(a * i);
            }
        }

        public int For9(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                double result = Math.Sqrt(i);
                bool isSquare = result % 1 == 0;
                if (isSquare)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public decimal For13(decimal a)
        {
            decimal sum = 0;
            for (decimal i = 1.1M; i <= 1 + (n / 10); i += 0.1M)
            {
                sum += (((i % 1) * 10) % 2 == 0 ? -i : i);
            }
            return (sum);
        }

        static void For17()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            double ans = 0;
            for (int i = 0; i <= b; i++)
            {
                ans += Math.Pow(a, i);
            }
            Console.WriteLine(ans);
        }

        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }

        public double For21(int a)
        {
            double sum = 1;
            for (int i = 1; i <= a; i++)
            {
                double dividend = factorial_Recursion(i);
                sum += 1 / dividend;
            }
            return (sum);
        }

        static void For25()
        {
            double x = 0.5;
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            double ans = 0;
            for (int i = 1; i <= a; i++)
            {
                double number = Math.Pow(x, i) / i;
                ans += (i % 2 == 0 ? -number : number);
            }
            Console.WriteLine(ans);
        }

        static void For29()
        {
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            double a, b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            double lenghtOfOnePart = (b - a) / n;
            for (double i = a; i <= b; i += lenghtOfOnePart)
            {
                Console.WriteLine(i);
            }
        }

        static void For33()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            int f3 = 0;
            for (int i = 0; i < a - 2; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine(f3);
        }

        static void For37()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += Math.Pow(i, i);
            }
            Console.WriteLine(sum);
        }
    }
}