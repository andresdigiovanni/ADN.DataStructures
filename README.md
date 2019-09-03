# Data Structures Library for .NET

ADN.DataStructures is a cross-platform open-source library which provides data structures utilities to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.DataStructures.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.DataStructures)
[![NuGet](https://img.shields.io/nuget/v/ADN.DataStructures.svg)](https://www.nuget.org/packages/ADN.DataStructures/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.DataStructures?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.DataStructures&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.DataStructures)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.DataStructures&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.DataStructures)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Example Max-Heap structure:

```csharp
var heap = new MaxHeap<int>(1);

for (int i = 0; i <= 1000; i++)
{
    heap.Insert(i);
}

var value = heap.Peek(); // 1000
heap.Remove();
value = heap.Peek(); // 999
```

## Installation

ADN.DataStructures runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.DataStructures NuGet package from the NuGet package manager:

```
Install-Package ADN.DataStructures
```

Or alternatively you can add the ADN.DataStructures package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.DataStructures/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.DataStructures is licensed under the [MIT license](LICENSE).
