@{
  GUID = 'e3808ff1-5bf9-45fe-a22e-b9a188af4c11'
  RootModule = './Az.Kusto.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Kusto cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Kusto.private.dll'
  FormatsToProcess = './Az.Kusto.format.ps1xml'
  FunctionsToExport = 'Add-AzKustoClusterLanguageExtension', 'Add-AzKustoDatabasePrincipal', 'Get-AzKustoAttachedDatabaseConfiguration', 'Get-AzKustoCluster', 'Get-AzKustoClusterFollowerDatabase', 'Get-AzKustoClusterLanguageExtension', 'Get-AzKustoClusterPrincipalAssignment', 'Get-AzKustoClusterSku', 'Get-AzKustoDatabase', 'Get-AzKustoDatabasePrincipal', 'Get-AzKustoDatabasePrincipalAssignment', 'Get-AzKustoDataConnection', 'Get-AzKustoOperationsResult', 'Get-AzKustoScript', 'Invoke-AzKustoDataConnectionValidation', 'Invoke-AzKustoDetachClusterFollowerDatabase', 'Invoke-AzKustoDiagnoseClusterVirtualNetwork', 'New-AzKustoAttachedDatabaseConfiguration', 'New-AzKustoCluster', 'New-AzKustoClusterPrincipalAssignment', 'New-AzKustoDatabase', 'New-AzKustoDatabasePrincipalAssignment', 'New-AzKustoDataConnection', 'New-AzKustoScript', 'Remove-AzKustoAttachedDatabaseConfiguration', 'Remove-AzKustoCluster', 'Remove-AzKustoClusterLanguageExtension', 'Remove-AzKustoClusterPrincipalAssignment', 'Remove-AzKustoDatabase', 'Remove-AzKustoDatabasePrincipal', 'Remove-AzKustoDatabasePrincipalAssignment', 'Remove-AzKustoDataConnection', 'Remove-AzKustoScript', 'Start-AzKustoCluster', 'Stop-AzKustoCluster', 'Test-AzKustoClusterNameAvailability', 'Test-AzKustoClusterPrincipalAssignmentNameAvailability', 'Test-AzKustoDatabaseNameAvailability', 'Test-AzKustoDatabasePrincipalAssignmentNameAvailability', 'Test-AzKustoDataConnectionNameAvailability', 'Test-AzKustoScriptNameAvailability', 'Update-AzKustoCluster', 'Update-AzKustoDatabase', 'Update-AzKustoDataConnection', 'Update-AzKustoScript', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Kusto'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
