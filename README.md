# Generics

####Generics allow the reuse of code across different types.
For example, let's declare a method that swaps the values of its two parameters:
```C#
static void Swap(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}
```
####Our Swap method will work only for integer parameters. If we want to use it for other types, for example, doubles or strings, we have to overload it for all the types we want to use it with. Besides a lot of code repetition, it becomes harder to manage the code because changes in one method mean changes to all of the overloaded methods.
Generics provide a flexible mechanism to define a generic type.
```C#
static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}
```
####In the code above, T is the name of our generic type. We can name it anything we want, but T is a commonly used name. Our Swap method now takes two parameters of type T. We also use the T type for our temp variable that is used to swap the values.
Note the brackets in the syntax` <T>`, which are used to define a generic type.

###Generic Methods

####Now, we can use our Swap method with different types, as in:
```C#
static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}
static void Main(string[] args) {
  int a = 4, b = 9;
  Swap<int>(ref a, ref b);
  //Now b is 4, a is 9

  string x = "Hello";
  string y = "World";
  Swap<string>(ref x, ref y);
  //Now x is "World", y is "Hello"
}
```

####When calling a generic method, we need to specify the type it will work with by using brackets. So, when Swap<int> is called, the T type is replaced by int. For Swap ` <string> `, T is replaced by string. 
If you omit specifying the type when calling a generic method, the compiler will use the type based on the arguments passed to the method.
Multiple generic parameters can be used with a single method. 
For example: Func `<T, U>` takes two different generic types.

###Generic Classes

####Generic types can also be used with classes.
The most common use for generic classes is with collections of items, where operations such as adding and removing items from the collection are performed in basically the same way regardless of the type of data being stored. One type of collection is called a stack. Items are "pushed", or added to the collection, and "popped", or removed from the collection. A stack is sometimes called a Last In First Out (LIFO) data structure.
For example:
```C#
class Stack<T> {
  int index=0;
  T[] innerArray = new T[100];
  public void Push(T item) {
    innerArray[index++] = item; 
  }
  public T Pop() {
    return innerArray[--index]; 
  }
  public T Get(int k) { return innerArray[k]; }
}
```
####The generic class stores elements in an array. As you can see, the generic type T is used as the type of the array, the parameter type for the Push method, and the return type for the Pop and Get methods.
Now we can create objects of our generic class:
```C#
Stack<int> intStack = new Stack<int>();
Stack<string> strStack = new Stack<string>();
Stack<Person> PersonStack = new Stack<Person>();
```
####We can also use the generic class with custom types, such as the custom defined Person type.
In a generic class we do not need to define the generic type for its methods, because the generic type is already defined on the class level.

Generic class methods are called the same as for any other object:
```C#
Stack<int> intStack = new Stack<int>();
intStack.Push(3);
intStack.Push(6);
intStack.Push(7);
            
Console.WriteLine(intStack.Get(1));
//Outputs 6
```

###Collections

####The .NET Framework provides a number of generic collection classes, useful for storing and manipulating data.
These classes are contained in the<b> System.Collections.Generic</b> namespace.
List is one of the commonly used collection classes:
```c#
List<string> colors = new List<string>();
colors.Add("Red");
colors.Add("Green");
colors.Add("Pink");
colors.Add("Blue");

foreach (var color in colors) {
  Console.WriteLine(color);
}
/*Outputs
Red
Green
Pink
Blue
*/
```
####We defined a List that stores strings and iterated through it using a foreach loop. 
The List class contains a number of useful methods:
Add adds an element to the List.
Clear removes all elements from the List.
Contains determines whether the specified element is contained in the List.
Count returns the number of elements in the List.
Insert adds an element at the specified index.
Reverse reverses the order of the elements in the List.
So why use Lists instead of arrays?
Because, unlike arrays, the group of objects you work with in a collection can grow and shrink dynamically.


Commonly used generic collection types include:
<ul>
<li>Dictionary`<TKey, TValue> represents a collection of key/value pairs that are organized based on the key.
<li>List<T> represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.
<li>Queue<T> represents a first in, first out (FIFO) collection of objects.
<li>Stack<T> represents a last in, first out (LIFO) collection of objects.
</ul>
Choose the type of collection class based on the data you need to store and the operations you need.
```C#
List<int> a = new List<int>();
a.Add(5);
a.Add(2);
a.Add(8);
a.Reverse();
Console.Write(a[1]);
```
