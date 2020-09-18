# ex_erp

Last .NET project of the _IT Academy - Barcelona Activa_.
Build an **Enterprise Resource Planner** (ERP) for a company.

Using .NET Core 3.1, EntityFramework, MySQL and Angular.

## Install NuGet packages
All the information for configuring it to run with a MySQL database (DB) can be found [here](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html).

In essence, the project needs 2 NuGet packages:
In the comand line:
```
cd ERP
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package MySql.Data.EntityFrameworkCore

// Restore dependencies and project-specific tools that are specified in the project file
dotnet restore
```


## Other info

- [Github template](https://github.com/othneildrew/Best-README-Template#contributing)
- [Basic writing and formatting syntax
](https://docs.github.com/en/github/writing-on-github/basic-writing-and-formatting-syntax)
