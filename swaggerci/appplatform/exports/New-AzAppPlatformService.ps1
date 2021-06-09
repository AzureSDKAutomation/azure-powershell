
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
Create a new Service or update an exiting Service.
.Description
Create a new Service or update an exiting Service.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IServiceResource
.Link
https://docs.microsoft.com/en-us/powershell/module/az.appplatform/new-azappplatformservice
#>
function New-AzAppPlatformService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IServiceResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the Service resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # The GEO location of the resource.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Name of the resource group containing network resources of Azure Spring Cloud Apps
    ${NetworkProfileAppNetworkResourceGroup},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Fully qualified resource Id of the subnet to host Azure Spring Cloud Apps
    ${NetworkProfileAppSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Azure Spring Cloud service reserved CIDR
    ${NetworkProfileServiceCidr},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Name of the resource group containing network resources of Azure Spring Cloud Service Runtime
    ${NetworkProfileServiceRuntimeNetworkResourceGroup},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Fully qualified resource Id of the subnet to host Azure Spring Cloud Service Runtime
    ${NetworkProfileServiceRuntimeSubnetId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.Int32]
    # Current capacity of the target resource
    ${SkuCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Name of the Sku
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Tier of the Sku
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Tags of the service which is a list of key value pairs that describe the resource.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Runtime')]
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
            CreateExpanded = 'Az.AppPlatform.private\New-AzAppPlatformService_CreateExpanded';
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
