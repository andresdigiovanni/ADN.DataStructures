<a name='assembly'></a>
# ADN.DataStructures

## Contents

- [BidirHashtable](#T-ADN-DataStructures-BidirHashtable 'ADN.DataStructures.BidirHashtable')
  - [Add(key,val)](#M-ADN-DataStructures-BidirHashtable-Add-System-Object,System-Object- 'ADN.DataStructures.BidirHashtable.Add(System.Object,System.Object)')
  - [Clear()](#M-ADN-DataStructures-BidirHashtable-Clear 'ADN.DataStructures.BidirHashtable.Clear')
  - [Contains(key)](#M-ADN-DataStructures-BidirHashtable-Contains-System-Object- 'ADN.DataStructures.BidirHashtable.Contains(System.Object)')
  - [ContainsValue(val)](#M-ADN-DataStructures-BidirHashtable-ContainsValue-System-Object- 'ADN.DataStructures.BidirHashtable.ContainsValue(System.Object)')
  - [Count()](#M-ADN-DataStructures-BidirHashtable-Count 'ADN.DataStructures.BidirHashtable.Count')
  - [Get(key)](#M-ADN-DataStructures-BidirHashtable-Get-System-Object- 'ADN.DataStructures.BidirHashtable.Get(System.Object)')
  - [GetKey(val)](#M-ADN-DataStructures-BidirHashtable-GetKey-System-Object- 'ADN.DataStructures.BidirHashtable.GetKey(System.Object)')
  - [Remove(key)](#M-ADN-DataStructures-BidirHashtable-Remove-System-Object- 'ADN.DataStructures.BidirHashtable.Remove(System.Object)')
  - [RemoveValue(val)](#M-ADN-DataStructures-BidirHashtable-RemoveValue-System-Object- 'ADN.DataStructures.BidirHashtable.RemoveValue(System.Object)')
  - [Set(key,val)](#M-ADN-DataStructures-BidirHashtable-Set-System-Object,System-Object- 'ADN.DataStructures.BidirHashtable.Set(System.Object,System.Object)')
- [Heap\`1](#T-ADN-DataStructures-Heap`1 'ADN.DataStructures.Heap`1')
  - [#ctor(minSize,isMaxHeap)](#M-ADN-DataStructures-Heap`1-#ctor-System-Int32,System-Boolean- 'ADN.DataStructures.Heap`1.#ctor(System.Int32,System.Boolean)')
  - [DoCompare(initialIndex,contenderIndex)](#M-ADN-DataStructures-Heap`1-DoCompare-System-Int32,System-Int32- 'ADN.DataStructures.Heap`1.DoCompare(System.Int32,System.Int32)')
  - [DoubleHeap()](#M-ADN-DataStructures-Heap`1-DoubleHeap 'ADN.DataStructures.Heap`1.DoubleHeap')
  - [ShiftDown(heapIndex)](#M-ADN-DataStructures-Heap`1-ShiftDown-System-Int32- 'ADN.DataStructures.Heap`1.ShiftDown(System.Int32)')
  - [ShiftUp(heapIndex)](#M-ADN-DataStructures-Heap`1-ShiftUp-System-Int32- 'ADN.DataStructures.Heap`1.ShiftUp(System.Int32)')
  - [Swap(index1,index2)](#M-ADN-DataStructures-Heap`1-Swap-System-Int32,System-Int32- 'ADN.DataStructures.Heap`1.Swap(System.Int32,System.Int32)')
- [TwoKeyHashtable](#T-ADN-DataStructures-TwoKeyHashtable 'ADN.DataStructures.TwoKeyHashtable')
  - [Add(key,key2,val)](#M-ADN-DataStructures-TwoKeyHashtable-Add-System-Object,System-Object,System-Object- 'ADN.DataStructures.TwoKeyHashtable.Add(System.Object,System.Object,System.Object)')
  - [Clear()](#M-ADN-DataStructures-TwoKeyHashtable-Clear 'ADN.DataStructures.TwoKeyHashtable.Clear')
  - [Contains(key,key2)](#M-ADN-DataStructures-TwoKeyHashtable-Contains-System-Object,System-Object- 'ADN.DataStructures.TwoKeyHashtable.Contains(System.Object,System.Object)')
  - [ContainsRow(key)](#M-ADN-DataStructures-TwoKeyHashtable-ContainsRow-System-Object- 'ADN.DataStructures.TwoKeyHashtable.ContainsRow(System.Object)')
  - [Count(key)](#M-ADN-DataStructures-TwoKeyHashtable-Count-System-Object- 'ADN.DataStructures.TwoKeyHashtable.Count(System.Object)')
  - [CountRow()](#M-ADN-DataStructures-TwoKeyHashtable-CountRow 'ADN.DataStructures.TwoKeyHashtable.CountRow')
  - [Item(key,key2)](#M-ADN-DataStructures-TwoKeyHashtable-Item-System-Object,System-Object- 'ADN.DataStructures.TwoKeyHashtable.Item(System.Object,System.Object)')
  - [Keys()](#M-ADN-DataStructures-TwoKeyHashtable-Keys 'ADN.DataStructures.TwoKeyHashtable.Keys')
  - [Remove(key,key2)](#M-ADN-DataStructures-TwoKeyHashtable-Remove-System-Object,System-Object- 'ADN.DataStructures.TwoKeyHashtable.Remove(System.Object,System.Object)')
  - [RemoveRow(key)](#M-ADN-DataStructures-TwoKeyHashtable-RemoveRow-System-Object- 'ADN.DataStructures.TwoKeyHashtable.RemoveRow(System.Object)')
  - [RowKeys(key)](#M-ADN-DataStructures-TwoKeyHashtable-RowKeys-System-Object- 'ADN.DataStructures.TwoKeyHashtable.RowKeys(System.Object)')

<a name='T-ADN-DataStructures-BidirHashtable'></a>
## BidirHashtable `type`

##### Namespace

ADN.DataStructures

##### Summary

Represents a collection of key/value pairs that are organized based on both hash code.

<a name='M-ADN-DataStructures-BidirHashtable-Add-System-Object,System-Object-'></a>
### Add(key,val) `method`

##### Summary

Adds an element with the specified key and value into the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the element to add. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to add. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value"); 
```

<a name='M-ADN-DataStructures-BidirHashtable-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the BidirHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Clear(); 
```

<a name='M-ADN-DataStructures-BidirHashtable-Contains-System-Object-'></a>
### Contains(key) `method`

##### Summary

Determines whether the BidirHashtable contains a specific key.

##### Returns

True if the BidirHashtable contains an element with the specified key; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key to locate in the BidirHashtable. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Contains("key");
/*
result is true
*/ 
```

<a name='M-ADN-DataStructures-BidirHashtable-ContainsValue-System-Object-'></a>
### ContainsValue(val) `method`

##### Summary

Determines whether the BidirHashtable contains a specific value.

##### Returns

True if the BidirHashtable contains an element with the specified value; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to locate in the BidirHashtable. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.ContainsValue("value");
/*
result is true
*/ 
```

<a name='M-ADN-DataStructures-BidirHashtable-Count'></a>
### Count() `method`

##### Summary

Gets the number of key/value pairs contained in the BidirHashtable.

##### Returns

The number of key/value pairs contained in the BidirHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Add("key2", "value2");
var result = bidirHashtable.Count();
/*
result is 2
*/ 
```

<a name='M-ADN-DataStructures-BidirHashtable-Get-System-Object-'></a>
### Get(key) `method`

##### Summary

Gets the value associated with the specified key.

##### Returns

The value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key whose value to get. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Get("key");
/*
result is "value"
*/ 
```

<a name='M-ADN-DataStructures-BidirHashtable-GetKey-System-Object-'></a>
### GetKey(val) `method`

##### Summary

Gets the key associated with the specified value.

##### Returns

The key associated with the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value whose key to get. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.GetKey("value");
/*
result is "key"
*/ 
```

<a name='M-ADN-DataStructures-BidirHashtable-Remove-System-Object-'></a>
### Remove(key) `method`

##### Summary

Removes the element with the specified key from the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the element to remove. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Remove("key"); 
```

<a name='M-ADN-DataStructures-BidirHashtable-RemoveValue-System-Object-'></a>
### RemoveValue(val) `method`

##### Summary

Removes the element with the specified value from the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to remove. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.RemoveValue("value"); 
```

<a name='M-ADN-DataStructures-BidirHashtable-Set-System-Object,System-Object-'></a>
### Set(key,val) `method`

##### Summary

Sets the value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key whose value to set. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to set. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Set("key", "foo");
var result = bidirHashtable.Get("key");
/*
result is "foo"
*/ 
```

<a name='T-ADN-DataStructures-Heap`1'></a>
## Heap\`1 `type`

##### Namespace

ADN.DataStructures

##### Summary

Array-based Heap implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Kind of thing being stored in the heap. |

<a name='M-ADN-DataStructures-Heap`1-#ctor-System-Int32,System-Boolean-'></a>
### #ctor(minSize,isMaxHeap) `constructor`

##### Summary

Create a new heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number of elements the heap is expected to hold. |
| isMaxHeap | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If "true", this is a Max Heap, where the largest values rise to the top. Otherwise, this is a Min Heap. |

<a name='M-ADN-DataStructures-Heap`1-DoCompare-System-Int32,System-Int32-'></a>
### DoCompare(initialIndex,contenderIndex) `method`

##### Summary

Perform a comparison between two elements of the heap.
This method encapsulates the min/max behavior of the heap so the rest of the class can remain blissfully ignorant.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| initialIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| contenderIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-ADN-DataStructures-Heap`1-DoubleHeap'></a>
### DoubleHeap() `method`

##### Summary

Increase the size of the underlying storage.

##### Parameters

This method has no parameters.

<a name='M-ADN-DataStructures-Heap`1-ShiftDown-System-Int32-'></a>
### ShiftDown(heapIndex) `method`

##### Summary

Move an element down the Heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| heapIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-ADN-DataStructures-Heap`1-ShiftUp-System-Int32-'></a>
### ShiftUp(heapIndex) `method`

##### Summary

Move an element up the Heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| heapIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-ADN-DataStructures-Heap`1-Swap-System-Int32,System-Int32-'></a>
### Swap(index1,index2) `method`

##### Summary

Swap two items in the underlying array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| index2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-ADN-DataStructures-TwoKeyHashtable'></a>
## TwoKeyHashtable `type`

##### Namespace

ADN.DataStructures

##### Summary

Represents a collection of 2-keys/value trios that are organized based on the hash code of the 2-keys.

<a name='M-ADN-DataStructures-TwoKeyHashtable-Add-System-Object,System-Object,System-Object-'></a>
### Add(key,key2,val) `method`

##### Summary

Adds an element with the specified keys and value into the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key of the element to add. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key of the element to add. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to add. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value"); 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Clear(); 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Contains-System-Object,System-Object-'></a>
### Contains(key,key2) `method`

##### Summary

Determines whether the TwoKeyHashtable contains the two specific key element.

##### Returns

True if contains the two specific key element, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key to locate in the TwoKeyHashtable. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key to locate in the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Contains("key", "key2");
/*
result is true
*/ 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-ContainsRow-System-Object-'></a>
### ContainsRow(key) `method`

##### Summary

Determines whether the TwoKeyHashtable contains the specific row.

##### Returns

True if contains the specific key element, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key to locate in the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.ContainsRow("key");
/*
result is true
*/ 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Count-System-Object-'></a>
### Count(key) `method`

##### Summary

Gets the number of key/value pairs contained in a dimension of the TwoKeyHashtable.

##### Returns

The number of elements contained in the TwoKeyHashtable for a specific dimension.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The dimension key of the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Count("key");
/*
result is 1
*/ 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-CountRow'></a>
### CountRow() `method`

##### Summary

Gets the number of first key trios contained in the TwoKeyHashtable.

##### Returns

The number of elements contained in the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.CountRow();
/*
result is 1
*/ 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Item-System-Object,System-Object-'></a>
### Item(key,key2) `method`

##### Summary

Gets the value associated with the specified keys.

##### Returns

The value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key whose value to get or set. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key whose value to get or set. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Item("key", "key2");
/*
result is "value"
*/ 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Keys'></a>
### Keys() `method`

##### Summary

Gets an ICollection containing the keys in the TwoKeyHashtable.

##### Returns

An ICollection containing the keys in the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Keys(); 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-Remove-System-Object,System-Object-'></a>
### Remove(key,key2) `method`

##### Summary

Removes the element with the two specified keys from the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key of the element to remove. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key of the element to remove. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.Remove("key", "key2"); 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-RemoveRow-System-Object-'></a>
### RemoveRow(key) `method`

##### Summary

Removes the row with the specified key from the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the row to remove. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.RemoveRow("key"); 
```

<a name='M-ADN-DataStructures-TwoKeyHashtable-RowKeys-System-Object-'></a>
### RowKeys(key) `method`

##### Summary

Gets an ICollection containing the keys of the specified row in the TwoKeyHashtable.

##### Returns

An ICollection containing the keys of the specified row in the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the row to gets the ICollection. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.RowKeys("key"); 
```
