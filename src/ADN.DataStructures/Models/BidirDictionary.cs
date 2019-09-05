using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ADN.DataStructures
{
    /// <summary>
    /// Represents a two-way Dictionary.
    /// </summary>
    /// <typeparam name="T1">The first type of the elements in the dictionary.</typeparam>
    /// <typeparam name="T2">The second type of the elements in the dictionary.</typeparam>
    public class BidirDictionary<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>
    {
        private Dictionary<T1, T2> _forward = new Dictionary<T1, T2>();
        private Dictionary<T2, T1> _reverse = new Dictionary<T2, T1>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the BidirDictionary.
        /// </summary>
        /// <returns>Returns an enumerator that iterates through the forward Dictionary.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// foreach (var item in bidirDictionary)
        /// {
        ///     Console.WriteLine($"T1: {item.Key} T2: {item.Value}");
        /// }
        /// </code>
        /// </example>
        public IEnumerator<KeyValuePair<T1, T2>> GetEnumerator()
        {
            return _forward.GetEnumerator();
        }

        /// <summary>
        /// Adds an element into the BidirDictionary.
        /// </summary>
        /// <param name="t1">The first type of the elements in the dictionary.</param>
        /// <param name="t2">The second type of the elements in the dictionary.</param>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// </code>
        /// </example>
        public void Add(T1 t1, T2 t2)
        {
            _forward.Add(t1, t2);
            _reverse.Add(t2, t1);
        }

        /// <summary>
        /// Removes all elements from the BidirDictionary.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// bidirDictionary.Clear();
        /// </code>
        /// </example>
        public void Clear()
        {
            _forward.Clear();
            _reverse.Clear();
        }

        /// <summary>
        /// Determines whether the BidirDictionary contains a T1 item.
        /// </summary>
        /// <param name="t1">The first type of the elements in the dictionary.</param>
        /// <returns>True if the BidirDictionary contains T1 element; otherwise, false.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// var exists = bidirDictionary.Contains(0);
        /// </code>
        /// </example>
        public bool Contains(T1 t1)
        {
            return _forward.ContainsKey(t1);
        }

        /// <summary>
        /// Determines whether the BidirDictionary contains a T2 item.
        /// </summary>
        /// <param name="t2">The second type of the elements in the dictionary.</param>
        /// <returns>True if the BidirDictionary contains T2 element; otherwise, false.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// var exists = bidirDictionary.ContainsReverse("foo");
        /// </code>
        /// </example>
        public bool ContainsReverse(T2 t2)
        {
            return _reverse.ContainsKey(t2);
        }

        /// <summary>
        /// Gets the number of elements contained in the BidirDictionary.
        /// </summary>
        /// <returns>The number of items contained in the BidirDictionary.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// var count = bidirDictionary.Count();
        /// </code>
        /// </example>
        public int Count()
        {
            return _forward.Count;
        }

        /// <summary>
        /// Gets the value associated with T1 element.
        /// </summary>
        /// <param name="t1">The first type of the elements in the dictionary.</param>
        /// <returns>The value associated with T1 element.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// var t1 = bidirDictionary.Get(0);
        /// </code>
        /// </example>
        public T2 Get(T1 t1)
        {
            return _forward[t1];
        }

        /// <summary>
        /// Gets the value associated with T2 element.
        /// </summary>
        /// <param name="t2">The second type of the elements in the dictionary.</param>
        /// <returns>The value associated with T2 element.</returns>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// var t2 = bidirDictionary.GetReverse("foo");
        /// </code>
        /// </example>
        public T1 GetReverse(T2 t2)
        {
            return _reverse[t2];
        }

        /// <summary>
        /// Removes the element T1 from the BidirDictionary.
        /// </summary>
        /// <param name="t1">The T1 element to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// bidirDictionary.Remove(0);
        /// </code>
        /// </example>
        public void Remove(T1 t1)
        {
            T2 t2 = _forward[t1];
            _forward.Remove(t1);
            _reverse.Remove(t2);
        }

        /// <summary>
        /// Removes the element T2 from the BidirDictionary.
        /// </summary>
        /// <param name="t2">The T2 element to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// <![CDATA[var bidirDictionary = new BidirDictionary<int, string>();]]>
        /// bidirDictionary.Add(0, "foo");
        /// bidirDictionary.RemoveReverse("foo");
        /// </code>
        /// </example>
        public void RemoveReverse(T2 t2)
        {
            T1 t1 = _reverse[t2];
            _forward.Remove(t1);
            _reverse.Remove(t2);
        }
    }
}
