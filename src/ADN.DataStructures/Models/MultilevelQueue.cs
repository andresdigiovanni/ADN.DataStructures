using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADN.DataStructures
{
    /// <summary>
    /// Queue with priority elements.
    /// </summary>
    /// <typeparam name="T">Kind of thing being stored in the ADN.DataStructures.MultilevelQueue.</typeparam>
    public class MultilevelQueue<T>
    {
        private const int MILLISECONDS_SLEEP_LOOP_AGING_ITEMS = 1000;

        private readonly List<(T Item, DateTime Time)>[] _queues;
        private static readonly object _lock = new object();
        private readonly uint _secondsToAgingItems;
        private bool _isAliveAgingItemsProcess = true;

        /// <summary>
        /// Create a new ADN.DataStructures.MultilevelQueue.
        /// </summary>
        /// <param name="priorityLevels">Determines how many levels of messages priority exists.</param>
        /// <param name="secondsToAgingItems">Seconds to aging elements and increase the priority.</param>
        public MultilevelQueue(int priorityLevels, uint secondsToAgingItems)
        {
            _queues = new List<(T item, DateTime time)>[priorityLevels];
            for (int i = 0; i < priorityLevels; i++)
            {
                _queues[i] = new List<(T item, DateTime time)>();
            }

            _secondsToAgingItems = secondsToAgingItems;
            Task.Run(() => AgingItemsProcess());
        }

        /// <summary>
        /// Releases all resources used by the current instance of ADN.DataStructures.MultilevelQueue.
        /// </summary>
        public void Dispose()
        {
            _isAliveAgingItemsProcess = false;
        }

        /// <summary>
        /// Gets the number of elements contained in the ADN.DataStructures.MultilevelQueue.
        /// </summary>
        /// <returns>The number of elements contained in the ADN.DataStructures.MultilevelQueue.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var queue = new MultilevelQueue<string>(3, 10);]]>
        /// queue.Add("item low priority", 9);
        /// queue.Add("item high priority", 0);
        /// var result = queue.Count;
        ///
        /// /*
        /// result is 2
        /// */
        /// </code>
        /// </example>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Add a new value with the specific priority.
        /// </summary>
        /// <param name="item">New item.</param>
        /// <param name="priority">Priority.</param>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var queue = new MultilevelQueue<string>(3, 10);]]>
        /// queue.Add("item low priority", 9);
        /// queue.Add("item high priority", 0);
        /// </code>
        /// </example>
        public void Add(T item, int priority)
        {
            lock (_lock)
            {
                _queues[priority].Add((item, DateTime.Now));
                Count++;
            }
        }

        /// <summary>
        /// View the value currently at the top of the queue.
        /// </summary>
        /// <returns>Value at the top of the queue.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var queue = new MultilevelQueue<string>(3, 10);]]>
        /// queue.Add("item low priority", 9);
        /// queue.Add("item high priority", 0);
        /// var result = queue.Peek();
        ///
        /// /*
        /// result is "item high priority"
        /// */
        /// </code>
        /// </example>
        public T Peek()
        {
            lock (_lock)
            {
                for (int i = 0; i < _queues.Length; i++)
                {
                    if (_queues[i].Count > 0)
                    {
                        return _queues[i][0].Item;
                    }
                }
            }

            throw new ArgumentOutOfRangeException("No values in queue");
        }

        /// <summary>
        /// Remove the value currently at the top of the ADN.DataStructures.MultilevelQueue and return it.
        /// </summary>
        /// <returns>Value at the top of the queue.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var queue = new MultilevelQueue<string>(3, 10);]]>
        /// queue.Add("item low priority", 9);
        /// queue.Add("item high priority", 0);
        /// var result = queue.Remove();
        ///
        /// /*
        /// result is "item high priority"
        /// */
        /// </code>
        /// </example>
        public T Remove()
        {
            lock (_lock)
            {
                for (int i = 0; i < _queues.Length; i++)
                {
                    if (_queues[i].Count > 0)
                    {
                        var item = _queues[i][0].Item;
                        _queues[i].RemoveAt(0);
                        Count--;
                        return item;
                    }
                }
            }

            throw new ArgumentOutOfRangeException("No values in queue");
        }

        private void AgingItemsProcess()
        {
            while (_isAliveAgingItemsProcess)
            {
                lock (_lock)
                {
                    var currentTime = DateTime.Now;
                    for (int i = 1; i < _queues.Length; i++)
                    {
                        for (int j = 0; j < _queues[i].Count; j++)
                        {
                            var (item, time) = _queues[i][j];
                            if (time.AddSeconds(_secondsToAgingItems) >= currentTime)
                            {
                                _queues[i - 1].Add((item, DateTime.Now));
                                _queues[i].RemoveAt(j);
                                j--;
                            }
                        }
                    }
                }

                Thread.Sleep(MILLISECONDS_SLEEP_LOOP_AGING_ITEMS);
            }
        }
    }
}
