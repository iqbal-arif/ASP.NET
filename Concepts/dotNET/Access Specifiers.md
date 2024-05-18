**What are Access Specifiers in C#?**
***https://dotnettutorials.net/lesson/access-specifiers-csharp/***
***
Every keyword that we use such as private, public, protected, virtual, sealed, partial, abstract, static, base, etc. is called Modifiers. Access Specifiers are special kinds of modifiers using which we can define the scope of a type and its members.

So, in simple words, we can say that the Access Specifiers are used to define
1. the scope of the type (Class, Interface, Structs, Delegate, Enum, etc.) as well as 
1. the scope of their members (Variables, Properties, Constructors, and Methods). 

***Scope** means accessibility or visibility that is who can access them and who cannot access them are defined by the Access Specifiers.

See, I have a class with a set of members, who can consume these members, and who cannot consume these members are defined by the access specifiers.

***Different Types of Access Specifiers in C#:**

C# supports 6 types of access specifiers. They are as follows

   1. Private
   2. Public
   3. Protected
   4. Internal
   5. Protected Internal
   6. Private Protected (C# Version 7.2 onwards)

   ***Understand Type and Type Members in C#:**

Before understanding Access Specifier, let us first understand what are Types and Type Members in C#. Please have a look at the below diagram. Here, Example (which is created by using the class keyword) is a Type, and Variable ID, Property Name, Constructor Example, and Method Display are type members. See pic AccessSpecifiers.GIF

So, in general 
***classes, structs, enums, interfaces, and delegates are called types***, and
***variables, properties, constructors, methods, etc. that normally reside within a type are called type members.***

* The type members can have all 6 access specifiers

* whereas types can have only 2 (internal, public) Access Modifiers.

Default Type : Internal access
Default Type Memmbers : Private acess

By default, if we have not specified any type, then for type is going to be internal access specifier and for type members, it is going to be a private Access Specifier. With this keep mind, let us proceed and understand all 6 Access Specifiers in C# with Examples