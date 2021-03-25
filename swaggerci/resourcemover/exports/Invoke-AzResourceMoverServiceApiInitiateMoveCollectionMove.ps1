
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
Moves the set of resources included in the request body.
The move operation is triggered after the moveResources are in the moveState 'MovePending' or 'MoveFailed', on a successful completion the moveResource moveState do a transition to CommitPending.
To aid the user to prerequisite the operation the client can call operation with validateOnly property set to true.
.Description
Moves the set of resources included in the request body.
The move operation is triggered after the moveResources are in the moveState 'MovePending' or 'MoveFailed', on a successful completion the moveResource moveState do a transition to CommitPending.
To aid the user to prerequisite the operation the client can call operation with validateOnly property set to true.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IResourceMoveRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IOperationStatus
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IResourceMoveRequest>: Defines the request body for resource move operation.
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
https://docs.microsoft.com/en-us/powershell/module/az.resourcemoverserviceapi/invoke-azresourcemoverserviceapiinitiatemovecollectionmove
#>
function Invoke-AzResourceMoverServiceApiInitiateMoveCollectionMove {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IOperationStatus])]
[CmdletBinding(DefaultParameterSetName='InitiateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Initiate', Mandatory)]
    [Parameter(ParameterSetName='InitiateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Move Collection Name.
    ${MoveCollectionName},

    [Parameter(ParameterSetName='Initiate', Mandatory)]
    [Parameter(ParameterSetName='InitiateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Resource Group Name.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Initiate')]
    [Parameter(ParameterSetName='InitiateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Subscription ID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='InitiateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='InitiateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.IResourceMoverServiceApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Initiate', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='InitiateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IResourceMoveRequest]
    # Defines the request body for resource move operation.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='InitiateExpanded', Mandatory)]
    [Parameter(ParameterSetName='InitiateViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String[]]
    # Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property.
    ${MoveResource},

    [Parameter(ParameterSetName='InitiateExpanded')]
    [Parameter(ParameterSetName='InitiateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType]
    # Defines the move resource input type.
    ${MoveResourceInputType},

    [Parameter(ParameterSetName='InitiateExpanded')]
    [Parameter(ParameterSetName='InitiateViaIdentityExpanded')]
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
            Initiate = 'Az.ResourceMoverServiceApi.private\Invoke-AzResourceMoverServiceApiInitiateMoveCollectionMove_Initiate';
            InitiateExpanded = 'Az.ResourceMoverServiceApi.private\Invoke-AzResourceMoverServiceApiInitiateMoveCollectionMove_InitiateExpanded';
            InitiateViaIdentity = 'Az.ResourceMoverServiceApi.private\Invoke-AzResourceMoverServiceApiInitiateMoveCollectionMove_InitiateViaIdentity';
            InitiateViaIdentityExpanded = 'Az.ResourceMoverServiceApi.private\Invoke-AzResourceMoverServiceApiInitiateMoveCollectionMove_InitiateViaIdentityExpanded';
        }
        if (('Initiate', 'InitiateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
