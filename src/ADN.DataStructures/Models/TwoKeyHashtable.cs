using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ADN.DataStructures
{
    /// <summary>
    /// Represents a collection of 2-keys/value trios that are organized based on the hash code of the 2-keys.
    /// </summary>
    public class TwoKeyHashtable
    {
        private Hashtable _internalTable = new Hashtable();

        /// <summary>
        /// Adds an element with the specified keys and value into the TwoKeyHashtable.
        /// </summary>
        /// <param name="key">The first key of the element to add.</param>
        /// <param name="key2">The second key of the element to add.</param>
        /// <param name="val">The value of the element to add.</param>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// </code>
        /// </example>
        public void Add(object key, object key2, object val)
        {
            Hashtable htRow = default(Hashtable);

            if (_internalTable.Contains(key))
            {
                htRow = (Hashtable)(_internalTable[key]);
            }
            else
            {
                htRow = new Hashtable();
                _internalTable[key] = htRow;
            }

            htRow[key2] = val;
        }

        /// <summary>
        /// Removes all elements from the TwoKeyHashtable.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.Clear();
        /// </code>
        /// </example>
        public void Clear()
        {
            _internalTable.Clear();
        }

        /// <summary>
        /// Determines whether the TwoKeyHashtable contains the two specific key element.
        /// </summary>
        /// <param name="key">The first key to locate in the TwoKeyHashtable.</param>
        /// <param name="key2">The second key to locate in the TwoKeyHashtable.</param>
        /// <returns>True if contains the two specific key element, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.Contains("key", "key2");
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public bool Contains(object key, object key2)
        {
            if (_internalTable.Contains(key))
            {
                if (((Hashtable)(_internalTable[key])).Contains(key2))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the TwoKeyHashtable contains the specific row.
        /// </summary>
        /// <param name="key">The key to locate in the TwoKeyHashtable.</param>
        /// <returns>True if contains the specific key element, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.ContainsRow("key");
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public bool ContainsRow(object key)
        {
            return _internalTable.Contains(key);
        }

        /// <summary>
        /// Gets the number of key/value pairs contained in a dimension of the TwoKeyHashtable.
        /// </summary>
        /// <param name="key">The dimension key of the TwoKeyHashtable.</param>
        /// <returns>The number of elements contained in the TwoKeyHashtable for a specific dimension.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.Count("key");
        /// 
        /// /*
        /// result is 1
        /// */
        /// </code>
        /// </example>
        public int Count(object key)
        {
            if (_internalTable.Contains(key))
            {
                return ((Hashtable)_internalTable[key]).Count;
            }

            return 0;
        }

        /// <summary>
        /// Gets the number of first key trios contained in the TwoKeyHashtable.
        /// </summary>
        /// <returns>The number of elements contained in the TwoKeyHashtable.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.CountRow();
        /// 
        /// /*
        /// result is 1
        /// */
        /// </code>
        /// </example>
        public int CountRow()
        {
            return _internalTable.Count;
        }

        /// <summary>
        /// Gets the value associated with the specified keys.
        /// </summary>
        /// <param name="key">The first key whose value to get or set.</param>
        /// <param name="key2">The second key whose value to get or set.</param>
        /// <returns>The value associated with the specified key.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.Item("key", "key2");
        /// 
        /// /*
        /// result is "value"
        /// */
        /// </code>
        /// </example>
        public dynamic Item(object key, object key2)
        {
            if (_internalTable.Contains(key))
            {
                if (((Hashtable)(_internalTable[key])).Contains(key2))
                {
                    return ((Hashtable)(_internalTable[key]))[key2];
                }
            }

            return null;
        }

        /// <summary>
        /// Gets an ICollection containing the keys in the TwoKeyHashtable.
        /// </summary>
        /// <returns>An ICollection containing the keys in the TwoKeyHashtable.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.Keys();
        /// </code>
        /// </example>
        public ICollection Keys()
        {
            return _internalTable.Keys;
        }

        /// <summary>
        /// Removes the element with the two specified keys from the TwoKeyHashtable.
        /// </summary>
        /// <param name="key">The first key of the element to remove.</param>
        /// <param name="key2">The second key of the element to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// twoKeyHashtable.Remove("key", "key2");
        /// </code>
        /// </example>
        public void Remove(object key, object key2)
        {
            if (_internalTable.Contains(key))
            {
                Hashtable htRow = (Hashtable)(_internalTable[key]);
                htRow.Remove(key2);

                //delete empty row
                if (htRow.Count == 0)
                {
                    _internalTable.Remove(key);
                }
            }
        }

        /// <summary>
        /// Removes the row with the specified key from the TwoKeyHashtable.
        /// </summary>
        /// <param name="key">The key of the row to remove.</param>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// twoKeyHashtable.RemoveRow("key");
        /// </code>
        /// </example>
        public void RemoveRow(object key)
        {
            _internalTable.Remove(key);
        }

        /// <summary>
        /// Gets an ICollection containing the keys of the specified row in the TwoKeyHashtable.
        /// </summary>
        /// <param name="key">The key of the row to gets the ICollection.</param>
        /// <returns>An ICollection containing the keys of the specified row in the TwoKeyHashtable.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var twoKeyHashtable = new TwoKeyHashtable();
        /// twoKeyHashtable.Add("key", "key2", "value");
        /// var result = twoKeyHashtable.RowKeys("key");
        /// </code>
        /// </example>
        public ICollection RowKeys(object key)
        {
            if (_internalTable.Contains(key))
            {
                return ((Hashtable)(_internalTable[key])).Keys;
            }

            return null;
        }
    }
}
