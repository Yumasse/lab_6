namespace Task_2
{
    class Program
    {
        static void Main()
        {

            Repository<string> stringRepository = new Repository<string>();
            stringRepository.Add("Apple");
            stringRepository.Add("Banana");
            stringRepository.Add("Orange");

            Console.WriteLine("Елементи, які починаються з 'A':");
            List<string> startsWithA = stringRepository.Find(s => s.StartsWith("A"));
            foreach (var item in startsWithA)
            {
                Console.WriteLine(item);
            }

            Repository<int> intRepository = new Repository<int>();
            intRepository.Add(10);
            intRepository.Add(20);
            intRepository.Add(30);

            Console.WriteLine("\nЕлементи, які більше 15:");
            List<int> greaterThan15 = intRepository.Find(i => i > 15);
            foreach (var item in greaterThan15)
            {
                Console.WriteLine(item);
            }
        }
    }
}