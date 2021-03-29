
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
Creates a SAP monitor for the specified subscription, resource group, and resource name.
.Description
Creates a SAP monitor for the specified subscription, resource group, and resource name.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ISapMonitor
.Link
https://docs.microsoft.com/en-us/powershell/module/az.hana/new-azhanasapmonitor
#>
function New-AzHanaSapMonitor {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api20200207Preview.ISapMonitor])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('SapMonitorName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Path')]
    [System.String]
    # Name of the SAP monitor resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Path')]
    [System.String]
    # Name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription ID which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # The value indicating whether to send analytics to Microsoft
    ${EnableCustomerAnalytic},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.String]
    # The ARM ID of the Log Analytics Workspace that is used for monitoring
    ${LogAnalyticsWorkspaceArmId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.String]
    # The workspace ID of the log analytics workspace to be used for monitoring
    ${LogAnalyticsWorkspaceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.String]
    # The shared key of the log analytics workspace that is used for monitoring
    ${LogAnalyticsWorkspaceSharedKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [System.String]
    # The subnet which the SAP monitor will be deployed in
    ${MonitorSubnet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Hana.Models.Api10.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Hana.Category('Runtime')]
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
            CreateExpanded = 'Az.Hana.private\New-AzHanaSapMonitor_CreateExpanded';
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
