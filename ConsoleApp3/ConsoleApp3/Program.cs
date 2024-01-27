using System;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 4;
            Console.WriteLine(num1++);
            Console.WriteLine(num1);
            
            Console.WriteLine(++num1);
            Console.WriteLine(num1);

            int num3 = num1 > num2 ? 3 : 5;
            
            Console.WriteLine("num3는" + num3);

            String str = "a" + "bcd" + num1;
            Console.WriteLine(str);

            bool result = false;
            bool result2 = false;
            bool result3 = false;
            int a = 5;
            int b = 10;
            string str1 = "abcde";

            result = (a == b);
            Console.WriteLine(result);
            result2 = (a != b);
            Console.WriteLine(result2);
            result3 = (str1.Contains("abcd"));
            Console.WriteLine(result3);

            int e = 1;
            int f = 5;
            int g = 0;
            
            Console.WriteLine(e & f);
            Console.WriteLine(e | f);
            Console.WriteLine(e ^ g);

            e <<= 1;
            f >>= 1;
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}