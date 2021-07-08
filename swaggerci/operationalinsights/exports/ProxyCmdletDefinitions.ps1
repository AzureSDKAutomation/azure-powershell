
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Purges data in an Log Analytics workspace by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.
.Description
Purges data in an Log Analytics workspace by a set of user-defined filters.\n\nIn order to manage system resources, purge requests are throttled at 50 requests per hour.
You should batch the execution of purge requests by sending a single command whose predicate includes all user identities that require purging.
Use the in operator to specify multiple identities.
You should run the query prior to using for a purge request to verify that the results are expected.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBody
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IWorkspacePurgeBody>: Describes the body of a purge request for an App Insights Workspace
  Filter <IWorkspacePurgeBodyFilters[]>: The set of columns and filters (queries) to run over them to purge the resulting data.
    [Column <String>]: The column of the table over which the given query should run
    [Key <String>]: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
    [Operator <String>]: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
    [Value <IAny>]: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.
  Table <String>: Table from which to purge data.

FILTER <IWorkspacePurgeBodyFilters[]>: The set of columns and filters (queries) to run over them to purge the resulting data.
  [Column <String>]: The column of the table over which the given query should run
  [Key <String>]: When filtering over custom dimensions, this key will be used as the name of the custom dimension.
  [Operator <String>]: A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, >, >=, <, <=, between, and have the same behavior as they would in a KQL query.
  [Value <IAny>]: the value for the operator to function over. This can be a number (e.g., > 100), a string (timestamp >= '2017-09-01') or array of values.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/clear-azoperationalinsightsworkspacepurge
