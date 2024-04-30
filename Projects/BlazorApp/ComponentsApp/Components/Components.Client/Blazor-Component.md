**Components**
***
1. To deal with components in server only, then create the Component in Server side of the App.

Steps:

1. Create Method in @code{} and display it in page view through button by calling the method through event handler @onclick.
2. Add @rendermode InteractiveAuto mode in Demo.razor component to assists in interactivity. This Demo will act as Server componenet first and then client (WebAssembly) component
3. Adding Demo component in Home.razor server side.
@using MyComponents.Client.Pages	a. for inserting Demo component import reference  to __import.razor server side.

4. Adding more methods and displaying with through event handler.

