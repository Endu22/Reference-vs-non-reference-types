# Non-Reference Types:
Non-reference types are stored directly on the stack and are copied when saved to a new variable.

## All Primitive types: 
`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Decimal`, `bool`, `char`

Structs: `DateTime`, `TimeSpan`, `Guid`, `KeyValuePair<TKey, TValue>` and own `struct` that you create.

`Enums` are also non-reference type.

A special struct is the `Nullable<T>`. An example of this is: `int?`. This is too a non-reference type that can be `null`. Non-reference types usually can't be `null`.


# Reference types:
Refernce types are stored as pointers on the heap stack. When a variable is copied, both copies point to the same object.

## All reference types:
`object`, `string`, `Exception`, `Stream`, `Form`, `Task` and own classes.

Interfaces: `IDisposable`, `IEnumerable<T>` and own interfaces.

Delegate: `Action`, `Func<int, string>`, `Predicate<T>`

array: All arrays are reference types. For example `int[]`.

record: `record Person(string Name, int Age)`
