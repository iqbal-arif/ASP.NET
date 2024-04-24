**Add Constrained Route Templates**
****

Like everywhere else in C#, strict type constraints help us avoid errors. Imagine if someone sent a POST request to this URL:

```localhost:8000/veggies/YES/fruits/NO/grains/IDUNNO/protein/SORTA/dairy/NEVER```

It would break our application, which expects integers for each of those route values. Within our @page directive we can specify that constraint like the below, where int stands for “integer” (we’ll show an abbreviated version here):
```
@page "/veggies/{veggies:int}..."
```
The general format is:
```
@page "{routevalue:constraint}"
```
If you want the route value to remain optional, use the question mark after the constraint, like:
```
@page "/veggies/{veggies:int?}..."
```
There are a lot of constraints out there, but here are a few to get started:

   1. int — value must be any integer
   2. alpha — value must consist of one or more alphabetical characters (a-z, case-insensitive)
  3.  bool — value must be true or false (case-insensitive)

A longer (but not exhaustive) list of constraints : ***https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-8.0#route-constraint-reference*** is available in the Microsoft documentation.
