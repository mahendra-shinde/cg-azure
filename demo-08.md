## Cosmos DB 
1. click `Create a resource` and search for `Cosmos DB` then `Create`
2. Basic configuration
    - Select resource group `mahendra-group`
    - Enter account name: max1
    - Geo-Redundency: Disable
    - Multi-Region writes: Disable
    - Click `next`

3.  Network configuration

    - Virtual network (either select existing or create new)
    - Allow access from azure portal : Allow
    - Allow Access from my IP   :       Allow

4.  Click `Review & Create` > `Create`
5.  Create a new Console Project in Visual Studio (with C#)
6.  Project menu > Manage NuGet Packages > Search for MongoDB.Driver 
     click Install button to install the dependency.
7.  Goto `Program.cs` created by Visual studio.
8.  From azure portal goto `All Services` > `Cosmos DB` > Click on 
    `max1` > Quick Start > Copy the `C#` code into `Main` method in `Program.cs` (Visual Studio)
9.  Add following lines at the end of code
    ```cs
    List<String> dbs= 
        mongoClient.ListDatabaseNames().ToList<String>();
    foreach(String s in dbs)
        {
            Console.WriteLine("Database found! "+ s);
        }
    Console.ReadLine();
    ``
10. Run the project, you should get database named `admin`