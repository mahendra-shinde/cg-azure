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
12. Once VM is deployed, use `Connect` button and then `Download RDP file` to download a .rdp file. Open this downloaded file is would prompt you to enter username and password.
13. Make sure you select `Other User` and enter username and password you provided at the time of VM creation.
14. Accept all prompt and enter inside VM Desktop
15. A `Server Manager` would start in few seconds, use button `1 Add server role and feature` to install IIS server.
16. Press NEXT three times and then from list of features Choose `Web Server (IIS)` and click `Add features`.
17. Click Next -> Next -> Install and wait for installation to complete.
18. Once installed, you should be able to access your default IIS webpage using Public IP of your VM
    
    Just type `http://{IP}`  to access it from your local machine
    
    Please replace `{IP}` with public ip of your VM.



### What happends when VM is STOPPED (Deallocated)
1. All services inside VM are stopped (eg IIS)
2. Guest OS (Windows Server 2019) would be SHUTDOWN
3. vCPU, RAM & Dynamic Public IP would be released.
4. Your OS Disk (C Drive) is NOT released! (You pay for Disk even when VM is deallocated! )

### Pre-caution
- Never shutdown Guest OS from inside RDP Session, it will shutdown OS but not release vCPU, RAM and IP.
