**Using Partials**
***

In certain cases, we might end up reusing snippets of HTML, such as forms, on different pages. We can also use these “partials” to break up more complex pages into smaller sections. This is another way to reduce duplication of common markup content across different files and keep our code DRY.
 ***

 **_Form.cshtml Partial Page**
 ```
 <form>
    <div class="form-group">
      <label for="exampleInputEmail1">Email address</label>
      <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
      <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>
    <div class="form-group">
      <label for="exampleInputPassword1">Password</label>
      <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
  </form>
  ```
  **Login.cshtml**
  ```
@page
@model MyApp.Namespace.LoginModel
@{
}


<div class="jumbotron">
  <h1 class="display-4">Log in!</h1>
  <p class="lead">Welcome back!</p>
  <hr class="my-4">
  <p>Provide your information below to log in</p>
	<!-- Form partial -->
  <partial name="_Form"/>
</div>
```
**Register.cshtml**
```
@page
@model MyApp.Namespace.RegisterModel
@{
}

<div class="jumbotron">
  <h1 class="display-4">Register!</h1>
  <p class="lead">Don't have an account? Registration is quick and easy!</p>
  <hr class="my-4">
  <p>Provide your information below to create an account</p>
	<!-- Form partial -->
<partial name="_Form"/>
</div>
```

