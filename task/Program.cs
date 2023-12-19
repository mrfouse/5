
public class program
{
    public static void Main()
    {
        double a;
        double b;
        double total;
        char oper;

        Console.WriteLine("первое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("-, +, /, * или %:");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("второе число:");
        b = Convert.ToDouble(Console.ReadLine());

        if (oper == '+')
        {
            total = a + b;
            Console.WriteLine("сумма " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '-')
        {
            total = a - b;
            Console.WriteLine("разница " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '*')
        {
            total = a * b;
            Console.WriteLine("умножение " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '/')
        {
            total = a / b;
            Console.WriteLine("деление " + a + " и " + b + " = " + total + ".");
        }

        else if (oper == '%')
        {
            total = a % b;
            Console.WriteLine("остаток " + a + " и " + b + " = " + total + ".");
        }

        else
        {
            Console.WriteLine("попробуйте еще раз");
        }
    }

}