#>
function Clear-AzOperationalInsightsWorkspacePurge {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponse])]
[CmdletBinding(DefaultParameterSetName='PurgeViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Purge', Mandatory)]
    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Purge')]
    [Parameter(ParameterSetName='PurgeExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Purge', Mandatory)]
    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='PurgeViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Purge', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PurgeViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBody]
    # Describes the body of a purge request for an App Insights Workspace
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory)]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeBodyFilters[]]
    # The set of columns and filters (queries) to run over them to purge the resulting data.
    # To construct, see NOTES section for FILTER properties and create a hash table.
    ${Filter},

    [Parameter(ParameterSetName='PurgeExpanded', Mandatory)]
    [Parameter(ParameterSetName='PurgeViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # Table from which to purge data.
    ${Table},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Purge = 'Az.OperationalInsights.private\Clear-AzOperationalInsightsWorkspacePurge_Purge';
            PurgeExpanded = 'Az.OperationalInsights.private\Clear-AzOperationalInsightsWorkspacePurge_PurgeExpanded';
            PurgeViaIdentity = 'Az.OperationalInsights.private\Clear-AzOperationalInsightsWorkspacePurge_PurgeViaIdentity';
            PurgeViaIdentityExpanded = 'Az.OperationalInsights.private\Clear-AzOperationalInsightsWorkspacePurge_PurgeViaIdentityExpanded';
        }
        if (('Purge', 'PurgeExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Disables an intelligence pack for a given workspace.
.Description
Disables an intelligence pack for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/disable-azoperationalinsightsintelligencepack
#>
function Disable-AzOperationalInsightsIntelligencePack {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Disable', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Disable', Mandatory)]
    [Alias('IntelligencePackName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the intelligence pack to be disabled.
    ${Name},

    [Parameter(ParameterSetName='Disable', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Disable')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Disable', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DisableViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Disable = 'Az.OperationalInsights.private\Disable-AzOperationalInsightsIntelligencePack_Disable';
            DisableViaIdentity = 'Az.OperationalInsights.private\Disable-AzOperationalInsightsIntelligencePack_DisableViaIdentity';
        }
        if (('Disable') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Enables an intelligence pack for a given workspace.
.Description
Enables an intelligence pack for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/enable-azoperationalinsightsintelligencepack
#>
function Enable-AzOperationalInsightsIntelligencePack {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Enable', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Enable', Mandatory)]
    [Alias('IntelligencePackName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the intelligence pack to be enabled.
    ${Name},

    [Parameter(ParameterSetName='Enable', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Enable')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Enable', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='EnableViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Enable = 'Az.OperationalInsights.private\Enable-AzOperationalInsightsIntelligencePack_Enable';
            EnableViaIdentity = 'Az.OperationalInsights.private\Enable-AzOperationalInsightsIntelligencePack_EnableViaIdentity';
        }
        if (('Enable') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets the available service tiers for the workspace.
.Description
Gets the available service tiers for the workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsavailableservicetier
#>
function Get-AzOperationalInsightsAvailableServiceTier {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IAvailableServiceTier])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsAvailableServiceTier_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a Log Analytics cluster instance.
.Description
Gets a Log Analytics cluster instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightscluster
#>
function Get-AzOperationalInsightsCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster])]
[CmdletBinding(DefaultParameterSetName='List1', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the Log Analytics Cluster.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsCluster_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsCluster_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsCluster_List';
            List1 = 'Az.OperationalInsights.private\Get-AzOperationalInsightsCluster_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a data export instance.
.Description
Gets a data export instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsdataexport
#>
function Get-AzOperationalInsightsDataExport {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('DataExportName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The data export rule name.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataExport_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataExport_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataExport_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a datasource instance.
.Description
Gets a datasource instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsdatasource
#>
function Get-AzOperationalInsightsDataSource {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSource])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('DataSourceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the datasource
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Query')]
    [System.String]
    # The filter to apply on the operation.
    ${Filter},

    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Query')]
    [System.String]
    # Starting point of the collection of data source instances.
    ${Skiptoken},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataSource_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataSource_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDataSource_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets recently deleted workspaces in a subscription, available for recovery.
.Description
Gets recently deleted workspaces in a subscription, available for recovery.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsdeletedworkspace
#>
function Get-AzOperationalInsightsDeletedWorkspace {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDeletedWorkspace_List';
            List1 = 'Az.OperationalInsights.private\Get-AzOperationalInsightsDeletedWorkspace_List1';
        }
        if (('List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Lists all the intelligence packs possible and whether they are enabled or disabled for a given workspace.
.Description
Lists all the intelligence packs possible and whether they are enabled or disabled for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IIntelligencePack
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsintelligencepack
#>
function Get-AzOperationalInsightsIntelligencePack {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IIntelligencePack])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsIntelligencePack_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a linked service instance.
.Description
Gets a linked service instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightslinkedservice
#>
function Get-AzOperationalInsightsLinkedService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('LinkedServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the linked service.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedService_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedService_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedService_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets all linked storage account of a specific data source type associated with the specified workspace.
.Description
Gets all linked storage account of a specific data source type associated with the specified workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightslinkedstorageaccount
#>
function Get-AzOperationalInsightsLinkedStorageAccount {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType]
    # Linked storage accounts type.
    ${DataSourceType},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedStorageAccount_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedStorageAccount_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsLinkedStorageAccount_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a list of management groups connected to a workspace.
.Description
Gets a list of management groups connected to a workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsmanagementgroup
#>
function Get-AzOperationalInsightsManagementGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsManagementGroup_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Get the status of a long running azure asynchronous operation.
.Description
Get the status of a long running azure asynchronous operation.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatus
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsoperationstatuses
#>
function Get-AzOperationalInsightsOperationStatuses {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatus])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The operation Id.
    ${AsyncOperationId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The region name of operation.
    ${Location},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsOperationStatuses_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsOperationStatuses_GetViaIdentity';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets the specified saved search for a given workspace.
.Description
Gets the specified saved search for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearch
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightssavedsearch
#>
function Get-AzOperationalInsightsSavedSearch {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearch])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('SavedSearchId')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The id of the saved search.
    ${Id},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSavedSearch_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSavedSearch_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSavedSearch_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets the schema for a given workspace.
.Description
Gets the schema for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsschema
#>
function Get-AzOperationalInsightsSchema {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISearchGetSchemaResponse])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSchema_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSchema_GetViaIdentity';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets the shared keys for a workspace.
.Description
Gets the shared keys for a workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeys
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightssharedkey
#>
function Get-AzOperationalInsightsSharedKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeys])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSharedKey_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsSharedKey_GetViaIdentity';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a storage insight instance.
.Description
Gets a storage insight instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsstorageinsightconfig
#>
function Get-AzOperationalInsightsStorageInsightConfig {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the storageInsightsConfigs resource
    ${StorageInsightName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsStorageInsightConfig_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsStorageInsightConfig_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsStorageInsightConfig_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a Log Analytics workspace table.
.Description
Gets a Log Analytics workspace table.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITable
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightstable
#>
function Get-AzOperationalInsightsTable {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITable])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('TableName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the table.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsTable_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsTable_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsTable_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a list of usage metrics for a workspace.
.Description
Gets a list of usage metrics for a workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsusage
#>
function Get-AzOperationalInsightsUsage {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsUsage_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets status of an ongoing purge operation.
.Description
Gets status of an ongoing purge operation.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsworkspacepurgestatus
#>
function Get-AzOperationalInsightsWorkspacePurgeStatus {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # In a purge status request, this is the Id of the operation the status of which is returned.
    ${PurgeId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspacePurgeStatus_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspacePurgeStatus_GetViaIdentity';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Gets a workspace instance.
.Description
Gets a workspace instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/get-azoperationalinsightsworkspace
#>
function Get-AzOperationalInsightsWorkspace {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('WorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspace_Get';
            GetViaIdentity = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspace_GetViaIdentity';
            List = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspace_List';
            List1 = 'Az.OperationalInsights.private\Get-AzOperationalInsightsWorkspace_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a Log Analytics cluster.
.Description
Create or update a Log Analytics cluster.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightscluster
#>
function New-AzOperationalInsightsCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the Log Analytics cluster.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace[]]
    # The list of Log Analytics workspaces associated with the cluster
    ${AssociatedWorkspace},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.BillingType]
    # Configures whether billing will be only on the cluster or each workspace will be billed by its proportional use.
    # This does not change the overall billing, only how it will be distributed.
    # Default value is 'Cluster'
    ${BillingType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType]
    # Type of managed service identity.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The list of user identities associated with the resource.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Sets whether the cluster will support availability zones.
    # This can be set as true only in regions where Azure Data Explorer support Availability Zones.
    # This Property can not be modified after cluster creation.
    # Default value is 'true' if region supports Availability Zones.
    ${IsAvailabilityZonesEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Configures whether cluster will use double encryption.
    # This Property can not be modified after cluster creation.
    # Default value is 'true'
    ${IsDoubleEncryptionEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The name of the key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # Selected key minimum required size.
    ${KeyVaultPropertyKeyRsaSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The Key Vault uri which holds they key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyVaultUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The version of the key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int64]
    # The capacity value
    ${SkuCapacity},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum]
    # The name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsCluster_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a data export.
.Description
Create or update a data export.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightsdataexport
#>
function New-AzOperationalInsightsDataExport {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('DataExportName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The data export rule name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The latest data export rule modification time.
    ${CreatedDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The data export rule ID.
    ${DataExportId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The destination resource ID.
    # This can be copied from the Properties entry of the destination resource in Azure.
    ${DestinationResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Active when enabled.
    ${Enable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # Date and time when the export was last modified.
    ${LastModifiedDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # Optional.
    # Allows to define an Event Hub name.
    # Not applicable when destination is Storage Account.
    ${MetaDataEventHubName},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String[]]
    # An array of tables to export, for example: [“Heartbeat, SecurityEvent”].
    ${TableName},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsDataExport_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a data source.
.Description
Create or update a data source.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSource
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightsdatasource
#>
function New-AzOperationalInsightsDataSource {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('DataSourceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the datasource resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceKind]
    # The kind of the DataSource.
    ${Kind},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IAny]
    # The data source properties in raw json format, each kind of data source have it's own schema.
    ${Property},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The ETag of the data source.
    ${Etag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsDataSource_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a linked service.
.Description
Create or update a linked service.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightslinkedservice
#>
function New-AzOperationalInsightsLinkedService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('LinkedServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the linkedServices resource
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus]
    # The provisioning state of the linked service.
    ${ProvisioningState},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The resource id of the resource that will be linked to the workspace.
    # This should be used for linking resources which require read access
    ${ResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The resource id of the resource that will be linked to the workspace.
    # This should be used for linking resources which require write access
    ${WriteAccessResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsLinkedService_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or Update a link relation between current workspace and a group of storage accounts of a specific data source type.
.Description
Create or Update a link relation between current workspace and a group of storage accounts of a specific data source type.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightslinkedstorageaccount
#>
function New-AzOperationalInsightsLinkedStorageAccount {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedStorageAccountsResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType]
    # Linked storage accounts type.
    ${DataSourceType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String[]]
    # Linked storage accounts resources ids.
    ${StorageAccountId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsLinkedStorageAccount_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a saved search for a given workspace.
.Description
Creates or updates a saved search for a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearch
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

TAG <ITag[]>: The tags attached to the saved search.
  Name <String>: The tag name.
  Value <String>: The tag value.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightssavedsearch
#>
function New-AzOperationalInsightsSavedSearch {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISavedSearch])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('SavedSearchId')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The id of the saved search.
    ${Id},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The category of the saved search.
    # This helps the user to find a saved search faster.
    ${Category},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # Saved search display name.
    ${DisplayName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The query expression for the saved search.
    ${Query},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The ETag of the saved search.
    ${Etag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The function alias if query serves as a function.
    ${FunctionAlias},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The optional function parameters if query serves as a function.
    # Value should be in the following format: 'param-name1:type1 = default_value1, param-name2:type2 = default_value2'.
    # For more examples and proper syntax please refer to https://docs.microsoft.com/en-us/azure/kusto/query/functions/user-defined-functions.
    ${FunctionParameter},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITag[]]
    # The tags attached to the saved search.
    # To construct, see NOTES section for TAG properties and create a hash table.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int64]
    # The version number of the query language.
    # The current version is 2 and is the default.
    ${Version},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsSavedSearch_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Regenerates the shared keys for a Log Analytics Workspace.
These keys are used to connect Microsoft Operational Insights agents to the workspace.
.Description
Regenerates the shared keys for a Log Analytics Workspace.
These keys are used to connect Microsoft Operational Insights agents to the workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeys
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightssharedkey
#>
function New-AzOperationalInsightsSharedKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ISharedKeys])]
[CmdletBinding(DefaultParameterSetName='Regenerate', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Regenerate')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='RegenerateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Regenerate = 'Az.OperationalInsights.private\New-AzOperationalInsightsSharedKey_Regenerate';
            RegenerateViaIdentity = 'Az.OperationalInsights.private\New-AzOperationalInsightsSharedKey_RegenerateViaIdentity';
        }
        if (('Regenerate') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a storage insight.
.Description
Create or update a storage insight.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightsstorageinsightconfig
#>
function New-AzOperationalInsightsStorageInsightConfig {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsight])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the storageInsightsConfigs resource
    ${StorageInsightName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String[]]
    # The names of the blob containers that the workspace should read
    ${Container},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The ETag of the storage insight.
    ${ETag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The Azure Resource Manager ID of the storage account resource.
    ${StorageAccountId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The storage account key.
    ${StorageAccountKey},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String[]]
    # The names of the Azure tables that the workspace should read
    ${Table},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IStorageInsightTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsStorageInsightConfig_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update a workspace.
.Description
Create or update a workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/new-azoperationalinsightsworkspace
#>
function New-AzOperationalInsightsWorkspace {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('WorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The ETag of the workspace.
    ${ETag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures]))]
    [System.Collections.Hashtable]
    # Workspace features.
    ${Feature},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether customer managed storage is mandatory for query management.
    ${ForceCmkForQuery},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus]
    # The provisioning state of the workspace.
    ${ProvisioningState},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType]
    # The network access type for accessing Log Analytics ingestion.
    ${PublicNetworkAccessForIngestion},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType]
    # The network access type for accessing Log Analytics query.
    ${PublicNetworkAccessForQuery},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # The workspace data retention in days.
    # Allowed values are per pricing plan.
    # See pricing tiers documentation for details.
    ${RetentionInDay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # The capacity reservation level for this workspace, when CapacityReservation sku is selected.
    ${SkuCapacityReservationLevel},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum]
    # The name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Double]
    # The workspace daily quota for ingestion.
    ${WorkspaceCappingDailyQuotaGb},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.OperationalInsights.private\New-AzOperationalInsightsWorkspace_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes a cluster instance.
.Description
Deletes a cluster instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightscluster
#>
function Remove-AzOperationalInsightsCluster {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the Log Analytics Cluster.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsCluster_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsCluster_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes the specified data export in a given workspace..
.Description
Deletes the specified data export in a given workspace..
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightsdataexport
#>
function Remove-AzOperationalInsightsDataExport {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('DataExportName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The data export rule name.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsDataExport_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsDataExport_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes a data source instance.
.Description
Deletes a data source instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightsdatasource
#>
function Remove-AzOperationalInsightsDataSource {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('DataSourceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the datasource.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsDataSource_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsDataSource_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Delete a Log Analytics gateway.
.Description
Delete a Log Analytics gateway.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightsgateway
#>
function Remove-AzOperationalInsightsGateway {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('GatewayId')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The Log Analytics gateway Id.
    ${Id},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsGateway_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsGateway_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes a linked service instance.
.Description
Deletes a linked service instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightslinkedservice
#>
function Remove-AzOperationalInsightsLinkedService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('LinkedServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the linked service.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsLinkedService_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsLinkedService_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes all linked storage accounts of a specific data source type associated with the specified workspace.
.Description
Deletes all linked storage accounts of a specific data source type associated with the specified workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightslinkedstorageaccount
#>
function Remove-AzOperationalInsightsLinkedStorageAccount {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataSourceType]
    # Linked storage accounts type.
    ${DataSourceType},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsLinkedStorageAccount_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsLinkedStorageAccount_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes the specified saved search in a given workspace.
.Description
Deletes the specified saved search in a given workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightssavedsearch
#>
function Remove-AzOperationalInsightsSavedSearch {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('SavedSearchId')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The id of the saved search.
    ${Id},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsSavedSearch_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsSavedSearch_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes a storageInsightsConfigs resource
.Description
Deletes a storageInsightsConfigs resource
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightsstorageinsightconfig
#>
function Remove-AzOperationalInsightsStorageInsightConfig {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the storageInsightsConfigs resource
    ${StorageInsightName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsStorageInsightConfig_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsStorageInsightConfig_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Deletes a workspace resource.
To recover the workspace, create it again with the same name, in the same subscription, resource group and location.
The name is kept for 14 days and cannot be used for another workspace.
To remove the workspace completely and release the name, use the force flag.
.Description
Deletes a workspace resource.
To recover the workspace, create it again with the same name, in the same subscription, resource group and location.
The name is kept for 14 days and cannot be used for another workspace.
To remove the workspace completely and release the name, use the force flag.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/remove-azoperationalinsightsworkspace
#>
function Remove-AzOperationalInsightsWorkspace {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('WorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Query')]
    [System.Management.Automation.SwitchParameter]
    # Deletes the workspace without the recovery option.
    # A workspace that was deleted with this flag cannot be recovered.
    ${Force},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsWorkspace_Delete';
            DeleteViaIdentity = 'Az.OperationalInsights.private\Remove-AzOperationalInsightsWorkspace_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates a Log Analytics cluster.
.Description
Updates a Log Analytics cluster.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/update-azoperationalinsightscluster
#>
function Update-AzOperationalInsightsCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.ICluster])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # Name of the Log Analytics Cluster.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.IdentityType]
    # Type of managed service identity.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The list of user identities associated with the resource.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The name of the key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # Selected key minimum required size.
    ${KeyVaultPropertyKeyRsaSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The Key Vault uri which holds they key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyVaultUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.String]
    # The version of the key associated with the Log Analytics cluster.
    ${KeyVaultPropertyKeyVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int64]
    # The capacity value
    ${SkuCapacity},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.ClusterSkuNameEnum]
    # The name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IClusterPatchTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsCluster_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsCluster_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates a Log Analytics workspace table properties.
.Description
Updates a Log Analytics workspace table properties.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITable
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/update-azoperationalinsightstable
#>
function Update-AzOperationalInsightsTable {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITable])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('TableName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the table.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${WorkspaceName},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # The data table data retention in days, between 30 and 730.
    # Setting this property to null will default to the workspace retention.
    ${RetentionInDay},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsTable_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsTable_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates a workspace.
.Description
Updates a workspace.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IOperationalInsightsIdentity>: Identity Parameter
  [AsyncOperationId <String>]: The operation Id.
  [ClusterName <String>]: The name of the Log Analytics cluster.
  [DataExportName <String>]: The data export rule name.
  [DataSourceName <String>]: The name of the datasource resource.
  [DataSourceType <DataSourceType?>]: Linked storage accounts type.
  [GatewayId <String>]: The Log Analytics gateway Id.
  [Id <String>]: Resource identity path
  [IntelligencePackName <String>]: The name of the intelligence pack to be disabled.
  [LinkedServiceName <String>]: Name of the linkedServices resource
  [Location <String>]: The region name of operation.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SavedSearchId <String>]: The id of the saved search.
  [StorageInsightName <String>]: Name of the storageInsightsConfigs resource
  [SubscriptionId <String>]: The ID of the target subscription.
  [TableName <String>]: The name of the table.
  [WorkspaceName <String>]: The name of the workspace.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.operationalinsights/update-azoperationalinsightsworkspace
#>
function Update-AzOperationalInsightsWorkspace {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspace])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('WorkspaceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the workspace.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.IOperationalInsightsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspaceFeatures]))]
    [System.Collections.Hashtable]
    # Workspace features.
    ${Feature},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether customer managed storage is mandatory for query management.
    ${ForceCmkForQuery},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceEntityStatus]
    # The provisioning state of the workspace.
    ${ProvisioningState},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType]
    # The network access type for accessing Log Analytics ingestion.
    ${PublicNetworkAccessForIngestion},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PublicNetworkAccessType]
    # The network access type for accessing Log Analytics query.
    ${PublicNetworkAccessForQuery},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # The workspace data retention in days.
    # Allowed values are per pricing plan.
    # See pricing tiers documentation for details.
    ${RetentionInDay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Int32]
    # The capacity reservation level for this workspace, when CapacityReservation sku is selected.
    ${SkuCapacityReservationLevel},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.WorkspaceSkuNameEnum]
    # The name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IWorkspacePatchTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    # Optional.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Body')]
    [System.Double]
    # The workspace daily quota for ingestion.
    ${WorkspaceCappingDailyQuotaGb},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsWorkspace_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.OperationalInsights.private\Update-AzOperationalInsightsWorkspace_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
