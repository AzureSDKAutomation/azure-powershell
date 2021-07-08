
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
