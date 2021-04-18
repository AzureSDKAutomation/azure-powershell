---
external help file:
Module Name: Az.OperationalInsights
online version: https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/update-azoperationalinsightstable
schema: 2.0.0
---

# Update-AzOperationalInsightsTable

## SYNOPSIS
Updates a Log Analytics workspace table properties.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzOperationalInsightsTable -Name <String> -ResourceGroupName <String> -WorkspaceName <String>
 [-SubscriptionId <String>] [-IsTroubleshootEnabled] [-RetentionInDay <Int32>] [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzOperationalInsightsTable -InputObject <IOperationalInsightsIdentity> [-IsTroubleshootEnabled]
 [-RetentionInDay <Int32>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Updates a Log Analytics workspace table properties.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsTroubleshootEnabled
Enable or disable troubleshoot for this table.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the table.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases: TableName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetentionInDay
The data table data retention in days, between 7 and 730.
Setting this property to null will default to the workspace retention.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceName
The name of the workspace.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ITable

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

