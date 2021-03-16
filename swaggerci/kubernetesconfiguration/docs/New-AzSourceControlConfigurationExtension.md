---
external help file:
Module Name: Az.SourceControlConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/az.sourcecontrolconfiguration/new-azsourcecontrolconfigurationextension
schema: 2.0.0
---

# New-AzSourceControlConfigurationExtension

## SYNOPSIS
Create a new Kubernetes Cluster Extension Instance.

## SYNTAX

```
New-AzSourceControlConfigurationExtension -ClusterName <String> -ClusterResourceName <String>
 -ClusterRp <String> -InstanceName <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-AutoUpgradeMinorVersion] [-ClusterReleaseNamespace <String>] [-ConfigurationProtectedSetting <Hashtable>]
 [-ConfigurationSetting <Hashtable>] [-ExtensionType <String>] [-IdentityType <ResourceIdentityType>]
 [-NamespaceTargetNamespace <String>] [-ReleaseTrain <String>] [-Statuses <IExtensionStatus[]>]
 [-Version <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new Kubernetes Cluster Extension Instance.

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

### -AutoUpgradeMinorVersion
Flag to note if this instance participates in auto upgrade of minor version, or not.

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

### -ClusterName
The name of the kubernetes cluster.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterReleaseNamespace
Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance.
If this namespace does not exist, it will be created

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterResourceName
The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterRp
The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigurationProtectedSetting
Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigurationSetting
Configuration settings, as name-value pairs for configuring this instance of the extension.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -ExtensionType
Type of the Extension, of which this resource is an instance of.
It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityType
The type of identity used for the configuration.
Type 'SystemAssigned' will use an implicitly created identity.
Type 'None' will not use Managed Identity for the configuration.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstanceName
Name of an instance of the Extension.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ExtensionInstanceName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NamespaceTargetNamespace
Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance.
If this namespace does not exist, it will be created

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReleaseTrain
ReleaseTrain this extension instance participates in for auto-upgrade (e.g.
Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Statuses
Status from this instance of the extension.
To construct, see NOTES section for STATUSES properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionStatus[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Azure subscription ID.
This is a GUID-formatted string (e.g.
00000000-0000-0000-0000-000000000000)

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the extension for this extension instance, if it is 'pinned' to a specific version.
autoUpgradeMinorVersion must be 'false'.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionInstance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


STATUSES <IExtensionStatus[]>: Status from this instance of the extension.
  - `[Code <String>]`: Status code provided by the Extension
  - `[DisplayStatus <String>]`: Short description of status of this instance of the extension.
  - `[Level <LevelType?>]`: Level of the status.
  - `[Message <String>]`: Detailed message of the status from the Extension instance.
  - `[Time <String>]`: DateLiteral (per ISO8601) noting the time of installation status.

## RELATED LINKS

