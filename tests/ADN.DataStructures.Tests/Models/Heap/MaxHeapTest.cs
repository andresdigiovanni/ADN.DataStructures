using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.DataStructures.Tests
{
    public class MaxHeapTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10000)]
        public void Insert(int values)
        {
            IHeap<int> heap = new MaxHeap<int>(1);
            for (int i = 0; i < values; i++)
            {
                heap.Insert(i);
            }
            var result = heap.Count;

            Assert.Equal(values, result);
        }

        [Fact]
        public void IsEmpty()
        {
            IHeap<int> heap = new MaxHeap<int>(0);

            Assert.True(heap.IsEmpty);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10000)]
        public void Peek(int values)
        {
            var result = true;
            IHeap<int> heap = new MaxHeap<int>(1);

            for (int i = 0; i < values; i++)
            {
                heap.Insert(i);
                result &= (i == heap.Peek());
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10000)]
        public void Remove(int values)
        {
            IHeap<int> heap = new MaxHeap<int>(1);
            for (int i = 0; i < values; i++)
            {
                heap.Insert(i);
            }
            for (int i = 0; i < values; i++)
            {
                heap.Remove();
            }
            var result = heap.Count;

            Assert.True(heap.IsEmpty);
        }
    }
}
