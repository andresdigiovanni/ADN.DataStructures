using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.DataStructures.Tests
{
    public class MultilevelQueueTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void Add(int nValues)
        {
            var queue = new MultilevelQueue<string>(priorityLevels: nValues, secondsToAgingItems:1);
            for (int i = 0; i < nValues; i++)
            {
                queue.Add($"Added item {i}", i);
            }
            var result = queue.Count;

            Assert.Equal(nValues, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10000)]
        public void Peek(int nValues)
        {
            var result = true;
            var queue = new MultilevelQueue<int>(priorityLevels: nValues, secondsToAgingItems: 1);

            for (int i = nValues - 1; i >= 0; i--)
            {
                queue.Add(i, i);
                result &= (i == queue.Peek());
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10000)]
        public void Remove(int nValues)
        {
            var queue = new MultilevelQueue<int>(priorityLevels: nValues, secondsToAgingItems: 1);

            for (int i = 0; i < nValues; i++)
            {
                queue.Add(i, priority: 0);
            }
            for (int i = 0; i < nValues; i++)
            {
                queue.Remove();
            }

            var result = queue.Count;

            Assert.Equal(0, result);
        }
    }
}
