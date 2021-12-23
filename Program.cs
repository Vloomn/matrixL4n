using AdvanceLib;
using System;

namespace ShowCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number...");

            while (true)
            {
                int num;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Log4NetTest.StopwatchLog(num);
                }
                else
                {
                    Console.WriteLine("couldn't recognize a number, please try again.");
                }
            }
        }
    }
}