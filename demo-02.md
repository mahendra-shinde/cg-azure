## Azure Virtual Machine (Windows OS)

Virtual Machine with choice of OS, vCPU & RAM.

Steps:
1. Login on portal.azure.com
2. Click "Create a resource" -> Search for "Windows Server" 
    Choose `[smalldisk] Windows Server 2019 Datacenter`

3. Choose resource group `{yourName}-group` created in previous demo `demo-01`
4. Enter Unique name for vm (Follow variable naming convention).
5. Size selected is `Standard DS1 v2` 
6. Enter username & password of your choice (Please note down them for future use!)
7. Public Inbound ports : choose TWO Http & RDP
8. Click NEXT button
9. In Disk type choose `Standard HDD` to reduce the cost of VM.
10. Click `Next` for Networking then keep hitting Next untill you get last summary page.
11. Click `Create` on last page, and wait for VM to be deployed and started    