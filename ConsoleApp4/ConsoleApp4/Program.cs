using System;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] cars = new string[10];

            string[] food = { "apple", "banana" };

            int[] myNum = { 10, 20, 30 };
            
            Console.WriteLine("1번값" + food[0]);
            Console.WriteLine("2번값" + food[1]);

            food[0] = "watermelon";
            Console.WriteLine("변경값" + food[0]);
            Console.WriteLine("길이" + food.Length);

            int[,] myNums = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int var = myNums[0, 2];
            Console.WriteLine("배열값" + var);

            int[][] myNum2 = new int[4][];
            myNum2[0] = new int[2] { 1, 2 };
            myNum2[1] = new int[3] { 3, 4, 5 };

            int var2 = myNum2[0][1];
            Console.WriteLine("var2" + var2);
        }
    }
}