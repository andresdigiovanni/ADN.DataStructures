using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.DataStructures
{
    /// <summary>
    /// Array-based Heap implementation.
    /// </summary>
    /// <typeparam name="T">Kind of thing being stored in the heap.</typeparam>
    public interface IHeap<T> where T : IComparable
    {
        /// <summary>
        /// Current size of the Heap.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add a new value to the Heap.
        /// </summary>
        /// <param name="val">New value.</param>
        void Insert(T val);

        /// <summary>
        /// Test to see if the Heap is empty.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// View the value currently at the top of the Heap.
        /// </summary>
        /// <returns>Value at the top of the Heap.</returns>
        T Peek();

        /// <summary>
        /// Remove the value currently at the top of the Heap and return it.
        /// </summary>
        /// <returns>Value at the top of the Heap.</returns>
        T Remove();
    }
}
