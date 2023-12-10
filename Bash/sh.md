Reference: deploy.sh in ARM template

1. Function in bash script: https://ryanstutorials.net/bash-scripting-tutorial/bash-functions.php 

2. $@ in bash script: All the arguments supplied to the Bash script
3. #?: the variable $? contains the return status of the previously run command or function
Reference: https://ryanstutorials.net/bash-scripting-tutorial/bash-variables.php#others

4. #(): command substitution
Reference: https://ryanstutorials.net/bash-scripting-tutorial/bash-variables.php#commandsubstitution

5. <<<: Here string 
Reference: https://askubuntu.com/questions/678915/whats-the-difference-between-and-in-bash

6. >&2: file descriptor for stderr, in short, it redirect to file descriptor stderr
Reference: https://www.brianstorti.com/understanding-shell-script-idiom-redirect/

7. jq linux package: 
Reference: https://jqlang.github.io/jq/

8. sed command:
+ 's' substitution means replacement
Ex: ```$sed 's/unix/linux/' geekfile.txt```
Here the “s” specifies the substitution operation. The “/” are delimiters. The “unix” is the search pattern and the “linux” is the replacement string.

+ '/g' in substitution pattern: Replacing from nth occurrence to all occurrences in a line. '/g' means replace all

+ '-e' option in sed: In the sed command, the -e option is used to specify a script or set of editing commands that will be applied to the input text. It allows you to provide multiple editing commands within a single sed invocation. The -e option is followed by the editing command or script enclosed in single quotes. (from chatGPT)
Ex: ```sed -e 's/apple/orange/g' -e '/banana/d' input.txt```

+ '-i': The -i option in the sed command is used to perform in-place editing of files. When you use the -i option followed by an optional backup extension (e.g., -i.bak), sed will edit the specified file directly and save the changes back to the same file. If you provide a backup extension, a backup of the original file will be created with that extension before the changes are made.(from chatGPT)

+ combine '-e' and '-i'
Ex: 
```shell
$ sed -e "s/\$TENANT_ID/$TENANT_ID/g" \
$ -e "s/\$SECRETS_IDENTITY_ID/$SECRETS_IDENTITY_ID/g" \
$ -e "s/\$KEYVAULT_NAME/$KEYVAULT_NAME/g" \
$ -i collector-secrets.yaml
```