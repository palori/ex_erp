# ex_erp

Last .NET project of the _IT Academy - Barcelona Activa_.
Build an **Enterprise Resource Planner** (ERP) for a company.

Using .NET Core 3.1, EntityFramework, MySQL and Angular.

## Install NuGet packages
All the information for configuring it to run with a MySQL database (DB) can be found [here](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html).

In essence, the project need the following NuGet packages:
In the comand line:
```
cd erp-api
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package MySql.Data.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

// If adding authentication
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

// Restore dependencies and project-specific tools that are specified in the project file
dotnet restore
```

## Angular
### Install Bootstrap
...

### Install Charts.js
https://medium.com/codingthesmartway-com-blog/angular-chart-js-with-ng2-charts-e21c8262777f

## Other info

- [Github template](https://github.com/othneildrew/Best-README-Template#contributing)
- [Basic writing and formatting syntax
](https://docs.github.com/en/github/writing-on-github/basic-writing-and-formatting-syntax)


## Models information!
`ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
