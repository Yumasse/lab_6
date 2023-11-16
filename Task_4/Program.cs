namespace Task_4
{
    class Program
    {
        static void Main()
        {
          
            TaskScheduler<string, int> scheduler = new TaskScheduler<string, int>(task => task.Length);

            while (true)
            {
                Console.WriteLine("Введіть завдання (або 'exit' для завершення):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                scheduler.AddTask(input);
                scheduler.DisplayQueue();
            }

            Console.WriteLine("\nВиконання завдань:");
            scheduler.ExecuteNext(task => Console.WriteLine($"Виконано завдання: {task}"));
        }
    }
}