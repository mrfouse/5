using System;
using System.Linq;

internal class program
{
    public class Example
    {
        public static void Main()
        {
            int[] arr = { 8, 4, -2, 1, 10 };

            Console.WriteLine("самое большое число - " + arr.Max());
            Console.WriteLine("самое малое число - " + arr.Min());
        }
    }
}