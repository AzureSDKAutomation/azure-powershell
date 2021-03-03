---
external help file:
Module Name: Az.DesktopVirtualizationApi
online version: https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/new-azdesktopvirtualizationapihostpool
schema: 2.0.0
---

# New-AzDesktopVirtualizationApiHostPool

## SYNOPSIS
Create or update a host pool.

## SYNTAX

```
New-AzDesktopVirtualizationApiHostPool -Name <String> -ResourceGroupName <String> -HostPoolType <HostPoolType>
 -LoadBalancerType <LoadBalancerType> -Location <String> -PreferredAppGroupType <PreferredAppGroupType>
 [-SubscriptionId <String>] [-CustomRdpProperty <String>] [-Description <String>] [-FriendlyName <String>]
 [-MaxSessionLimit <Int32>] [-PersonalDesktopAssignmentType <PersonalDesktopAssignmentType>]
 [-RegistrationInfoExpirationTime <DateTime>]
 [-RegistrationInfoRegistrationTokenOperation <RegistrationTokenOperation>] [-RegistrationInfoToken <String>]
 [-Ring <Int32>] [-SsoadfsAuthority <String>] [-SsoClientId <String>] [-SsoClientSecretKeyVaultPath <String>]
 [-SsoSecretType <SsoSecretType>] [-StartVMOnConnect] [-Tag <Hashtable>] [-ValidationEnvironment]
 [-VMTemplate <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create or update a host pool.

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

### -CustomRdpProperty
Custom rdp property of HostPool.

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

### -Description
Description of HostPool.

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

### -FriendlyName
Friendly name of HostPool.

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

### -HostPoolType
HostPool type for desktop.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoadBalancerType
The type of the load balancer.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

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

### -MaxSessionLimit
The max session limit of HostPool.

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

### -Name
The name of the host pool within the specified resource group

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: HostPoolName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersonalDesktopAssignmentType
PersonalDesktopAssignment type for HostPool.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredAppGroupType
The type of preferred application group type, default to Desktop Application Group

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationInfoExpirationTime
Expiration time of registration token.

```yaml
Type: System.DateTime
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationInfoRegistrationTokenOperation
The type of resetting the token.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationInfoToken
The registration token base64 encoded string.

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
The name is case insensitive.

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

### -Ring
The ring number of HostPool.

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

### -SsoadfsAuthority
URL to customer ADFS server for signing WVD SSO certificates.

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

### -SsoClientId
ClientId for the registered Relying Party used to issue WVD SSO certificates.

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

### -SsoClientSecretKeyVaultPath
Path to Azure KeyVault storing the secret used for communication to ADFS.

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

### -SsoSecretType
The type of single sign on Secret Type.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartVMOnConnect
The flag to turn on/off StartVMOnConnect feature.

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

### -SubscriptionId
The ID of the target subscription.

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

### -Tag
Resource tags.

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

### -ValidationEnvironment
Is validation environment.

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

### -VMTemplate
VM template for sessionhosts configuration within hostpool.

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

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IHostPool

## NOTES

ALIASES

## RELATED LINKS

