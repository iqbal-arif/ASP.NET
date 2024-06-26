**Async Redirects**
***

Before we were redirecting users, we were using void and Task as our return types.

void was for synchronous methods:
```
public void OnGet()
```
Task was for asynchronous methods:
```
public async Task OnGetAsync()
```
With redirection, we will now return IActionResult and Task<IActionResult>.

IActionResult is for synchronous methods:
```
public IActionResult OnGet()
```
Task<IActionResult> is for asynchronous methods:
```
public async Task<IActionResult> OnGetAsync()
```
We don�t need to get into the details of Task<IActionResult> now, but you can imagine it as some kind of operation that will eventually return an IActionResult.
