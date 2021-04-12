
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
Check if a Windows IoT Device Service name is available.
.Description
Check if a Windows IoT Device Service name is available.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceCheckNameAvailabilityParameters
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.IDeviceServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceNameAvailabilityInfo
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DEVICESERVICECHECKNAMEAVAILABILITYPARAMETER <IDeviceServiceCheckNameAvailabilityParameters>: Input values.
  Name <String>: The name of the Windows IoT Device Service to check.

INPUTOBJECT <IDeviceServicesIdentity>: Identity Parameter
  [DeviceName <String>]: The name of the Windows IoT Device Service.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group that contains the Windows IoT Device Service.
  [SubscriptionId <String>]: The subscription identifier.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.deviceservices/test-azdeviceservicesservicedeviceservicenameavailability
#>
function Test-AzDeviceServicesServiceDeviceServiceNameAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceNameAvailabilityInfo])]
[CmdletBinding(DefaultParameterSetName='CheckExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Check')]
    [Parameter(ParameterSetName='CheckExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription identifier.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CheckViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CheckViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.IDeviceServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Check', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CheckViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceCheckNameAvailabilityParameters]
    # Input values.
    # To construct, see NOTES section for DEVICESERVICECHECKNAMEAVAILABILITYPARAMETER properties and create a hash table.
    ${DeviceServiceCheckNameAvailabilityParameter},

    [Parameter(ParameterSetName='CheckExpanded', Mandatory)]
    [Parameter(ParameterSetName='CheckViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Body')]
    [System.String]
    # The name of the Windows IoT Device Service to check.
    ${Name},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category('Runtime')]
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
            Check = 'Az.DeviceServices.private\Test-AzDeviceServicesServiceDeviceServiceNameAvailability_Check';
            CheckExpanded = 'Az.DeviceServices.private\Test-AzDeviceServicesServiceDeviceServiceNameAvailability_CheckExpanded';
            CheckViaIdentity = 'Az.DeviceServices.private\Test-AzDeviceServicesServiceDeviceServiceNameAvailability_CheckViaIdentity';
            CheckViaIdentityExpanded = 'Az.DeviceServices.private\Test-AzDeviceServicesServiceDeviceServiceNameAvailability_CheckViaIdentityExpanded';
        }
        if (('Check', 'CheckExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
