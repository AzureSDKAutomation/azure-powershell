@{
  GUID = '8ee81edf-a8f3-442e-9b88-402b661ca1bb'
  RootModule = './Az.SourceControlConfiguration.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: SourceControlConfiguration cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.SourceControlConfiguration.private.dll'
  FormatsToProcess = './Az.SourceControlConfiguration.format.ps1xml'
  FunctionsToExport = 'Get-AzSourceControlConfigurationSourceControlConfiguration', 'New-AzSourceControlConfigurationSourceControlConfiguration', 'Remove-AzSourceControlConfigurationSourceControlConfiguration', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'SourceControlConfiguration'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
