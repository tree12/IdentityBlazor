# Project Title

Vesho project==> Example name of this project. You can change the name of project that you want.
### Getting Start
* I want to show this project, how to use Identity principal with .Net core Blazor.
* The project consist with 2 part
1. VeshoCore - Blazor project it's contain Blazor assembly, server and shared. (If you have knowlege of Blazor assembly It easy for you to understand.)
2. VeshoCore.Entities - This project use for database manipulation(such as migration). It use Entity Framework.
 
### Tool
  1. Visual Studio 2022 with .net 7
  2. SQLServer 2019 (From my example I use localDB)
  
### Installing

1. Create Database name as you want in "appsettings.json" file inside VeshoCore.Server project. (In my example I use VeshoCore to be database name.). Change the connectionString to match with your server.
 ```
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=VeshoCore;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
```
2. Open Package Manager Console in Visual Studio, and then run Migration command as
```
update-database -s VeshoCore.Server
```
4. Run VeshoCore.Server project wtih visual studio 2022. After that click register link. And then enjoy!


