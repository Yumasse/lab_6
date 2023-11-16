using Task_1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Використання для цілих чисел
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Цілі числа:");
            Console.WriteLine("Додавання: " + intCalculator.PerformOperation('+', 5, 3));
            Console.WriteLine("Віднімання: " + intCalculator.PerformOperation('-', 5, 3));
            Console.WriteLine("Множення: " + intCalculator.PerformOperation('*', 5, 3));
            Console.WriteLine("Ділення: " + intCalculator.PerformOperation('/', 5, 3));

            // Використання для чисел з плаваючою точкою
            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("\nЧисла з плаваючою точкою:");
            Console.WriteLine("Додавання: " + doubleCalculator.PerformOperation('+', 5.5, 3.2));
            Console.WriteLine("Віднімання: " + doubleCalculator.PerformOperation('-', 5.5, 3.2));
            Console.WriteLine("Множення: " + doubleCalculator.PerformOperation('*', 5.5, 3.2));
            Console.WriteLine("Ділення: " + doubleCalculator.PerformOperation('/', 5.5, 3.2));
        }
    }
}