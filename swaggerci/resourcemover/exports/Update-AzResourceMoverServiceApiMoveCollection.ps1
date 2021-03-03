
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
Updates a move collection.
.Description
Updates a move collection.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveCollection
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IResourceMoverServiceApiIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [MoveCollectionName <String>]: The Move Collection Name.
  [MoveResourceName <String>]: The Move Resource Name.
  [ResourceGroupName <String>]: The Resource Group Name.
  [SubscriptionId <String>]: The Subscription ID.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.resourcemoverserviceapi/update-azresourcemoverserviceapimovecollection
#>
function Update-AzResourceMoverServiceApiMoveCollection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveCollection])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('MoveCollectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Move Collection Name.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Resource Group Name.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Subscription ID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String]
    # Gets or sets the principal id.
    ${IdentityPrincipalId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String]
    # Gets or sets the tenant id.
    ${IdentityTenantId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.ResourceIdentityType]
    # The type of identity used for the resource mover service.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IUpdateMoveCollectionRequestTags]))]
    [System.Collections.Hashtable]
    # Gets or sets the Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
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
            UpdateExpanded = 'Az.ResourceMoverServiceApi.private\Update-AzResourceMoverServiceApiMoveCollection_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.ResourceMoverServiceApi.private\Update-AzResourceMoverServiceApiMoveCollection_UpdateViaIdentityExpanded';
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
