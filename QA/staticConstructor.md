**Static Constructor in C#**
***https://dotnettutorials.net/lesson/types-of-constructors-in-csharp/***
***

Points to Remember while working with Static Constructors in C#:
Point1:

If a class contains any static variables, then only implicit static constructors come into the picture otherwise we must be defined them explicitly. On the other hand, non-static constructors will be implicitly defined in every class (except the static class) provided we didn’t define any constructor explicitly.

Point2:

Static Constructors are responsible for initializing static variables and these constructors are never called explicitly. They are called Implicitly and moreover, these constructors are the first to execute in any class. For a better understanding, please have a look at the below example. Here, we have defined one static constructor, and please observe from the Main method we are not calling the Static constructor.
```
using System;
namespace ConstructorDemo
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
            Console.ReadKey();
        }
    }
}
```
Now, when you execute the above code, the Static constructor will execute first and then the main method. And this proves the following output.

```
Static Constructor Executed!
Main Method Exceution Started...
```


The non-static constructors are never called implicitly, they are always called explicitly whereas the static constructor never called explicitly, they are always going to be called implicitly. How does the execution happen? See, the Main method is the starting point of execution, and in this case no difference. The program execution will start from the Main method but before executing any statement inside the Main method, it will first execute the Static constructor and once the Static Constructor execution is completed, then it will continue the execution of the Main method. So, the static constructor is the first block of code in a class to be executed.

Point3:

Static Constructors cannot be parameterized, so overloading of the static constructors is not possible in C#. Now, the question is why we cannot parameterize the static constructor? The answer is simple. The static constructors are executed implicitly and hence we never get a chance to pass a value. And as the static constrictor is the first block to be executed in a class, and hence there is no chance to pass a value.

Points To Remember About Static Constructor in C#:

  1.  There can be only one static constructor in a class.
  2.  It can’t be called explicitly, it is always called implicitly.
  3.  The static constructor should be without any parameters.
  4.  It can only access the static members of the class.
  5.  There should not be any access specifiers in the static constructor definition.
  6.  If a class is static then we cannot create the object for the static class.
  7.  It is called automatically to initialize the static members.
  8.  Static constructor will be invoked only once i.e. at the time of class loading.

  ****

  **Static Constructor Real-time Example in C#**
  ***https://dotnettutorials.net/lesson/why-do-we-need-constructors-in-csharp/***
1. The static Constructor in C# will be invoked only once. There is no matter how many instances (objects) of the class are created, it is going to be invoked only once and that is when the class is loaded for the first time.

2. The static constructor is used to initialize the static fields of the class. You can also write some code inside the static constructor which is going to be executed only once. The static data members in C# are created only once even though we created any number of objects.
```
using System;
namespace StaticConstructorDemo
{
    class Example
    {
        int i;
        static int j;
        //Default Constructor
        public Example()
        {
            Console.WriteLine("Default Constructor Executed");
            i = 100;
        }
        //static Constructor
        static Example()
        {
            Console.WriteLine("Static Constructor Executed");
            j = 100;
        }
        public void Increment()
        {
            i++;
            j++;
        }
        public void Display()
        {
            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of j : " + j);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.Increment();
            e1.Display();
            e1.Increment();
            e1.Display();
            Example e2 = new Example();
            e2.Increment();
            e2.Display();
            e2.Increment();
            e2.Display();
            Console.ReadKey();
        }
    }
}
```
Output:
Static Constructor Executed
Default Constructor Executed
Value of i : 101
Value of j : 101
Value of i : 102
Value of j : 102
Default Constructor Executed
Value of i : 101
Value of j : 103
Value of i : 102
Value of j : 104

