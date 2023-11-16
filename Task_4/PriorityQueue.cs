using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class PriorityQueue<TItem, TPriority> : IEnumerable<TItem>
    {
        private readonly SortedDictionary<TPriority, Queue<TItem>> priorityQueue = new SortedDictionary<TPriority, Queue<TItem>>();

        public void Enqueue(TItem item, TPriority priority)
        {
            if (!priorityQueue.ContainsKey(priority))
            {
                priorityQueue[priority] = new Queue<TItem>();
            }
            priorityQueue[priority].Enqueue(item);
        }

        public TItem Dequeue()
        {
            if (priorityQueue.Count == 0)
            {
                throw new InvalidOperationException("Черга порожня.");
            }

            var firstPriority = priorityQueue.Keys.First();
            var item = priorityQueue[firstPriority].Dequeue();

            if (priorityQueue[firstPriority].Count == 0)
            {
                priorityQueue.Remove(firstPriority);
            }

            return item;
        }

        public int Count
        {
            get { return priorityQueue.Values.Sum(q => q.Count); }
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            foreach (var queue in priorityQueue.Values)
            {
                foreach (var item in queue)
                {
                    yield return item;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
