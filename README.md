# AzureDevOpsPipeline
Testiranje Azure DevOps Pipelines mogućnosti
Sastoji se od jednog WebApi ASP.NET projekta i jednog NUnit Test projekta.
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
