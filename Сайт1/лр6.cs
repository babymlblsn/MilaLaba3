using System;

class Program
{
    static void Main()
    {
        try
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите оператор (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = Calculate(num1, num2, op);
                Console.WriteLine($"Результат: {result}");

                Console.Write("Хотите продолжить? (y/n): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (choice == 'n' || choice == 'N')
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static double Calculate(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' when b != 0 => a / b,
            '/' => throw new DivideByZeroException("Деление на ноль невозможно"),
            _ => throw new ArgumentException("Некорректный оператор")
        };
    }
}
