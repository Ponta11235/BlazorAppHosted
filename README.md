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
cd Server
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
# Install Tool for Migration
```
cd LibraryManagement
dotnet new tool-manifest
dotnet tool install dotnet-ef
```

# Migration
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

# SetUp Initial Data
```
INSERT INTO BOOKS VALUES(1,"はじめてのBlazor WebAssembly","山田　太郎",1980,1);
INSERT INTO BOOKS VALUES(2,"動かして覚えるEntityFramework","山田　次郎",1560,1);
INSERT INTO BOOKS VALUES(3,"Perfect WebForms","山田　太郎",3680,0);
```
