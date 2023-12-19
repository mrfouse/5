using System;
public class program
{
    public static void Main()
    {
        Console.WriteLine("выберите шкалу входной температуры:\r\n1. Celsius\r\n2. Kelvin\r\n3. Fahrenheit");
        int nam = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите индикатор температуры (градусы):");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("выберите тип шкалы для преобразования:\r\n1. Celsius\r\n2. Kelvin\r\n3. Fahrenheit\r\n");
        int nam2 = Convert.ToInt32(Console.ReadLine());
        if (nam == 1 & nam2 == 1)
        {
            Console.WriteLine("вы выбрали: Celsius > Celsius");
            Console.WriteLine("результат: " + temp);
        }
        else if (nam == 1 & nam2 == 2)
        {
            Console.WriteLine("u have chosen: Celsius > Kelvin");
            double kel = temp + 273;
            Console.WriteLine("conversion result: " + kel);

        }
        else if (nam == 1 & nam2 == 3)
        {
            Console.WriteLine("вы выбрали: Celsius > Fahrenheit");
            double far = (temp + 273) * 1.8 - 459;
            Console.WriteLine("результат: " + far);
        }
        else if (nam == 2 & nam2 == 1)
        {
            Console.WriteLine("вы выбрали: Kelvin > Celsius");
            double cel = temp - 273;
            Console.WriteLine("результат: " + cel);
        }
        else if (nam == 2 & nam2 == 2)
        {
            Console.WriteLine("вы выбрали: Kelvin > Kelvin");
            Console.WriteLine("результат: " + temp);
        }
        else if (nam == 2 & nam2 == 3)
        {
            Console.WriteLine("вы выбрали: Kelvin > Fahrenheit");
            double far2 = temp * 1.8 - 459;
            Console.WriteLine("результат: " + far2);

        }
        else if (nam == 3 & nam2 == 1)
        {
            Console.WriteLine("вы выбрали: Fahrenheit > Celsius");
            double cel2 = (temp - 32) / 1.8;
            Console.WriteLine("результат: " + cel2);
        }
        else if (nam == 3 & nam2 == 2)
        {
            Console.WriteLine("вы выбрали: Fahrenheit > Kelvin");
            double kel2 = (temp + 459) / 1.8;
            Console.WriteLine("результат: " + kel2);
        }
        else if (nam == 3 & nam2 == 3)
        {
            Console.WriteLine("вы выбрали: Fahrenheit > Fahrenheit");
            Console.WriteLine("результат: " + temp);

        }
    }
}
