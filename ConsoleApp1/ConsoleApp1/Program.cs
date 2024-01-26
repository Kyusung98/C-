using System;

namespace ConsoleApp1
{
    class Car
    {
        private string handle = "AMODEL";
        public void carRun()
        {
            Console.WriteLine("자동차를 움직인다.");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("System을 이용한 호출");
            Console.WriteLine("하이");
        }
    }
}