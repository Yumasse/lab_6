using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class TaskScheduler<TTask, TPriority>
    {
        private PriorityQueue<TTask, TPriority> taskQueue = new PriorityQueue<TTask, TPriority>();
        private Func<TTask, TPriority> prioritySelector;

        public delegate void TaskExecution(TTask task);


        public TaskScheduler(Func<TTask, TPriority> prioritySelector)
        {
            this.prioritySelector = prioritySelector ?? throw new ArgumentNullException(nameof(prioritySelector));
        }

        public void AddTask(TTask task)
        {
            TPriority priority = prioritySelector(task);
            taskQueue.Enqueue(task, priority);
        }


        public void ExecuteNext(TaskExecution taskExecution)
        {
            if (taskQueue.Count > 0)
            {
                var nextTask = taskQueue.Dequeue();
                taskExecution(nextTask);
            }
            else
            {
                Console.WriteLine("Немає завдань для виконання.");
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Завдання в черзі:");
            foreach (var task in taskQueue)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();
        }
    }

}
