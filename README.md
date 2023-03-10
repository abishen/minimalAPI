# Minimal API
***
* [Mininal API](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-7.0)

***
## Installation Guide
* [Install Dotnet 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
Issue with Security Patch
* [Install Visual Studio](https://visualstudio.microsoft.com/)
**
## Chocolately
### Install Chocolately CLI
```
>   Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))

```
### Install the .Net 7
```
choco install dotnet-7.0-sdk -y
```
### Install Visual Studio
```
choco install visualstudio2022enterprise -y
```
### Install Visual Studio Code
```
choco install vscode -y
```