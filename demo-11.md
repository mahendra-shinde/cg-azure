## Using GIT

1. Install GIT from git-scm.com/downloads/win
2. One time configaration:

    ```
    $ git config --global user.name "Mona Lisa"
    $ git config --global user.email "MonaLisa@da-vinci.com"
    ```

    NOTE: $ represents command prompt, dont use it!

3.  Create a file using VSCode

    ```
    ## Start VS Code in current directory
    $ code . 
    ## Create a file with name index.html
    ## Back to command prompt, enter following command 
    $ git status
    ## Git should report UNTRACKED FILE index.html, start tracking this file
    $ git add index.html
    $ git status
    ## Commit and Save the changes to repository
    $ git commit -m "First Commit"
    ```