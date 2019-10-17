## Storage Account [Blob] demo

1. Login on portal.azure.com
2. Click `Create a Resource` > search for `Storage Account` > click `Create`
3. Creating new account
    - Select resource group `mahendra-group`
    - enter unique name for storage account `maxunlimited`
    - choose Performance : Standard
    - Account Kind:     Storage v2 (General purpose)
    - Access Tier:  Hot (High Bandwidth and low storage!) 
    - Replication:  LRS

NOTE:   > It is possible to switch between LRS to GRS and GRS to LRS 
        > However it's NOT allowed to switch ZRS to Any other replication plan or Any other plan to ZRS.
    
4.  Hit `Create` button and wait few seconds for storage account to be created!

5.  Once created, a popup message would show up in notification area. click on `Goto resource` or access your storage account from left side menu of azure portal (look for `Storage Accounts` link).

6.  Click on `Open in Explorer` button and use download link to download and install `Azure Storage Explorer`.

7.  Once downloaded, run the installer (setup) and wait for Azure Storage explorer to show-up.

8.  `Azure Storage Explorere` Should ask for Azure Account just click `Next` and enter your azure account credentials (username and password) then click `Login`

9.  Now, Azure storage explore should list all `storage accounts` under your subscription. double click on storage account `maxunlimited` (replace with your storage account name)

10. Right click on `Blob containers` inside your storage account and choose `Create blob container`, enter name `myfiles`

11. Hit `upload` button and upload few files (images or documents).

12. Select any one of uploaded file, and use button `copy url` to get Absolute url to the uploaded file.

13. Paste copied url in new browser window. you should `Resource Not found` error.

14. To Allow public access, right click on container name `myfiles` and choose option `Set public access` then choose option `Public access to blobs only`.

15. Try accessing url from web browser, now instead of `ResourceNotFound` error, browser should display or download the file.
