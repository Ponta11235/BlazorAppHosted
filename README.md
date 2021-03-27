# Create Develop Environment on Remote Container
```
mkdir BlazorAppHosted
cd BlazorAppHosted/
code .
```
- Remote-Containers: Add Development Container Configuration Files... 
 -> C# -> .NET 5.0

- Setting devcontainer.json
 Comment Toggle "forwardPorts"
 Add "extensions"

- Remote-Containers: Reopen in Container

# Create Blazor WebAssembly Hosted Project
```
dotnet new blazorwasm --hosted --output LibraryManagement
```

# Run
```
cd LibraryManagement
dotnet publish
cd Server
dotnet run
```

- Open "http://localhost:5000" in Browser

# Install Nuget Package
```
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```
