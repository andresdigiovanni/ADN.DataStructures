﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.DataStructures
{
    /// <summary>
    /// Array-based Heap implementation.
    /// </summary>
    /// <typeparam name="T">Kind of thing being stored in the heap.</typeparam>
    public class Heap<T> where T : IComparable
    {
        private enum HeapType
        {
            Min,
            Max
        };

        private readonly HeapType _heapType;
        private T[] _heap;

        /// <summary>
        /// Create a new heap.
        /// </summary>
        /// <param name="minSize">The minimum number of elements the heap is expected to hold.</param>
        /// <param name="isMaxHeap">If "true", this is a Max Heap, where the largest values rise to the top. Otherwise, this is a Min Heap.</param>
        public Heap(int minSize, bool isMaxHeap = false)
        {
            _heapType = isMaxHeap ? HeapType.Max : HeapType.Min;
            _heap = new T[((int)Math.Pow(2, Math.Ceiling(Math.Log(minSize, 2))))];
        }

        /// <summary>
        /// Current size of the Heap.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var heap = new Heap<int>(2);
        /// heap.Insert(1);
        /// heap.Insert(2);
        /// var result = heap.Count;
        /// 
        /// /*
        /// result is 2
        /// */
        /// </code>
        /// </example>
        public int Count { get; private set; }

        /// <summary>
        /// Test to see if the Heap is empty.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var heap = new Heap<int>(1);
        /// var result = heap.IsEmpty;
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public bool IsEmpty { get { return Count == 0; } }

        /// <summary>
        /// Add a new value to the Heap.
        /// </summary>
        /// <param name="val">New value.</param>
        /// <example>
        /// <code lang="csharp">
        /// var heap = new Heap<int>(1);
        /// heap.Insert(1);
        /// </code>
        /// </example>
        public void Insert(T val)
        {
            if (Count == _heap.Length)
            {
                DoubleHeap();
            }
            _heap[Count] = val;
            ShiftUp(Count);
            Count++;
        }

        /// <summary>
        /// View the value currently at the top of the Heap.
        /// </summary>
        /// <returns>Value at the top of the Heap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var heap = new Heap<int>(1);
        /// heap.Insert(1);
        /// heap.Insert(2);
        /// heap.Insert(3);
        /// var result = heap.Peek();
        /// 
        /// /*
        /// result is 1
        /// */
        /// </code>
        /// </example>
        public T Peek()
        {
            if (_heap.Length == 0) throw new ArgumentOutOfRangeException("No values in heap");
            return _heap[0];
        }

        /// <summary>
        /// Remove the value currently at the top of the Heap and return it.
        /// </summary>
        /// <returns>Value at the top of the Heap.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var heap = new Heap<int>(1);
        /// heap.Insert(1);
        /// heap.Insert(2);
        /// heap.Insert(3);
        /// var result = heap.Remove();
        /// 
        /// /*
        /// result is 1
        /// */
        /// </code>
        /// </example>
        public T Remove()
        {
            T output = Peek();
            Count--;
            _heap[0] = _heap[Count];
            ShiftDown(0);
            return output;
        }

        /// <summary>
        /// Move an element up the Heap.
        /// </summary>
        /// <param name="heapIndex"></param>
        private void ShiftUp(int heapIndex)
        {
            if (heapIndex == 0) return;
            int parentIndex = (heapIndex - 1) / 2;
            bool shouldShift = DoCompare(parentIndex, heapIndex) > 0;
            if (!shouldShift) return;
            Swap(parentIndex, heapIndex);
            ShiftUp(parentIndex);
        }

        /// <summary>
        /// Move an element down the Heap.
        /// </summary>
        /// <param name="heapIndex"></param>
        private void ShiftDown(int heapIndex)
        {
            int child1 = heapIndex * 2 + 1;
            if (child1 >= Count) return;
            int child2 = child1 + 1;

            int preferredChildIndex = (child2 >= Count || DoCompare(child1, child2) <= 0) ? child1 : child2;
            if (DoCompare(preferredChildIndex, heapIndex) > 0) return;
            Swap(heapIndex, preferredChildIndex);
            ShiftDown(preferredChildIndex);
        }

        /// <summary>
        /// Swap two items in the underlying array.
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private void Swap(int index1, int index2)
        {
            T temp = _heap[index1];
            _heap[index1] = _heap[index2];
            _heap[index2] = temp;
        }

        /// <summary>
        /// Perform a comparison between two elements of the heap.
        /// This method encapsulates the min/max behavior of the heap so the rest of the class can remain blissfully ignorant.
        /// </summary>
        /// <param name="initialIndex"></param>
        /// <param name="contenderIndex"></param>
        /// <returns></returns>
        private int DoCompare(int initialIndex, int contenderIndex)
        {
            T initial = _heap[initialIndex];
            T contender = _heap[contenderIndex];
            int value = initial.CompareTo(contender);
            if (_heapType == HeapType.Max) value = -value;
            return value;
        }

        /// <summary>
        /// Increase the size of the underlying storage.
        /// </summary>
        private void DoubleHeap()
        {
            var copy = new T[_heap.Length * 2];
            for (int i = 0; i < _heap.Length; i++)
            {
                copy[i] = _heap[i];
            }
            _heap = copy;
        }
    }
}
