@{
  GUID = '644bc088-513e-4602-a3a0-4bdb3480f1e0'
  RootModule = './Az.DigitalTwins.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DigitalTwins cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DigitalTwins.private.dll'
  FormatsToProcess = './Az.DigitalTwins.format.ps1xml'
  FunctionsToExport = 'Get-AzDigitalTwinsDigitalTwin', 'Get-AzDigitalTwinsEndpoint', 'Get-AzDigitalTwinsPrivateEndpointConnection', 'Get-AzDigitalTwinsPrivateLinkResource', 'New-AzDigitalTwinsDigitalTwin', 'New-AzDigitalTwinsDigitalTwinEndpoint', 'New-AzDigitalTwinsPrivateEndpointConnection', 'Remove-AzDigitalTwinsDigitalTwin', 'Remove-AzDigitalTwinsEndpoint', 'Remove-AzDigitalTwinsPrivateEndpointConnection', 'Test-AzDigitalTwinsDigitalTwinNameAvailability', 'Update-AzDigitalTwinsDigitalTwin', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DigitalTwins'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
