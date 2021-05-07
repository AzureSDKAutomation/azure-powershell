---
Module Name: Az.OperationalInsights
Module Guid: f60b0466-6d66-480b-9c44-437f68b7275b
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights
Help Version: 1.0.0.0
Locale: en-US
---

# Az.OperationalInsights Module
## Description
Microsoft Azure PowerShell: OperationalInsights cmdlets

## Az.OperationalInsights Cmdlets
### [Clear-AzOperationalInsightsWorkspacePurge](Clear-AzOperationalInsightsWorkspacePurge.md)
Purges data in an Log Analytics workspace by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.

### [Disable-AzOperationalInsightsIntelligencePack](Disable-AzOperationalInsightsIntelligencePack.md)
Disables an intelligence pack for a given workspace.

### [Enable-AzOperationalInsightsIntelligencePack](Enable-AzOperationalInsightsIntelligencePack.md)
Enables an intelligence pack for a given workspace.

### [Get-AzOperationalInsightsAvailableServiceTier](Get-AzOperationalInsightsAvailableServiceTier.md)
Gets the available service tiers for the workspace.

### [Get-AzOperationalInsightsCluster](Get-AzOperationalInsightsCluster.md)
Gets a Log Analytics cluster instance.

### [Get-AzOperationalInsightsDataExport](Get-AzOperationalInsightsDataExport.md)
Gets a data export instance.

### [Get-AzOperationalInsightsDataSource](Get-AzOperationalInsightsDataSource.md)
Gets a datasource instance.

### [Get-AzOperationalInsightsDeletedWorkspace](Get-AzOperationalInsightsDeletedWorkspace.md)
Gets recently deleted workspaces in a subscription, available for recovery.

### [Get-AzOperationalInsightsIntelligencePack](Get-AzOperationalInsightsIntelligencePack.md)
Lists all the intelligence packs possible and whether they are enabled or disabled for a given workspace.

### [Get-AzOperationalInsightsLinkedService](Get-AzOperationalInsightsLinkedService.md)
Gets a linked service instance.

### [Get-AzOperationalInsightsLinkedStorageAccount](Get-AzOperationalInsightsLinkedStorageAccount.md)
Gets all linked storage account of a specific data source type associated with the specified workspace.

### [Get-AzOperationalInsightsManagementGroup](Get-AzOperationalInsightsManagementGroup.md)
Gets a list of management groups connected to a workspace.

### [Get-AzOperationalInsightsOperationStatuses](Get-AzOperationalInsightsOperationStatuses.md)
Get the status of a long running azure asynchronous operation.

### [Get-AzOperationalInsightsSavedSearch](Get-AzOperationalInsightsSavedSearch.md)
Gets the specified saved search for a given workspace.

### [Get-AzOperationalInsightsSchema](Get-AzOperationalInsightsSchema.md)
Gets the schema for a given workspace.

### [Get-AzOperationalInsightsSharedKey](Get-AzOperationalInsightsSharedKey.md)
Gets the shared keys for a workspace.

### [Get-AzOperationalInsightsStorageInsightConfig](Get-AzOperationalInsightsStorageInsightConfig.md)
Gets a storage insight instance.

### [Get-AzOperationalInsightsTable](Get-AzOperationalInsightsTable.md)
Gets a Log Analytics workspace table.

### [Get-AzOperationalInsightsUsage](Get-AzOperationalInsightsUsage.md)
Gets a list of usage metrics for a workspace.

### [Get-AzOperationalInsightsWorkspace](Get-AzOperationalInsightsWorkspace.md)
Gets a workspace instance.

### [Get-AzOperationalInsightsWorkspacePurgeStatus](Get-AzOperationalInsightsWorkspacePurgeStatus.md)
Gets status of an ongoing purge operation.

### [New-AzOperationalInsightsCluster](New-AzOperationalInsightsCluster.md)
Create or update a Log Analytics cluster.

### [New-AzOperationalInsightsDataExport](New-AzOperationalInsightsDataExport.md)
Create or update a data export.

### [New-AzOperationalInsightsDataSource](New-AzOperationalInsightsDataSource.md)
Create or update a data source.

### [New-AzOperationalInsightsLinkedService](New-AzOperationalInsightsLinkedService.md)
Create or update a linked service.

### [New-AzOperationalInsightsLinkedStorageAccount](New-AzOperationalInsightsLinkedStorageAccount.md)
Create or Update a link relation between current workspace and a group of storage accounts of a specific data source type.

### [New-AzOperationalInsightsSavedSearch](New-AzOperationalInsightsSavedSearch.md)
Creates or updates a saved search for a given workspace.

### [New-AzOperationalInsightsSharedKey](New-AzOperationalInsightsSharedKey.md)
Regenerates the shared keys for a Log Analytics Workspace.
These keys are used to connect Microsoft Operational Insights agents to the workspace.

### [New-AzOperationalInsightsStorageInsightConfig](New-AzOperationalInsightsStorageInsightConfig.md)
Create or update a storage insight.

### [New-AzOperationalInsightsWorkspace](New-AzOperationalInsightsWorkspace.md)
Create or update a workspace.

### [Remove-AzOperationalInsightsCluster](Remove-AzOperationalInsightsCluster.md)
Deletes a cluster instance.

### [Remove-AzOperationalInsightsDataExport](Remove-AzOperationalInsightsDataExport.md)
Deletes the specified data export in a given workspace..

### [Remove-AzOperationalInsightsDataSource](Remove-AzOperationalInsightsDataSource.md)
Deletes a data source instance.

### [Remove-AzOperationalInsightsGateway](Remove-AzOperationalInsightsGateway.md)
Delete a Log Analytics gateway.

### [Remove-AzOperationalInsightsLinkedService](Remove-AzOperationalInsightsLinkedService.md)
Deletes a linked service instance.

### [Remove-AzOperationalInsightsLinkedStorageAccount](Remove-AzOperationalInsightsLinkedStorageAccount.md)
Deletes all linked storage accounts of a specific data source type associated with the specified workspace.

### [Remove-AzOperationalInsightsSavedSearch](Remove-AzOperationalInsightsSavedSearch.md)
Deletes the specified saved search in a given workspace.

### [Remove-AzOperationalInsightsStorageInsightConfig](Remove-AzOperationalInsightsStorageInsightConfig.md)
Deletes a storageInsightsConfigs resource

### [Remove-AzOperationalInsightsWorkspace](Remove-AzOperationalInsightsWorkspace.md)
Deletes a workspace resource.
To recover the workspace, create it again with the same name, in the same subscription, resource group and location.
The name is kept for 14 days and cannot be used for another workspace.
To remove the workspace completely and release the name, use the force flag.

### [Update-AzOperationalInsightsCluster](Update-AzOperationalInsightsCluster.md)
Updates a Log Analytics cluster.

### [Update-AzOperationalInsightsTable](Update-AzOperationalInsightsTable.md)
Updates a Log Analytics workspace table properties.

### [Update-AzOperationalInsightsWorkspace](Update-AzOperationalInsightsWorkspace.md)
Updates a workspace.

