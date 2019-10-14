## Azure Virtual Machine (Ubuntu Linux OS)

Virtual Machine with choice of OS, vCPU & RAM.

Steps:
1. Login on portal.azure.com
2. Click `Create a resource` -> Search for `Ubuntu Server`
    Choose `Ubuntu Server 18.04 LTS`

3. Choose resource group `{yourName}-group` created in previous demo `demo-01`
4. Enter Unique name for vm (Follow variable naming convention).
5. Size selected is `Standard DS1 v2` 
6. Enter username & password of your choice (Please note down them for future use!)
7. Public Inbound ports : choose TWO HTTP & SSH
8. Click NEXT button
9. In Disk type choose `Standard HDD` to reduce the cost of VM.
10. Click `Next` for Networking then keep hitting Next until you get last summary page.
11. Click `Create` on last page, and wait for VM to be deployed and started    
12. Once VM is created click on "Goto Resource" from notification message.
13. Copy `Public IP Address` of your VM from Overview panel.
14. Start "PuTTY" and paste Public IP in "Host Name" field and click "Open"
15. When prompted for Username and password enter VM User and password
    > Linux do not use "*" or any other character for password
      Just enter password and press ENTER

16. Install Updates to existing package repositories (Recommanded but not necessary)

    $ sudo apt update -y

17. Install nginx (pronounced as Ngine-X) 

    $ sudo apt install nginx -y

18. Try Accessing default nginx web page using Public IP of your VM

    eg. my vm ip is 13.67.105.93, so i would try http://13.67.105.93 in my browser

19. Edit the default html page

    ```sh
    $ cd /var/www/html
    $ sudo nano index.nginx-debian.html
    ```

10. Goto line where "Welcome to nginx" is written, change it to any text of your choice
    Then save and close using shortcut `CTRL+X` and `Y` followed by `ENTER`

### What happends when VM is STOPPED (Deallocated)
1. All services inside VM are stopped (eg IIS)
2. Guest OS (Ubuntu Server 18.04 LTS) would be SHUTDOWN
3. vCPU, RAM & Dynamic Public IP would be released.
4. Your OS Disk (ROOT Filesystem) is NOT released! (You pay for Disk even when VM is deallocated! )

### Pre-caution
- Never shutdown Guest OS from inside SSH Session, it will shutdown OS but not release vCPU, RAM and IP.
- The command to shutdown linux is 
    `sudo poweroff` Dont use on Azure VM.
- The command to restart linux is
    `sudo restart`.