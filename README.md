# Json.NET Wrapper

Wrapper helper written around Json.NET for Unity

Required plugin [Json.NET for Unity](https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347) (or a Json.NET library).

## API

To invoke the helper call:
`BlueParser.Json.METHOD`

### Methods

#### Serializing

For serializing an object into a Json there are two available methods:
- `string Serialize(IDictionary<string, object> dictionary)`
- `string Serialize(object obj)`

This only work with simple objects, as dictionaries and arrays, or objects that can be serialized.

#### Parsing

For parsing, there are two methods, one returns a `JsonDictionary`, which is a `Dictionary<string, object>` with some extra features, 
there other one returns a generic type.

- `JsonDictionary Parse(string json)`
- `T Parse<T>(string json)`

### Data Structures

#### JsonDictionary

The Json Dictionary is a class that extends `Dictionary<string, object>`. It has a custom method:
- `T Get<T>(string key)`: Returns an object casted to the desired type

#### JsonList

A class that extends `List<object>`.
- `T Get<T>(int index)`: Returns an object in the index casted to the desired type

## Write your own wrapper

The helper is a class that inherits from `IJsonParser`. It was written this way to switch it for another library with ease.

If you wish to use your own implementation, replace the class 
that is instantiated in `BlueParser.cs`.