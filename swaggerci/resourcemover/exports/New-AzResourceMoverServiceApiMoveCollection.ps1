
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
Creates or updates a move collection.
.Description
Creates or updates a move collection.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveCollection
.Link
https://docs.microsoft.com/en-us/powershell/module/az.resourcemoverserviceapi/new-azresourcemoverserviceapimovecollection
#>
function New-AzResourceMoverServiceApiMoveCollection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveCollection])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('MoveCollectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Move Collection Name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [System.String]
    # The Resource Group Name.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Subscription ID.
    ${SubscriptionId},

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
    [System.String]
    # The geo-location where the resource lives.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String]
    # Gets or sets the source region.
    ${SourceRegion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveCollectionTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Category('Body')]
    [System.String]
    # Gets or sets the target region.
    ${TargetRegion},

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
            CreateExpanded = 'Az.ResourceMoverServiceApi.private\New-AzResourceMoverServiceApiMoveCollection_CreateExpanded';
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
