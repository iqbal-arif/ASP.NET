**URLs in Razor Pages**
***
In a default Razor Pages application, each view page’s URL route is its path minus .cshtml.

For example, given the folder structure:
```
Pages
|-- About.cshtml
|-- About.cshtml.cs
|-- Index.cshtml
|-- Index.cshtml.cs
|-- Businesses/
   |-- Codecademy.cshtml
   |-- Codecademy.cshtml.cs
```

   About.cshtml is available at
   ```
   https://localhost:8000/About
   ```

   Codecademy.cshtml is available at
   ```
   https://localhost:8000/Businesses/Codecademy
   ```
   Index.cshtml is available at 
   ```
   https://localhost:8000/Index OR https://localhost:8000
   ```

