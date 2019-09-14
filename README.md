# AzureDevOpsPipeline
Sastoji se od jednog WebApi ASP.NET projekta i jednog NUnit Test projekta. Imaju dva test case-a od kojih jedan je fail zbog namjernog bug-a unutar Oduzmi metode Digitron klase.

Ispod je yaml file za Pipeline na Azure DevOps
```
trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

variables:
  buildConfiguration: 'Release'

steps:
- script: dotnet build --configuration $(buildConfiguration)
  displayName: 'dotnet build $(buildConfiguration)'
- task: DotNetCoreCLI@2
  inputs:
    command: 'build'
    projects: '**/*.csproj'
- task: DotNetCoreCLI@2
  inputs:
    command: 'test'
    projects: '**/*Tests.csproj'
    
    ```
