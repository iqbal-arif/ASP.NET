1. App.razor: Single Page HTML in 
a. Blazor Server and 
b. Blazor Web Assembly

2. For SSR App: App.razor acts as HTML Template for multiple HTML docs

3. app.css: Site-wide CSS

4. SSRDemo.styles.css: Component-centric CSS

5.<HeadOutlet/ in App.razor : Direct/Renders Per page Title, Image for multi-page App.,e.g.,
	a. For Home page:it renders <PageTitle>Home</PageTitle>
	b. For Weather page: it renders <PageTitle>Weather</PageTitle>

6.<Routes/ in App.razor: Injects entire App pages and Components are injected through it in line 16 of App.razor.

7.blazoer.web.js : script for blazor framework that helps in streaming, such as, StreamRendering.

8.Routes.razor : looks for routes in Program.cs, gather RouteData, and pass it to DefaultLayout MainLayout and Focus on h1 element of navigate.

9.MainLayout.razor: The App Global page is defined here mostly. For site Global looks

10.@Body in MainLayot.razor : Injects individual pages, such as Body and Weather pages, etc.

11.wwwroot :All static framework and custom css files are located. Custom images will go here as well. Just create "img" folder under wwwroot
