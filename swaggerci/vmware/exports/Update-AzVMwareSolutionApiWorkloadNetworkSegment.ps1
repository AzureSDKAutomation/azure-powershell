
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
Create or update a segment by id in a private cloud workload network.
.Description
Create or update a segment by id in a private cloud workload network.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.IVMwareSolutionApiIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkSegment
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareSolutionApiIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: NSX Virtual Machine identifier.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.vmwaresolutionapi/update-azvmwaresolutionapiworkloadnetworksegment
#>
function Update-AzVMwareSolutionApiWorkloadNetworkSegment {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api202101Preview.IWorkloadNetworkSegment])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # NSX Segment identifier.
    # Generally the same as the Segment's display name
    ${SegmentId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.IVMwareSolutionApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # Gateway which to connect segment to.
    ${ConnectedGateway},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # Display name of the segment.
    ${DisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.Int64]
    # NSX revision number.
    ${Revision},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String[]]
    # DHCP Range assigned for subnet.
    ${SubnetDhcpRange},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # Gateway address.
    ${SubnetGatewayAddress},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Runtime')]
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
            UpdateExpanded = 'Az.VMwareSolutionApi.private\Update-AzVMwareSolutionApiWorkloadNetworkSegment_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.VMwareSolutionApi.private\Update-AzVMwareSolutionApiWorkloadNetworkSegment_UpdateViaIdentityExpanded';
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
