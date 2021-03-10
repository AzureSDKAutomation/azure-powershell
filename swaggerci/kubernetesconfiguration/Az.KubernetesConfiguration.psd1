@{
  GUID = 'd5d384bc-cbb1-4c98-a279-5b8c28d68799'
  RootModule = './Az.KubernetesConfiguration.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: KubernetesConfiguration cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.KubernetesConfiguration.private.dll'
  FormatsToProcess = './Az.KubernetesConfiguration.format.ps1xml'
  FunctionsToExport = 'Get-AzKubernetesConfigurationExtension', 'Get-AzKubernetesConfigurationSourceControlConfiguration', 'New-AzKubernetesConfigurationExtension', 'New-AzKubernetesConfigurationSourceControlConfiguration', 'Remove-AzKubernetesConfigurationExtension', 'Remove-AzKubernetesConfigurationSourceControlConfiguration', 'Update-AzKubernetesConfigurationExtension', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'KubernetesConfiguration'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
