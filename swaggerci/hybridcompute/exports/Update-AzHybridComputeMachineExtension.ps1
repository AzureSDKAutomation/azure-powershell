
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
The operation to create or update the extension.
.Description
The operation to create or update the extension.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IHybridComputeIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtension
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IHybridComputeIdentity>: Identity Parameter
  [ExtensionName <String>]: The name of the machine extension.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [Location <String>]: The location of the target resource.
  [MachineName <String>]: The name of the hybrid machine.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [PrivateLinkScopeId <String>]: The id (Guid) of the Azure Arc PrivateLinkScope resource.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScopeName <String>]: The name of the Azure Arc PrivateLinkScope resource.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.hybridcompute/update-azhybridcomputemachineextension
#>
function Update-AzHybridComputeMachineExtension {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtension])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the machine extension.
    ${ExtensionName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the machine where the extension should be created or updated.
    ${MachineName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IHybridComputeIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the extension should use a newer minor version if one is available at deployment time.
    # Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
    ${AutoUpgradeMinorVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # How the extension handler should be forced to update even if the extension configuration has not changed.
    ${ForceUpdateTag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny]
    # The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
    ${ProtectedSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # The name of the extension handler publisher.
    ${Publisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny]
    # Json formatted public settings for the extension.
    ${Setting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # Specifies the type of the extension; an example is "CustomScriptExtension".
    ${Type},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Body')]
    [System.String]
    # Specifies the version of the script handler.
    ${TypeHandlerVersion},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Category('Runtime')]
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
            UpdateExpanded = 'Az.HybridCompute.private\Update-AzHybridComputeMachineExtension_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.HybridCompute.private\Update-AzHybridComputeMachineExtension_UpdateViaIdentityExpanded';
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
