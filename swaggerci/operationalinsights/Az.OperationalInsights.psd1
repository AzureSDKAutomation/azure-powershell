@{
  GUID = 'f60b0466-6d66-480b-9c44-437f68b7275b'
  RootModule = './Az.OperationalInsights.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: OperationalInsights cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.OperationalInsights.private.dll'
  FormatsToProcess = './Az.OperationalInsights.format.ps1xml'
  FunctionsToExport = 'Clear-AzOperationalInsightsWorkspacePurge', 'Disable-AzOperationalInsightsIntelligencePack', 'Enable-AzOperationalInsightsIntelligencePack', 'Get-AzOperationalInsightsAvailableServiceTier', 'Get-AzOperationalInsightsCluster', 'Get-AzOperationalInsightsDataExport', 'Get-AzOperationalInsightsDataSource', 'Get-AzOperationalInsightsDeletedWorkspace', 'Get-AzOperationalInsightsIntelligencePack', 'Get-AzOperationalInsightsLinkedService', 'Get-AzOperationalInsightsLinkedStorageAccount', 'Get-AzOperationalInsightsManagementGroup', 'Get-AzOperationalInsightsOperationStatuses', 'Get-AzOperationalInsightsSavedSearch', 'Get-AzOperationalInsightsSchema', 'Get-AzOperationalInsightsSharedKey', 'Get-AzOperationalInsightsStorageInsightConfig', 'Get-AzOperationalInsightsTable', 'Get-AzOperationalInsightsUsage', 'Get-AzOperationalInsightsWorkspace', 'Get-AzOperationalInsightsWorkspacePurgeStatus', 'New-AzOperationalInsightsCluster', 'New-AzOperationalInsightsDataExport', 'New-AzOperationalInsightsDataSource', 'New-AzOperationalInsightsLinkedService', 'New-AzOperationalInsightsLinkedStorageAccount', 'New-AzOperationalInsightsSavedSearch', 'New-AzOperationalInsightsSharedKey', 'New-AzOperationalInsightsStorageInsightConfig', 'New-AzOperationalInsightsWorkspace', 'Remove-AzOperationalInsightsCluster', 'Remove-AzOperationalInsightsDataExport', 'Remove-AzOperationalInsightsDataSource', 'Remove-AzOperationalInsightsGateway', 'Remove-AzOperationalInsightsLinkedService', 'Remove-AzOperationalInsightsLinkedStorageAccount', 'Remove-AzOperationalInsightsSavedSearch', 'Remove-AzOperationalInsightsStorageInsightConfig', 'Remove-AzOperationalInsightsWorkspace', 'Update-AzOperationalInsightsCluster', 'Update-AzOperationalInsightsTable', 'Update-AzOperationalInsightsWorkspace', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'OperationalInsights'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
