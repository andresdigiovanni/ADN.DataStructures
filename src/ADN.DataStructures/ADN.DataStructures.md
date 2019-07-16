# ADN.DataStructures

# Content

- [BidirHashtable](#T:ADN.DataStructures.BidirHashtable)

  - [Add(key, val)](#BidirHashtable.Add(key,val))

  - [Clear](#BidirHashtable.Clear)

  - [Contains(key)](#BidirHashtable.Contains(key))

  - [ContainsValue(val)](#BidirHashtable.ContainsValue(val))

  - [Count](#BidirHashtable.Count)

  - [Get(key)](#BidirHashtable.Get(key))

  - [GetKey(val)](#BidirHashtable.GetKey(val))

  - [Remove(key)](#BidirHashtable.Remove(key))

  - [RemoveValue(val)](#BidirHashtable.RemoveValue(val))

  - [Set(key, val)](#BidirHashtable.Set(key,val))

- [Heap<T>](#T:ADN.DataStructures.Heap`1)

  - [Constructor(minSize)](#Heap<T>.#ctor(minSize))

  - [.Heap`1.Count](#P:ADN.DataStructures.Heap`1.Count)

  - [Insert(val)](#Heap<T>.Insert(val))

  - [.Heap`1.IsEmpty](#P:ADN.DataStructures.Heap`1.IsEmpty)

  - [Peek](#Heap<T>.Peek)

  - [Remove](#Heap<T>.Remove)

- [IHeap<T>](#T:ADN.DataStructures.IHeap`1)

  - [.IHeap`1.Count](#P:ADN.DataStructures.IHeap`1.Count)

  - [Insert(val)](#IHeap<T>.Insert(val))

  - [.IHeap`1.IsEmpty](#P:ADN.DataStructures.IHeap`1.IsEmpty)

  - [Peek](#IHeap<T>.Peek)

  - [Remove](#IHeap<T>.Remove)

- [MaxHeap<T>](#T:ADN.DataStructures.MaxHeap`1)

  - [Constructor(minSize)](#MaxHeap<T>.#ctor(minSize))

- [MinHeap<T>](#T:ADN.DataStructures.MinHeap`1)

  - [Constructor(minSize)](#MinHeap<T>.#ctor(minSize))

- [TwoKeyHashtable](#T:ADN.DataStructures.TwoKeyHashtable)

  - [Add(key, key2, val)](#TwoKeyHashtable.Add(key,key2,val))

  - [Clear](#TwoKeyHashtable.Clear)

  - [Contains(key, key2)](#TwoKeyHashtable.Contains(key,key2))

  - [ContainsRow(key)](#TwoKeyHashtable.ContainsRow(key))

  - [Count(key)](#TwoKeyHashtable.Count(key))

  - [CountRow](#TwoKeyHashtable.CountRow)

  - [Item(key, key2)](#TwoKeyHashtable.Item(key,key2))

  - [Keys](#TwoKeyHashtable.Keys)

  - [Remove(key, key2)](#TwoKeyHashtable.Remove(key,key2))

  - [RemoveRow(key)](#TwoKeyHashtable.RemoveRow(key))

  - [RowKeys(key)](#TwoKeyHashtable.RowKeys(key))

<a name='T:ADN.DataStructures.BidirHashtable'></a>


## BidirHashtable

Represents a collection of key/value pairs that are organized based on both hash code.

<a name='BidirHashtable.Add(key,val)'></a>


### Add(key, val)

Adds an element with the specified key and value into the BidirHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key of the element to add. |

#### Parameters

| val | *System.Object*<br>The value of the element to add. |


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
```

<a name='BidirHashtable.Clear'></a>


### Clear

Removes all elements from the BidirHashtable.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Clear();
```

<a name='BidirHashtable.Contains(key)'></a>


### Contains(key)

Determines whether the BidirHashtable contains a specific key.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key to locate in the BidirHashtable. |


#### Returns

True if the BidirHashtable contains an element with the specified key; otherwise, false.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Contains("key");

/*
result is true
*/
```

<a name='BidirHashtable.ContainsValue(val)'></a>


### ContainsValue(val)

Determines whether the BidirHashtable contains a specific value.


#### Parameters

| Name | Description |
| ---- | ----------- |
| val | *System.Object*<br>The value to locate in the BidirHashtable. |


#### Returns

True if the BidirHashtable contains an element with the specified value; otherwise, false.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.ContainsValue("value");

/*
result is true
*/
```

<a name='BidirHashtable.Count'></a>


### Count

Gets the number of key/value pairs contained in the BidirHashtable.


#### Returns

The number of key/value pairs contained in the BidirHashtable.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Add("key2", "value2");
var result = bidirHashtable.Count();

/*
result is 2
*/
```

<a name='BidirHashtable.Get(key)'></a>


### Get(key)

Gets the value associated with the specified key.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key whose value to get. |


#### Returns

The value associated with the specified key.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Get("key");

/*
result is "value"
*/
```

<a name='BidirHashtable.GetKey(val)'></a>


### GetKey(val)

Gets the key associated with the specified value.


#### Parameters

| Name | Description |
| ---- | ----------- |
| val | *System.Object*<br>The value whose key to get. |


#### Returns

The key associated with the specified value.


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.GetKey("value");

/*
result is "key"
*/
```

<a name='BidirHashtable.Remove(key)'></a>


### Remove(key)

Removes the element with the specified key from the BidirHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key of the element to remove. |


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Remove("key");
```

<a name='BidirHashtable.RemoveValue(val)'></a>


### RemoveValue(val)

Removes the element with the specified value from the BidirHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| val | *System.Object*<br>The value of the element to remove. |


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.RemoveValue("value");
```

<a name='BidirHashtable.Set(key,val)'></a>


### Set(key, val)

Sets the value associated with the specified key.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key whose value to set. |

#### Parameters

| val | *System.Object*<br>The value of the element to set. |


#### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Set("key", "foo");
var result = bidirHashtable.Get("key");

/*
result is "foo"
*/
```

<a name='T:ADN.DataStructures.Heap`1'></a>


## Heap<T>

Array-based Heap implementation.

<a name='Heap<T>.#ctor(minSize)'></a>


### Constructor(minSize)

Create a new heap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| minSize | *System.Int32*<br>The minimum number of elements the heap is expected to hold. |
<a name='P:ADN.DataStructures.Heap`1.Count'></a>


### .Heap`1.Count

Current size of the Heap.


#### Example

```csharpvar heap = new Heap<int>(2);
heap.Insert(1);
heap.Insert(2);
var result = heap.Count;

/*
result is 2
*/
```

<a name='Heap<T>.Insert(val)'></a>


### Insert(val)

Add a new value to the Heap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| val | *`0*<br>New value. |


#### Example

```csharpvar heap = new Heap<int>(1);
heap.Insert(1);
```

<a name='P:ADN.DataStructures.Heap`1.IsEmpty'></a>


### .Heap`1.IsEmpty

Test to see if the Heap is empty.


#### Example

```csharpvar heap = new Heap<int>(1);
var result = heap.IsEmpty;

/*
result is true
*/
```

<a name='Heap<T>.Peek'></a>


### Peek

View the value currently at the top of the Heap.


#### Returns

Value at the top of the Heap.


#### Example

```csharpvar heap = new Heap<int>(1);
heap.Insert(1);
heap.Insert(2);
heap.Insert(3);
var result = heap.Peek();

/*
result is 1
*/
```

<a name='Heap<T>.Remove'></a>


### Remove

Remove the value currently at the top of the Heap and return it.


#### Returns

Value at the top of the Heap.


#### Example

```csharpvar heap = new Heap<int>(1);
heap.Insert(1);
heap.Insert(2);
heap.Insert(3);
var result = heap.Remove();

/*
result is 1
*/
```

<a name='T:ADN.DataStructures.IHeap`1'></a>


## IHeap<T>

Array-based Heap implementation.

<a name='P:ADN.DataStructures.IHeap`1.Count'></a>


### .IHeap`1.Count

Current size of the Heap.

<a name='IHeap<T>.Insert(val)'></a>


### Insert(val)

Add a new value to the Heap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| val | *`0*<br>New value. |
<a name='P:ADN.DataStructures.IHeap`1.IsEmpty'></a>


### .IHeap`1.IsEmpty

Test to see if the Heap is empty.

<a name='IHeap<T>.Peek'></a>


### Peek

View the value currently at the top of the Heap.


#### Returns

Value at the top of the Heap.

<a name='IHeap<T>.Remove'></a>


### Remove

Remove the value currently at the top of the Heap and return it.


#### Returns

Value at the top of the Heap.

<a name='T:ADN.DataStructures.MaxHeap`1'></a>


## MaxHeap<T>

Array-based Heap implementation.

<a name='MaxHeap<T>.#ctor(minSize)'></a>


### Constructor(minSize)

Create a new heap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| minSize | *System.Int32*<br>The minimum number of elements the heap is expected to hold. |
<a name='T:ADN.DataStructures.MinHeap`1'></a>


## MinHeap<T>

Array-based Heap implementation.

<a name='MinHeap<T>.#ctor(minSize)'></a>


### Constructor(minSize)

Create a new heap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| minSize | *System.Int32*<br>The minimum number of elements the heap is expected to hold. |
<a name='T:ADN.DataStructures.TwoKeyHashtable'></a>


## TwoKeyHashtable

Represents a collection of 2-keys/value trios that are organized based on the hash code of the 2-keys.

<a name='TwoKeyHashtable.Add(key,key2,val)'></a>


### Add(key, key2, val)

Adds an element with the specified keys and value into the TwoKeyHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The first key of the element to add. |

#### Parameters

| key2 | *System.Object*<br>The second key of the element to add. |

#### Parameters

| val | *System.Object*<br>The value of the element to add. |


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
```

<a name='TwoKeyHashtable.Clear'></a>


### Clear

Removes all elements from the TwoKeyHashtable.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Clear();
```

<a name='TwoKeyHashtable.Contains(key,key2)'></a>


### Contains(key, key2)

Determines whether the TwoKeyHashtable contains the two specific key element.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The first key to locate in the TwoKeyHashtable. |

#### Parameters

| key2 | *System.Object*<br>The second key to locate in the TwoKeyHashtable. |


#### Returns

True if contains the two specific key element, false otherwise.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Contains("key", "key2");

/*
result is true
*/
```

<a name='TwoKeyHashtable.ContainsRow(key)'></a>


### ContainsRow(key)

Determines whether the TwoKeyHashtable contains the specific row.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key to locate in the TwoKeyHashtable. |


#### Returns

True if contains the specific key element, false otherwise.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.ContainsRow("key");

/*
result is true
*/
```

<a name='TwoKeyHashtable.Count(key)'></a>


### Count(key)

Gets the number of key/value pairs contained in a dimension of the TwoKeyHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The dimension key of the TwoKeyHashtable. |


#### Returns

The number of elements contained in the TwoKeyHashtable for a specific dimension.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Count("key");

/*
result is 1
*/
```

<a name='TwoKeyHashtable.CountRow'></a>


### CountRow

Gets the number of first key trios contained in the TwoKeyHashtable.


#### Returns

The number of elements contained in the TwoKeyHashtable.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.CountRow();

/*
result is 1
*/
```

<a name='TwoKeyHashtable.Item(key,key2)'></a>


### Item(key, key2)

Gets the value associated with the specified keys.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The first key whose value to get or set. |

#### Parameters

| key2 | *System.Object*<br>The second key whose value to get or set. |


#### Returns

The value associated with the specified key.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Item("key", "key2");

/*
result is "value"
*/
```

<a name='TwoKeyHashtable.Keys'></a>


### Keys

Gets an ICollection containing the keys in the TwoKeyHashtable.


#### Returns

An ICollection containing the keys in the TwoKeyHashtable.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Keys();
```

<a name='TwoKeyHashtable.Remove(key,key2)'></a>


### Remove(key, key2)

Removes the element with the two specified keys from the TwoKeyHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The first key of the element to remove. |

#### Parameters

| key2 | *System.Object*<br>The second key of the element to remove. |


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.Remove("key", "key2");
```

<a name='TwoKeyHashtable.RemoveRow(key)'></a>


### RemoveRow(key)

Removes the row with the specified key from the TwoKeyHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key of the row to remove. |


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.RemoveRow("key");
```

<a name='TwoKeyHashtable.RowKeys(key)'></a>


### RowKeys(key)

Gets an ICollection containing the keys of the specified row in the TwoKeyHashtable.


#### Parameters

| Name | Description |
| ---- | ----------- |
| key | *System.Object*<br>The key of the row to gets the ICollection. |


#### Returns

An ICollection containing the keys of the specified row in the TwoKeyHashtable.


#### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.RowKeys("key");
```

