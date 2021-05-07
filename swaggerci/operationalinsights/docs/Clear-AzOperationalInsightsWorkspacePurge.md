---
external help file:
Module Name: Az.OperationalInsights
online version: https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/clear-azoperationalinsightsworkspacepurge
schema: 2.0.0
---

# Clear-AzOperationalInsightsWorkspacePurge

## SYNOPSIS
Purges data in an Log Analytics workspace by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.

## SYNTAX

### PurgeViaIdentity (Default)
```
Clear-AzOperationalInsightsWorkspacePurge -InputObject <IOperationalInsightsIdentity>
 -Body <IWorkspacePurgeBody> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Purge
```
Clear-AzOperationalInsightsWorkspacePurge -ResourceGroupName <String> -WorkspaceName <String>
 -Body <IWorkspacePurgeBody> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PurgeExpanded
```
Clear-AzOperationalInsightsWorkspacePurge -ResourceGroupName <String> -WorkspaceName <String>
 -Filter <IWorkspacePurgeBodyFilters[]> -Table <String> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentityExpanded
```
Clear-AzOperationalInsightsWorkspacePurge -InputObject <IOperationalInsightsIdentity>
 -Filter <IWorkspacePurgeBodyFilters[]> -Table <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Purges data in an Log Analytics workspace by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -Body
Describes the body of a purge request for an App Insights Workspace
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBody
Parameter Sets: Purge, PurgeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
The set of columns and filters (queries) to run over them to purge the resulting data.
To construct, see NOTES section for FILTER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[]
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
Parameter Sets: PurgeViaIdentity, PurgeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Table
Table from which to purge data.

```yaml
Type: System.String
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceName
The name of the workspace.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBody

### Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IWorkspacePurgeBody>: Describes the body of a purge request for an App Insights Workspace
  - `Filter <IWorkspacePurgeBodyFilters[]>`: The set of columns and filters (queries) to run over them to purge the resulting data.
    - `[Column <String>]`: The column of the table over which the given query should run
    - `[Key <String>]`: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
    - `[Operator <String>]`: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
    - `[Value <IAny>]`: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.
  - `Table <String>`: Table from which to purge data.

FILTER <IWorkspacePurgeBodyFilters[]>: The set of columns and filters (queries) to run over them to purge the resulting data.
  - `[Column <String>]`: The column of the table over which the given query should run
  - `[Key <String>]`: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
  - `[Operator <String>]`: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
  - `[Value <IAny>]`: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  - `[AsyncOperationId <String>]`: The operation Id.
  - `[ClusterName <String>]`: The name of the Log Analytics cluster.
  - `[DataExportName <String>]`: The data export rule name.
  - `[DataSourceName <String>]`: The name of the datasource resource.
  - `[DataSourceType <DataSourceType?>]`: Linked storage accounts type.
  - `[GatewayId <String>]`: The Log Analytics gateway Id.
  - `[Id <String>]`: Resource identity path
  - `[IntelligencePackName <String>]`: The name of the intelligence pack to be disabled.
  - `[LinkedServiceName <String>]`: Name of the linkedServices resource
  - `[Location <String>]`: The region name of operation.
  - `[PurgeId <String>]`: In a purge status request, this is the Id of the operation the status of which is returned.
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[SavedSearchId <String>]`: The id of the saved search.
  - `[StorageInsightName <String>]`: Name of the storageInsightsConfigs resource
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[TableName <String>]`: The name of the table.
  - `[WorkspaceName <String>]`: The name of the workspace.

## RELATED LINKS

