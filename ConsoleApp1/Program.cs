using System;
using System.IO;
public class program
{
    public static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("введите первое число: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("введите второе число: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("введите третье число: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("введите четвертое число: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("среднее между {0}, {1}, {2}, {3} это: {4} ",
     number1, number2, number3, number4, result);
    }
}
