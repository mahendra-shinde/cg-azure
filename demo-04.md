## Password-less authentication with SSH Key Pair

1. Generate SSH Key pair

    - Using `ssh-keygen` command on BASH, Git Bash terminals
    - Using PuTTY KeyGen

2. Generate SSH-Key Pair using PuTTY

    - Start Menu -> PuTTYGen
    - Generate Button, Keep moving mouse over the empty area within PuTTYGen
    - Click "Save public key" button and save it inside Desktop/ssh-keypair folder with name key.pub
    - Click "Save private key" button, then press YES and then save it in same folder 
        Desktop/ssh-keypair with name "key"

3.  Create Azure Virtual Network 

    - Click `Create a Resource` > Search `Virtual Network` > Click `Create`
    - Virtual network name: `VNet1`
    - Resource group : click on `create new` > enter name `{your-name}-group` > OK
    - Verify the IP Address range : 10.1.0.0/16
    - Press `Create`

4.  Create First VM using following steps

    - Click `Create a Resource` > Search for `Ubuntu Server` > select `Ubuntu Server 18.04 LTS` > Create
    - Resource group : {your-name}-group
    - VM Name: FirstVM
    - Username: {your-name}
    - Authentication : SSH Public Key
    - Open the file `Desktop/ssh-keypair/key.pub` in VSCode, copy entire content of file
    - Paste inside `SSH Public key` textfield on azure portal.
    - Open Inbound port : Choose SSH(22) port
    - Click `Next`
    - Choose Disk type `Standard HDD` and click `Next`
    - Choose Virtual Network `VNet` click Next
    - Click `Review+Create` > Click `Create`

5.  Create Second VM using same steps from FirstVM (dont forget to use VM Name `secondvm`).
