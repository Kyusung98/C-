using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;
            int num2 = 5;
            long longNum = 100000000000000000;
            short shortNum = 5000;
            byte byteNum = 250;
            float floatNum = 0.5F;
            double doubleNum = 0.5555555555;
            bool logic = true;
            string tmp = "aas";
            
            num = int.Parse(tmp);
            string hi = "";
            hi = num.ToString();

            int a = 5;
            int b = 6;
            b = a;
            Console.WriteLine(num + num2);
            Console.WriteLine(b);
        }
    }
}