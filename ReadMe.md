### dotnet CLI (Razor WebApps)
Use the new sub command of `dotnet` to create new webapp/razor named "Main",

    dotnet new webapp --output Main

Add a new page,

    dotnet new page --name About --namespace Main.Pages --output Pages


**Refs**  
- [MSFT - dotnet CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
- [MSFT - Get started - Create a web app project](https://learn.microsoft.com/en-us/aspnet/core/getting-started)
- [MSFT - Introduction to Razor Pages in Asp.Net Core](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)
- [MSFT - Fundamentals - Static files in Asp.Net Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files)