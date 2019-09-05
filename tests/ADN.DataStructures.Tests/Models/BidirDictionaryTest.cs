using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.DataStructures.Tests
{
    public class BidirDictionaryTest
    {
        [Fact]
        public void GetEnumerator()
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < 100; i++)
            {
                bidirDictionary.Add(i, i + "foo");
            }

            int j = 0;
            foreach (var item in bidirDictionary)
            {
                result &= item.Key == j && item.Value == (j + "foo");
                j++;
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1000)]
        public void Clear(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
            }
            bidirDictionary.Clear();

            var result = bidirDictionary.Count();
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1000)]
        public void Contains(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                result &= bidirDictionary.Contains(i);
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void ContainsReverse(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                result &= bidirDictionary.ContainsReverse(i + "foo");
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1000)]
        public void Count(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
            }

            var result = bidirDictionary.Count();
            Assert.Equal(nItems, result);
        }

        [Theory]
        [InlineData(1000)]
        public void Get(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                result &= bidirDictionary.Get(i) == (i + "foo");
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void GetReverse(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                result &= bidirDictionary.GetReverse(i + "foo") == i;
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void Remove(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                bidirDictionary.Remove(i);
                result &= !bidirDictionary.Contains(i);
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void RemoveReverse(int nItems)
        {
            var bidirDictionary = new BidirDictionary<int, string>();
            var result = true;

            for (int i = 0; i < nItems; i++)
            {
                bidirDictionary.Add(i, i + "foo");
                bidirDictionary.RemoveReverse(i + "foo");
                result &= !bidirDictionary.ContainsReverse(i + "foo");
            }

            Assert.True(result);
        }
    }
}
