using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.DataStructures.Tests
{
    public class BidirHashtableTest
    {
        [Theory]
        [InlineData(1000)]
        public void Get(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                result &= bidirHashtable.Get(i) == (i + "foo");
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void GetKey(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                result &= bidirHashtable.GetKey(i + "foo") == i;
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1000)]
        public void Count(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i);
            }

            var result = bidirHashtable.Count();
            Assert.Equal(countKey, result);
        }

        [Theory]
        [InlineData(1000)]
        public void Set(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i);
                bidirHashtable.Set(i, i + "foo");
                result &= bidirHashtable.Get(i) == (i + "foo");
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void Contains(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                result &= bidirHashtable.Contains(i);
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void ContainsValue(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                result &= bidirHashtable.ContainsValue(i + "foo");
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1000)]
        public void Clear(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i);
            }
            bidirHashtable.Clear();

            var result = bidirHashtable.Count();
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1000)]
        public void Remove(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                bidirHashtable.Remove(i);
                result &= !bidirHashtable.Contains(i);
            }

            Assert.True(result);
        }

        [Theory]
        [InlineData(1000)]
        public void RemoveValue(int countKey)
        {
            var bidirHashtable = new BidirHashtable();
            var result = true;

            for (int i = 0; i < countKey; i++)
            {
                bidirHashtable.Add(i, i + "foo");
                bidirHashtable.RemoveValue(i + "foo");
                result &= !bidirHashtable.ContainsValue(i + "foo");
            }

            Assert.True(result);
        }
    }
}
