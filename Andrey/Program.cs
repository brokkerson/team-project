using System;
using CalculatorProject;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("����� ���������� � �����������!");

            try
            {
                Console.Write("������� ������ �����: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("������� ������ �����: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("������� �������� (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = CalculatorLogic.Calculate(num1, num2, operation);
                Console.WriteLine($"���������: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������: {ex.Message}");
            }
        }
    }
}
