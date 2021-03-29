@{
  GUID = 'c2d1647b-919c-4f16-99e8-540781da5580'
  RootModule = './Az.TimeSeriesInsights.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: TimeSeriesInsights cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.TimeSeriesInsights.private.dll'
  FormatsToProcess = './Az.TimeSeriesInsights.format.ps1xml'
  FunctionsToExport = 'Get-AzTimeSeriesInsightsAccessPolicy', 'Get-AzTimeSeriesInsightsEnvironment', 'Get-AzTimeSeriesInsightsEventSource', 'Get-AzTimeSeriesInsightsReferenceDataSet', 'New-AzTimeSeriesInsightsAccessPolicy', 'New-AzTimeSeriesInsightsEnvironment', 'New-AzTimeSeriesInsightsEventSource', 'New-AzTimeSeriesInsightsReferenceDataSet', 'Remove-AzTimeSeriesInsightsAccessPolicy', 'Remove-AzTimeSeriesInsightsEnvironment', 'Remove-AzTimeSeriesInsightsEventSource', 'Remove-AzTimeSeriesInsightsReferenceDataSet', 'Update-AzTimeSeriesInsightsAccessPolicy', 'Update-AzTimeSeriesInsightsEnvironment', 'Update-AzTimeSeriesInsightsEventSource', 'Update-AzTimeSeriesInsightsReferenceDataSet', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'TimeSeriesInsights'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
