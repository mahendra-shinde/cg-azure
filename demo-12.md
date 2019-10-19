## Local and Remote Git Repository Sync [Easier Approach]

Create a remote repository, add ReadMe file and then download as local repository.

1.  Login on github.com 
2.  Click on `New Repository` button (Right top corner button with '+' symbole)
3.  Repository details:
    - repository name: `myapp1`
    - Description: `my sample repository`
    - Kind: `Public`
    - CHECK Initialize with README
    - Click `Create repository` button
4. Verify your repository address
    It should be similar to
    https://github.com/mahendra-shinde/myapp1

5.  Re-configure GIT username and email

    ```
    $ git config --global user.name "{GITHUB-USERNAME}"
    $ git config --global user.email "{GITHUB-EMAIL}"
    ```
    NOTE: Please replace {GITHUB-USERNAME} with your github username (mine is mahendra-shinde)
        
          Also, replace {GITHUB-EMAIL} with EMAIL you registered on GitHub with.
            Mine is MahendraShinde@synergetics-india.com

6.  Download remote repository as LOCAL 

    ```
    $ git clone https://github.com/{GITHUB-USERNAME}/myapp1
    ```

    NOTE:   Replace {GITHUB-USERNAME} with your git account name; min is `mahendra-shinde`

7.  The previous command should create a directory with name `myapp1` 

    ```
    $ cd myapp1
    $ git status
    ```

8.  Use VS Code to add few files (any code) and use following commands to upload the changes:

    ```
    $ git add .
    $ git commit -m "added files"
    $ git push 
    ```

9.  Open your GITHUB repository in web browser to view recently added files.
