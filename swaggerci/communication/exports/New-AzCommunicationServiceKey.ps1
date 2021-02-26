
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
Regenerate CommunicationService access key.
PrimaryKey and SecondaryKey cannot be regenerated at the same time.
.Description
Regenerate CommunicationService access key.
PrimaryKey and SecondaryKey cannot be regenerated at the same time.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IRegenerateKeyParameters
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.ICommunicationServiceIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.ICommunicationServiceKeys
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICommunicationServiceIdentity>: Identity Parameter
  [CommunicationServiceName <String>]: The name of the CommunicationService resource.
  [Id <String>]: Resource identity path
  [Location <String>]: The Azure region
  [OperationId <String>]: The ID of an ongoing async operation
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: The ID of the target subscription.

PARAMETER <IRegenerateKeyParameters>: Parameters describes the request to regenerate access keys
  [KeyType <KeyType?>]: The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
.Link
https://docs.microsoft.com/en-us/powershell/module/az.communicationservice/new-azcommunicationservicekey
#>
function New-AzCommunicationServiceKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.ICommunicationServiceKeys])]
[CmdletBinding(DefaultParameterSetName='RegenerateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Parameter(ParameterSetName='RegenerateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [System.String]
    # The name of the CommunicationService resource.
    ${CommunicationServiceName},

    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Parameter(ParameterSetName='RegenerateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Regenerate')]
    [Parameter(ParameterSetName='RegenerateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RegenerateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RegenerateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.ICommunicationServiceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Regenerate', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RegenerateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.IRegenerateKeyParameters]
    # Parameters describes the request to regenerate access keys
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='RegenerateExpanded')]
    [Parameter(ParameterSetName='RegenerateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType])]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType]
    # The keyType to regenerate.
    # Must be either 'primary' or 'secondary'(case-insensitive).
    ${KeyType},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Category('Runtime')]
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
            Regenerate = 'Az.CommunicationService.private\New-AzCommunicationServiceKey_Regenerate';
            RegenerateExpanded = 'Az.CommunicationService.private\New-AzCommunicationServiceKey_RegenerateExpanded';
            RegenerateViaIdentity = 'Az.CommunicationService.private\New-AzCommunicationServiceKey_RegenerateViaIdentity';
            RegenerateViaIdentityExpanded = 'Az.CommunicationService.private\New-AzCommunicationServiceKey_RegenerateViaIdentityExpanded';
        }
        if (('Regenerate', 'RegenerateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
