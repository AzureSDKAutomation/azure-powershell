@{
  GUID = '1e93fc45-24ab-493d-89d7-bd91cef33b97'
  RootModule = './Az.Customproviders.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Customproviders cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Customproviders.private.dll'
  FormatsToProcess = './Az.Customproviders.format.ps1xml'
  FunctionsToExport = 'Get-AzCustomprovidersAssociation', 'Get-AzCustomprovidersCustomResourceProvider', 'New-AzCustomprovidersAssociation', 'New-AzCustomprovidersCustomResourceProvider', 'Remove-AzCustomprovidersAssociation', 'Remove-AzCustomprovidersCustomResourceProvider', 'Update-AzCustomprovidersCustomResourceProvider', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Customproviders'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
