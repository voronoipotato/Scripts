# Scripts
## This is for developers. If someone told you to do this so you can run their script, don't do it. 

To get your F# scripts to run in powershell first set the default program (fsi.exe). Mine was found here. In Windows 10 I right clicked a fsx and clicked open with, and found my fsi.exe and made it default. 

powershell scripts may need to be [signed](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_signing?view=powershell-6) you can also adjust [set-executionpolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.security/set-executionpolicy?view=powershell-6) however that is less recommended

```
C:\ProgramFiles (x86)\Microsoft Visual Studio\2019\Preview\Common7\IDE\CommonExtensions\Microsoft\FSharp\fsi.exe
``` 
Now add your current folder (this scripts directory) to the path and fsx to your pathext. This allows you to execute fsx as programs and have these scripts available to you as commands. You may need to be administrator to do this. 

``` powershell
# $env:path += ";." # current working directory
$env:PATHEXT += ";.fsx" 
```