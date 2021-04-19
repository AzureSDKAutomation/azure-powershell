@{
  GUID = '76325d54-67c7-4a93-a78c-26bcd899fe93'
  RootModule = './Az.StorageImportExport.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: StorageImportExport cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.StorageImportExport.private.dll'
  FormatsToProcess = './Az.StorageImportExport.format.ps1xml'
  FunctionsToExport = 'Get-AzStorageImportExportBitLockerKey', 'Get-AzStorageImportExportJob', 'Get-AzStorageImportExportLocation', 'New-AzStorageImportExportJob', 'Remove-AzStorageImportExportJob', 'Update-AzStorageImportExportJob', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'StorageImportExport'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
