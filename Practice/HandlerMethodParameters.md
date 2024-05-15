**Handler Method Parameters**
```
// Example GET request
// https://localhost:8000/Songs?id=1
public async Task OnGetAsync(int id)
{ 
  // id is 1
}

// Example POST request
// https://localhost:8000/Songs?songName=Say%20It%20Loud
public async Task OnPostAsync(string songName)
{  
  // songName is "Say It Loud"
}
```
Page model handler methods, like OnGet(), OnGetAsync(), OnPost(), and OnPostAsync(), can access an incoming HTTP request’s query string via its own method parameters.

The name of the method parameter(s) must match (case-insensitive) the name(s) in the query string.
