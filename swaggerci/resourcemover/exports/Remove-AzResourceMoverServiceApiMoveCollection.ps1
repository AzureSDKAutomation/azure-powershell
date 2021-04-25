
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
Deletes a move collection.
.Description
Deletes a move collection.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IDiscardRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IOperationStatus
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IDiscardRequest>: Defines the request body for discard operation.
  MoveResource <String[]>: Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property.
  [MoveResourceInputType <MoveResourceInputType?>]: Defines the move resource input type.
  [ValidateOnly <Boolean?>]: Gets or sets a value indicating whether the operation needs to only run pre-requisite.

INPUTOBJECT <IResourceMoverServiceApiIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [MoveCollectionName <String>]: The Move Collection Name.
  [MoveResourceName <String>]: The Move Resource Name.
  [ResourceGroupName <String>]: The Resource Group Name.
  [SubscriptionId <String>]: The Subscription ID.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.resourcemoverserviceapi/remove-azresourcemoverserviceapimovecollection
#>
function Remove-AzResourceMoverServiceApiMoveCollection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IOperationStatus])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Parameter(ParameterSetName='Discard', Mandatory)]
    [Parameter(ParameterSetName='DiscardExpanded', Mandatory)]
    [Alias('MoveCollectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Move Collection Name.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Parameter(ParameterSetName='Discard', Mandatory)]
    [Parameter(ParameterSetName='DiscardExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Resource Group Name.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Parameter(ParameterSetName='Discard')]
    [Parameter(ParameterSetName='DiscardExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Subscription ID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='DiscardViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='DiscardViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Discard', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='DiscardViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IDiscardRequest]
    # Defines the request body for discard operation.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='DiscardExpanded', Mandatory)]
    [Parameter(ParameterSetName='DiscardViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String[]]
    # Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property.
    ${MoveResource},

    [Parameter(ParameterSetName='DiscardExpanded')]
    [Parameter(ParameterSetName='DiscardViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType]
    # Defines the move resource input type.
    ${MoveResourceInputType},

    [Parameter(ParameterSetName='DiscardExpanded')]
    [Parameter(ParameterSetName='DiscardViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Gets or sets a value indicating whether the operation needs to only run pre-requisite.
    ${ValidateOnly},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(ParameterSetName='Delete')]
    [Parameter(ParameterSetName='DeleteViaIdentity')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Delete = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_Delete';
            DeleteViaIdentity = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_DeleteViaIdentity';
            Discard = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_Discard';
            DiscardExpanded = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_DiscardExpanded';
            DiscardViaIdentity = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_DiscardViaIdentity';
            DiscardViaIdentityExpanded = 'Az.ResourceMoverServiceApi.private\Remove-AzResourceMoverServiceApiMoveCollection_DiscardViaIdentityExpanded';
        }
        if (('Delete', 'Discard', 'DiscardExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
