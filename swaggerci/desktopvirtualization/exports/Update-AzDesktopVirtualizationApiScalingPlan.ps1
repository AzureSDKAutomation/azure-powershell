
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
Update a scaling plan.
.Description
Update a scaling plan.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.IDesktopVirtualizationApiIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IScalingPlan
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

HOSTPOOLREFERENCE <IScalingHostPoolReference[]>: List of ScalingHostPoolReference definitions.
  [HostPoolArmPath <String>]: Arm path of referenced hostpool.
  [ScalingPlanEnabled <Boolean?>]: Is the scaling plan enabled for this hostpool.

INPUTOBJECT <IDesktopVirtualizationApiIdentity>: Identity Parameter
  [ApplicationGroupName <String>]: The name of the application group
  [ApplicationName <String>]: The name of the application within the specified application group
  [DesktopName <String>]: The name of the desktop within the specified desktop group
  [HostPoolName <String>]: The name of the host pool within the specified resource group
  [Id <String>]: Resource identity path
  [MsixPackageFullName <String>]: The version specific package full name of the MSIX package within specified hostpool
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScalingPlanName <String>]: The name of the scaling plan.
  [SessionHostName <String>]: The name of the session host within the specified host pool
  [SubscriptionId <String>]: The ID of the target subscription.
  [UserSessionId <String>]: The name of the user session within the specified session host
  [WorkspaceName <String>]: The name of the workspace

SCHEDULE <IScalingSchedule[]>: List of ScalingSchedule definitions.
  [DaysOfWeek <String[]>]: Set of days of the week on which this schedule is active.
  [Name <String>]: Name of the scaling schedule.
  [OffPeakLoadBalancingAlgorithm <SessionHostLoadBalancingAlgorithm?>]: Load balancing algorithm for off-peak period.
  [OffPeakStartTime <DateTime?>]: Starting time for off-peak period.
  [PeakLoadBalancingAlgorithm <SessionHostLoadBalancingAlgorithm?>]: Load balancing algorithm for peak period.
  [PeakStartTime <DateTime?>]: Starting time for peak period.
  [RampDownCapacityThresholdPct <Int32?>]: Capacity threshold for ramp down period.
  [RampDownForceLogoffUser <Boolean?>]: Should users be logged off forcefully from hosts.
  [RampDownLoadBalancingAlgorithm <SessionHostLoadBalancingAlgorithm?>]: Load balancing algorithm for ramp down period.
  [RampDownMinimumHostsPct <Int32?>]: Minimum host percentage for ramp down period.
  [RampDownNotificationMessage <String>]: Notification message for users during ramp down period.
  [RampDownStartTime <DateTime?>]: Starting time for ramp down period.
  [RampDownStopHostsWhen <StopHostsWhen?>]: Specifies when to stop hosts during ramp down period.
  [RampDownWaitTimeMinute <Int32?>]: Number of minutes to wait to stop hosts during ramp down period.
  [RampUpCapacityThresholdPct <Int32?>]: Capacity threshold for ramp up period.
  [RampUpLoadBalancingAlgorithm <SessionHostLoadBalancingAlgorithm?>]: Load balancing algorithm for ramp up period.
  [RampUpMinimumHostsPct <Int32?>]: Minimum host percentage for ramp up period.
  [RampUpStartTime <DateTime?>]: Starting time for ramp up period.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/update-azdesktopvirtualizationapiscalingplan
#>
function Update-AzDesktopVirtualizationApiScalingPlan {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IScalingPlan])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ScalingPlanName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the scaling plan.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.IDesktopVirtualizationApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Description of scaling plan.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Exclusion tag for scaling plan.
    ${ExclusionTag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # User friendly name of scaling plan.
    ${FriendlyName},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IScalingHostPoolReference[]]
    # List of ScalingHostPoolReference definitions.
    # To construct, see NOTES section for HOSTPOOLREFERENCE properties and create a hash table.
    ${HostPoolReference},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType]
    # HostPool type for desktop.
    ${HostPoolType},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IScalingSchedule[]]
    # List of ScalingSchedule definitions.
    # To construct, see NOTES section for SCHEDULE properties and create a hash table.
    ${Schedule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IScalingPlanPatchTags]))]
    [System.Collections.Hashtable]
    # tags to be updated
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # Timezone of the scaling plan.
    ${TimeZone},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Runtime')]
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
            UpdateExpanded = 'Az.DesktopVirtualizationApi.private\Update-AzDesktopVirtualizationApiScalingPlan_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DesktopVirtualizationApi.private\Update-AzDesktopVirtualizationApiScalingPlan_UpdateViaIdentityExpanded';
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
