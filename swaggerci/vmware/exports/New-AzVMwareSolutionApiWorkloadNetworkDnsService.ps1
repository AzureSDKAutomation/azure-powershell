
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
Create a DNS service by id in a private cloud workload network.
.Description
Create a DNS service by id in a private cloud workload network.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkDnsService
.Link
https://docs.microsoft.com/en-us/powershell/module/az.vmwaresolutionapi/new-azvmwaresolutionapiworkloadnetworkdnsservice
#>
function New-AzVMwareSolutionApiWorkloadNetworkDnsService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IWorkloadNetworkDnsService])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # NSX DNS Service identifier.
    # Generally the same as the DNS Service's display name
    ${DnsServiceId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # Default DNS zone of the DNS Service.
    ${DefaultDnsZone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # Display name of the DNS Service.
    ${DisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String]
    # DNS service IP of the DNS Service.
    ${DnsServiceIP},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.String[]]
    # FQDN zones of the DNS Service.
    ${FqdnZone},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DnsServiceLogLevelEnum]
    # DNS Service log level.
    ${LogLevel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Category('Body')]
    [System.Int64]
    # NSX revision number.
    ${Revision},

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
            CreateExpanded = 'Az.VMwareSolutionApi.private\New-AzVMwareSolutionApiWorkloadNetworkDnsService_CreateExpanded';
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
