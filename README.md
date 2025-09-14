# Non-Reference Types:
Non-reference types are stored directly on the stack and are copied when saved to a new variable.

## All Primitive types: 
`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Decimal`, `bool`, `char`

Structs: `DateTime`, `TimeSpan`, `Guid`, `KeyValuePair<TKey, TValue>` and own `struct` that you create.

`Enums` are also non-reference type.

A special struct is the `Nullable<T>`. An example of this is: `int?`. This is too a non-reference type that can be `null`. Non-reference types usually can't be `null`.


# Reference types:
Refernce types are stored on the heap and a pointer to the reference type object is stored on the stack. When a variable is copied, both copies point to the same object.

## All reference types:
`object`, `string`, `Exception`, `Stream`, `Form`, `Task` and own classes.

Interfaces: `IDisposable`, `IEnumerable<T>` and own interfaces.

Delegate: `Action`, `Func<int, string>`, `Predicate<T>`

array: All arrays are reference types. For example `int[]`.

record: `record Person(string Name, int Age)`


# Stack VS Heap
## Stack:
The stack is a quick and small memory allocation area. 
The stack is used for `local variables`, `method calls` & `return addresses` etc.
The stack is managed automatically. It's design allows a LIFO functionality (last in, first out).
Non reference types are stored directly on the stack. e.g `int x = 5` is stored on the stack.
The values stored on the stack is popped automatically when a method completes. 

Non-reference types or `Value types` as they are called is normally stored on the stack. However if they are part of an object they can be stored on the heap.

## Heap:
The heap is a slower and larger memory allocation area. This is used for objects that are created dynamically.
An example of this is `var person = new Person();`. The person object is stored on the heap but the reference to the object is stored on the stack.
The heap requires garbage collection. In `C#` this is done automatically but in languages such as `C` or `C++` the garbage collection has to be done manually.

# Threads:
Every thread in a program has its own stack. A method call is equal to one "stack frame". When a method is called an activation record is added to the stack frame. It contains the methods parameters, local variables and a return address so that the program knows where to jump to next.

