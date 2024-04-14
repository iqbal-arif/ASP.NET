**What is ASP.NET Razor Pages?**
***
***Discover how the C# language and the ASP.NET framework are used to build websites and web apps***

According to Microsoft, the makers of the software, ASP.NET is: “an open source web framework…for building modern web apps and services with .NET.”

If you’re not familiar with .NET, then start with this article on the .NET platform. In short, .NET is the engine that lets you build programs with C# (and a few other languages).

So, ASP.NET is something that goes on top of .NET to build a specific type of program: web apps and services. “Web apps” and “web services” are involved in nearly everything that you encounter on the internet. Web sites, e-mail, downloading an app on your phone, anything that deals with HTTP requests and responses — those all use some kind of web app or web service. This article focuses on using ASP.NET to build websites, which we’ll also call web apps (there’s a difference, but we won’t get into it now).

Let’s say we want to build a web app of our own. We can choose nearly any programming language, but let’s say we pick C#. If we build a program with C#, we’ll probably use the .NET platform. Since our program is a web app, we’ll use ASP.NET!

If you’d like more details, here are some of the tools included in ASP.NET:

   1. A base framework for processing web requests in C# or F#
   2. A front-end syntax, known as Razor, for building dynamic web pages using C#
   3. Libraries for common web patterns, such as ***Model View Controller (MVC)*** (https://www.codecademy.com/article/mvc)
   4. Authentication system that includes libraries, a database, and template pages for handling logins
   5. Editor extensions to provide syntax highlighting, code completion, and other functionality specifically for developing web pages

Using ASP.NET, you can build web apps in a number of different ways — the same way a “flying machine” can be built as a jet plane or a helicopter, or a “floor-cleaning machine” can be built as a broom or a vacuum. We call these different ways architectures or patterns. We’ll focus on one: the Razor Pages architecture.

The ***Razor Pages architecture*** goes like this: Every page of our website is represented by two files:

  1.  A view page, that displays information, and
  2.  A page model, which handles the accessing and processing of information.

For example, say that you have a bakery website that handles online orders. When users visit the site, they see a page containing a menu and a form to input an order. The way that the ***menu and form are displayed*** is defined in the ***view page***. How the ***menu is accessed and how the order is handled*** are defined in the corresponding ***page model***.

Razor Pages can also be used to make things other than web pages, like APIs and microservices. (Remember when Microsoft said ASP.NET is good for web apps AND services?) In those cases we wouldn’t need a view page, we’d just use page models.

Let’s recap:

   1. To build programs with C#, you need the .NET platform
   2. To build programs like web apps and web services, you need the ASP.NET framework
   3. ASP.NET provides a number of ways to build web apps/services. We focused on one called Razor Pages, which uses a page-focused (View Page + Page Model) pattern.

Now you know the tools; it’s time to get building!
