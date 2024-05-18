**What is the Encapsulation Principle in C#?**
***

According to MSDN, Encapsulation Hides the internal state and functionality of an object and only allows access through a public set of functions. Let us simplify the above definition as follows:

The process of binding or grouping 
1. the State (i.e., Data Members) and 
1. Behaviour (i.e., Member Functions) together into a single unit (i.e., class, interface, struct, etc.) is called Encapsulation in C#.

The Encapsulation Principle ensures that the state and behavior of a unit (i.e., class, interface, struct, etc.) cannot be accessed directly from other units (i.e., class, interface, struct, etc.).


**Example to Understand Encapsulation in C#:**

Every class, interface, struct, enum, etc. that we created is an example of **encapsulation**, so let’s create a class called Bank as follows to understand the encapsulation:
```
namespace EncapsulationDemo
{
    class Bank
    {
        public long AccountNumber;
        public string Name;
        public int Balance;
        public void GetBalance()
        {
        }
        public void WithdrawAmount()
        {
        }
        public void Deposit()
        {
        }
    }
}
```
Here, the class Bank is an example of Encapsulation. The variables(AccountNumber, Name, and Balance) and methods(GetBalance, WithdrawAmount, and Deposit) of the class are bound in a single unit, which is the Bank class. Here, the encapsulation binds the implementation details of the Bank class with it and hides it from other classes. If other classes want to access these details, they need to create the object of the Bank class to access its data and behavior, as shown in the code below.
```
namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountNumber = 12345678;
            bank.Name = "Pranata";
            bank.GetBalance();
            bank.WithdrawAmount();
        }
    }
}
```
Similarly, if you create an interface, struct, or enum, that is also an example of encapsulation. The biggest advantage of Encapsulation is Data Hiding. That means, by using Encapsulation, we can achieve Data Hiding. Let us proceed further and understand Data Hiding in C# with Examples.

***Note: Data Encapsulation is also called Data Hiding because by using this principle, we can hide the internal data from outside the class***

**How can we Implement Data Hiding or Data Encapsulation in C#?**

In C#, Data Encapsulation is implemented.

   1. By declaring the variables as private (to restrict their direct access from outside the class)
   2. By defining one pair of public setter and getter methods or properties to access private variables from outside the class.

We declare variables as private to stop accessing them directly from outside the class. The public setter and getter methods or public properties are used to access the private variables from outside the class with proper validations. If we provide direct access to the variables of a class, then we cannot validate the data before storing it in the variable or while retrieving the data stored in the variable. So the point that you need to remember is by implementing Data Encapsulation or Data Hiding in C#, we are protecting or securing the data.

So, Data Encapsulation or Data Hiding in C# is implemented by using the Access Specifiers. An access specifier defines the scope and visibility of the class member, and we have already discussed the different types of Access Specifiers Supported in C# in our previous article. C# supports the following six access specifiers:

   1. public: The public members can be accessed by any other code in the same assembly or another assembly that references it.
   2. private: The private members can be accessed only by code in the same class.
   3. protected: The protected Members in C# are available within the same class as well as to the classes that are derived from that class.
   4. internal: The internal members can be accessed by any code in the same assembly but not from another assembly.
   5. protected internal: The protected internal members can be accessed by any code in the assembly in which it’s declared or from within a derived class in another assembly.
   6. private protected: The private protected members can be accessed by types derived from the class that is declared within its containing assembly.


   ***
   **Implementing Data Encapsulation or Data Hiding in C# using Properties:**

The Properties are a new language feature introduced in C#. Properties in C# help in protecting a field or variable of a class by reading and writing the values to it. The first approach, i.e., setter and getter itself, is good, but Data Encapsulation in C# can be accomplished much smoother with properties.

Let us understand how to implement Data Encapsulation or Data Hiding in C# using properties with an example. In the below example, inside the Bank class, we marked the _Amount variable as private to restrict direct access from outside the Bank class. We have exposed the Amount property to access the _Amount variable by declaring it as public. Now, from outside the Bank class, we can access the _Amount private variable through the public exposed Amount property.
```
using System;
namespace EncapsulationDemo
{
    public class Bank
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                // Validate the value before storing it in the _Amount variable
                if (value < 0)
                {
                    throw new Exception("Please Pass a Positive Value");
                }
                else
                {
                    _Amount = value;
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                //We cannot access the _Amount Variable directly
                //bank._Amount = 50; //Compile Time Error
                //Console.WriteLine(bank._Amount); //Compile Time Error
                //Setting Positive Value using public Amount Property
                bank.Amount= 10;
                //Setting the Value using public Amount Property
                Console.WriteLine(bank.Amount);
                
                //Setting Negative Value
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
```
***Output:
10
Please Pass a Positive Value***

**Advantages of Encapsulation in C#:**

   1. Data protection: You can validate the data before storing it in the variable.
   2. Achieving Data Hiding: The user will have no idea about the inner implementation of the class.
   3. Security: The encapsulation Principle helps to secure our code since it ensures that other units(classes, interfaces, etc) can not access the data directly.
   4. Flexibility: The encapsulation Principle in C# makes our code more flexible, allowing the programmer to easily change or update the code.
   5. Control: The encapsulation Principle gives more control over the data stored in the variables. For example, we can control the data by validating whether the data is good enough to store in the variable.

Encapsulation is one of the four fundamental principles of Object-Oriented Programming (OOP). It refers to the bundling of data (state) and methods (behaviors) that operate on the data into a single unit and restricting access to some of the object’s components