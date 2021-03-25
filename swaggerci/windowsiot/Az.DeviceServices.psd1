@{
  GUID = 'af1ba3b8-2a17-44d0-9711-7859f6ec047a'
  RootModule = './Az.DeviceServices.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: DeviceServices cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.DeviceServices.private.dll'
  FormatsToProcess = './Az.DeviceServices.format.ps1xml'
  FunctionsToExport = 'Get-AzDeviceServicesService', 'New-AzDeviceServicesService', 'Remove-AzDeviceServicesService', 'Test-AzDeviceServicesServiceDeviceServiceNameAvailability', 'Update-AzDeviceServicesService', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'DeviceServices'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
