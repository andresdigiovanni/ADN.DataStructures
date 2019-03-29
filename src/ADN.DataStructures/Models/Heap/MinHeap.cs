using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.DataStructures
{
    /// <summary>
    /// Array-based Heap implementation.
    /// </summary>
    /// <typeparam name="T">Kind of thing being stored in the heap.</typeparam>
    public class MinHeap<T> : Heap<T>, IHeap<T> where T : IComparable
    {
        /// <summary>
        /// Create a new heap.
        /// </summary>
        /// <param name="minSize">The minimum number of elements the heap is expected to hold.</param>
        public MinHeap(int minSize) : base(minSize)
        { }

        protected override int DoCompare(int initialIndex, int contenderIndex)
        {
            T initial = _heap[initialIndex];
            T contender = _heap[contenderIndex];
            int value = initial.CompareTo(contender);
            return value;
        }
    }
}
