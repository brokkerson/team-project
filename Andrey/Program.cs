using System;
using CalculatorProject;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");

            try
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = CalculatorLogic.Calculate(num1, num2, operation);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
