using System;

namespace ConsoleApp5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            if (b > a)
            {
                a++;
                Console.WriteLine("a =" + a);
            }

            if (b < a)
            {
                a--;
                Console.WriteLine("a =" + a);
            }
            else
            {
                b = b - 2;
                Console.WriteLine("b = " + b);
            }
            Console.WriteLine("==============");
            int money = 8000;
            if (money < 5000)
            {
                Console.WriteLine("money5000");
            }
            else if (money < 7000)
            {
                Console.WriteLine("money 5000 7000");
            }
            else
            {
                Console.WriteLine("money 9000");
            }

            int score = 20;
            if (score < 10)
            {
                Console.WriteLine("score under 10");
            }
            else
            {
                Console.WriteLine("score up 10");
            }

            string result = (score < 10) ? "score under 10" : "score up 10";
            Console.WriteLine(result);

            int week = 3;

            switch (week)
            {
                case 1:
                    Console.WriteLine("mon");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wen");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}