## Azure SQL Database (a.k.a. DBaaS)

1. Login on portal.azure.com

2. Create new resource group `mahendra-group`

3. Click on `Create a resource` button 
    > From Azure Marketplace choose `Databases`
    > Select `SQL Database`

4.  Creating new SQL Database

    - Choose resource group created in step#2 `mahendra-group`
    - Enter name for database `mydata1`
    - Server : Click on `New Server` link

        - Server name: use some unique name like xyzcv13
        - Server admin login: mahendra
        - Password: pass@1234
        - Location : Southeast asia
        - Press OK to create logical server
    - Under `Compute + Storage` (Actually a pricing plan selector)
        Click on `Configure Database` > Choose `Basic` > Choose `5 (Basic)`
        Click `Apply`

5.  Click `Next` for Networking page.

    - Connectivity method:  Public Endpoint
    - Allow Azure Services: Yes
    - Add current client ip: Yes

6.  Click `Next` for Additional settings

    -   Use Existing data:  none [Black database]
                            Backup [From old backup]
                            Sample [Use readymade sample database]
7.  Click `Review & Create` and then `Create` button.

