# Introduction

This is a template that was created from **ASP.NET Core MVC / Angular** based startup projects for [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents). It has 2 different versions:

1. [ASP.NET Core MVC & jQuery](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core) (server rendered multi-page application).
2. [ASP.NET Core & Angular](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular) (single page application).
 
User Interface is based on [BSB Admin theme](https://github.com/gurayyarar/AdminBSBMaterialDesign).

# Migrations with Azure Connection String
To use migrations with dotnet cli using azure it is necessary to remove "Encryp = True;"

By example:

{ 

  "ConnectionStrings": { 

    "Default": "Server=edupocs.database.windows.net,1433;Initial Catalog=Demos2018;Persist Security Info=False;User ID=xxxxx;Password=XXXXX;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;" 

  

  } 

} 

From VS 2017 in debug Mode you could run net core app:

Test the following URL:

http://localhost:21021/swagger/


From console using dotnet ef database update:

dotnet ef database update -c ASPNetCoreAngularAppDbContext

Start the project ASPNetCoreAngularApp.Web.Host

Run with dotnet CLI in http://localhost:5000/ using the console:

ASPNetCoreAngularApp\src> dotnet run -p .\ASPNetCoreAngularApp.Web.Host\


I will be updating the postman file: ASP.NET Core Angular App.postman_collection.

By example to get a token with Postman

http://localhost:21021/api/TokenAuth/Authenticate

Body

{
"userNameOrEmailAddress": "admin",
"password": "123qwe"
}

Before starting angular, it is necessary to install the following:

NodeJs y NPM
http://blog.teamtreehouse.com/install-node-js-npm-windows

Yarn
https://yarnpkg.com/lang/en/docs/install/

From console download and install:

npm install yarn



ASPNetCoreAngularApp\src> npm install

ASPNetCoreAngularApp\src> npm start

Run Angular part http://localhost:4200/ using the console:


ASPNetCoreAngularApp\src> npm run hmr


# Reference

Startup Template Angular

https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular


# Download

Create & download your project from https://aspnetboilerplate.com/Templates

# Documentation

* [ASP.NET Core MVC & jQuery version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core)
* [ASP.NET Core & Angular  version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular)

# License

[MIT](LICENSE).