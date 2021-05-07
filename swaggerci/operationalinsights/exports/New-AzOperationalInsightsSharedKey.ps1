
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
