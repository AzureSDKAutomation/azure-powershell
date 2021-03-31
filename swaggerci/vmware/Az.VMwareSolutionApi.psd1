@{
  GUID = 'ca856192-a3a7-4a24-a3ef-f96625e02fe6'
  RootModule = './Az.VMwareSolutionApi.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: VMwareSolutionApi cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.VMwareSolutionApi.private.dll'
  FormatsToProcess = './Az.VMwareSolutionApi.format.ps1xml'
  FunctionsToExport = 'Get-AzVMwareSolutionApiAddon', 'Get-AzVMwareSolutionApiAuthorization', 'Get-AzVMwareSolutionApiCluster', 'Get-AzVMwareSolutionApiDatastore', 'Get-AzVMwareSolutionApiGlobalReachConnection', 'Get-AzVMwareSolutionApiHcxEnterpriseSite', 'Get-AzVMwareSolutionApiPrivateCloud', 'Get-AzVMwareSolutionApiPrivateCloudAdminCredentials', 'Get-AzVMwareSolutionApiWorkloadNetworkDhcp', 'Get-AzVMwareSolutionApiWorkloadNetworkDnsService', 'Get-AzVMwareSolutionApiWorkloadNetworkDnsZone', 'Get-AzVMwareSolutionApiWorkloadNetworkGateway', 'Get-AzVMwareSolutionApiWorkloadNetworkPortMirroring', 'Get-AzVMwareSolutionApiWorkloadNetworkSegment', 'Get-AzVMwareSolutionApiWorkloadNetworkVirtualMachine', 'Get-AzVMwareSolutionApiWorkloadNetworkVMGroup', 'Invoke-AzVMwareSolutionApiRotatePrivateCloudNsxtPassword', 'Invoke-AzVMwareSolutionApiRotatePrivateCloudVcenterPassword', 'New-AzVMwareSolutionApiAddon', 'New-AzVMwareSolutionApiAuthorization', 'New-AzVMwareSolutionApiCluster', 'New-AzVMwareSolutionApiDatastore', 'New-AzVMwareSolutionApiGlobalReachConnection', 'New-AzVMwareSolutionApiHcxEnterpriseSite', 'New-AzVMwareSolutionApiPrivateCloud', 'New-AzVMwareSolutionApiWorkloadNetworkDhcp', 'New-AzVMwareSolutionApiWorkloadNetworkDnsService', 'New-AzVMwareSolutionApiWorkloadNetworkDnsZone', 'New-AzVMwareSolutionApiWorkloadNetworkPortMirroring', 'New-AzVMwareSolutionApiWorkloadNetworkSegment', 'New-AzVMwareSolutionApiWorkloadNetworkVMGroup', 'Remove-AzVMwareSolutionApiAddon', 'Remove-AzVMwareSolutionApiAuthorization', 'Remove-AzVMwareSolutionApiCluster', 'Remove-AzVMwareSolutionApiDatastore', 'Remove-AzVMwareSolutionApiGlobalReachConnection', 'Remove-AzVMwareSolutionApiHcxEnterpriseSite', 'Remove-AzVMwareSolutionApiPrivateCloud', 'Remove-AzVMwareSolutionApiWorkloadNetworkDhcp', 'Remove-AzVMwareSolutionApiWorkloadNetworkDnsService', 'Remove-AzVMwareSolutionApiWorkloadNetworkDnsZone', 'Remove-AzVMwareSolutionApiWorkloadNetworkPortMirroring', 'Remove-AzVMwareSolutionApiWorkloadNetworkSegment', 'Remove-AzVMwareSolutionApiWorkloadNetworkVMGroup', 'Test-AzVMwareSolutionApiLocationQuotaAvailability', 'Test-AzVMwareSolutionApiLocationTrialAvailability', 'Update-AzVMwareSolutionApiCluster', 'Update-AzVMwareSolutionApiPrivateCloud', 'Update-AzVMwareSolutionApiWorkloadNetworkDhcp', 'Update-AzVMwareSolutionApiWorkloadNetworkDnsService', 'Update-AzVMwareSolutionApiWorkloadNetworkDnsZone', 'Update-AzVMwareSolutionApiWorkloadNetworkPortMirroring', 'Update-AzVMwareSolutionApiWorkloadNetworkSegment', 'Update-AzVMwareSolutionApiWorkloadNetworkVMGroup', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'VMwareSolutionApi'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
