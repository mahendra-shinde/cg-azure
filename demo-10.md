### Develop and Deploy ASP.NET with EntityFramework application on Aure WebApps

1. Create new azure sql database on portal

    - Click `Create a resource` > search for `Azure SQL Database` > click `Create`
    - Basic Settings:
    - Select resource groupname `mahendra-group`
    - db name:  mydata1238
    - Server : click `Create new`
        - Servername:   maxunlimited1
        - Choose Admin user: mahendra
        - Password : pass@1234
        - Location: southeast asia
    - Size: Basic Size with 5GB / 1GB

2.  Once database is ready click on `Goto resource` from notification.
3.  Click on `Set server firewall` > turn ON the `Allow azure resources`
    Then click `Add client IP` and then click `Save`
4.  Copy the server url it should be like: `maxunlimited.database.windows.net`
5.  Using Visual Studio, connect to Azure SQL Database (Use Server manager)
    Server : maxunlimited.database.windows.net
    Authentication: SQL Server Authentication
    Username:   mahendra
    Password:  pass@1234
    Click `Test Connection`
    Once it shows message `Test succeeded` enter database name `mydata1238`
    Click `Connect`
6.  Create new ASP.NET Web Application project using template `MVC`
7.  Install new NuGet package `EntityFramework`
8.  Right click on project (Solution Explorer) > select ADD button > 
    then choose `Data` > `ADO.NET Entity DataModel` option
    enter name `Customer`
9.  When prompted for SQL Connection use the same properties used in step #5
10. Build the project
11. Right click on `Controllers` folder and click `Add` then `Controller` then 
    select `Controller with Views using EntityFramework`
    Model : Customer 
    Data Context : Choose the first one
    Click `Add` button
12. The above step should have generated the Controller class and few VIEWs under folder `customers`.
