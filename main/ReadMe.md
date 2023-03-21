**TODO**  
What we haven't done yet?
- linking fav icons and recreating fav icons
- whether to use wwwroot to store fav icons etc
- on a related note, linking static images


Add a new razor image,

    dotnet new page --name About --namespace Main.Pages --output Pages


**Settings/Conf**  
'appsettings.json',
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

'appsettings.Development.json',
```json
{
  "DetailedErrors": true,
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

**Refs**  
- asp net core [.gitignore](https://github.com/dotnet/core/blob/main/.gitignore)
