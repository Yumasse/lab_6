namespace Task_3
{
    class Program
    {
        static void Main()
        {
            FunctionCache<int, int> squareCache = new FunctionCache<int, int>();
            Console.WriteLine("Квадрат числа 5 (виклик функції): " + squareCache.GetOrAdd(5, Square, TimeSpan.FromSeconds(5)));
            Console.WriteLine("Квадрат числа 5 (кешований результат): " + squareCache.GetOrAdd(5, Square, TimeSpan.FromSeconds(5)));
        }


        static int Square(int x)
        {
            Console.WriteLine($"Обчислення квадрату для {x}");
            return x * x;
        }
    }
}