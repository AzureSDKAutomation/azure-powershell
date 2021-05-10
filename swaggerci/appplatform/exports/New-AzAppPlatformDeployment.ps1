
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
Create a new Deployment or update an exiting Deployment.
.Description
Create a new Deployment or update an exiting Deployment.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentResource
.Link
https://docs.microsoft.com/en-us/powershell/module/az.appplatform/new-azappplatformdeployment
#>
function New-AzAppPlatformDeployment {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the App resource.
    ${AppName},

    [Parameter(Mandatory)]
    [Alias('DeploymentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the Deployment resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [System.String]
    # The name of the Service resource.
    ${ServiceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.Int32]
    # Required CPU.
    # This should be 1 for Basic tier, and in range [1, 4] for Standard tier.
    # This is deprecated starting from API version 2021-06-01-preview.
    # Please use the resourceRequests field to set the CPU size.
    ${DeploymentSettingCpu},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables]))]
    [System.Collections.Hashtable]
    # Collection of environment variables
    ${DeploymentSettingEnvironmentVariable},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # JVM parameter
    ${DeploymentSettingJvmOption},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.Int32]
    # Required Memory size in GB.
    # This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier.
    # This is deprecated starting from API version 2021-06-01-preview.
    # Please use the resourceRequests field to set the the memory size.
    ${DeploymentSettingMemoryInGb},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # The path to the .NET executable relative to zip root
    ${DeploymentSettingNetCoreMainEntryPath},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion]
    # Runtime version
    ${DeploymentSettingRuntimeVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Required CPU.
    # 1 core can be represented by 1 or 1000m.
    # This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4} for Standard tier.
    ${ResourceRequestCpu},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Required memory.
    # 1 GB can be represented by 1Gi or 1024Mi.
    # This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi, 1Gi, 2Gi, ..., 8Gi} for Standard tier.
    ${ResourceRequestMemory},

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
    [System.String]
    # Selector for the artifact to be used for the deployment for multi-module projects.
    # This should bethe relative path to the target module/project.
    ${SourceArtifactSelector},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Relative path of the storage which stores the source
    ${SourceRelativePath},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType]
    # Type of the source uploaded
    ${SourceType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Category('Body')]
    [System.String]
    # Version of the source
    ${SourceVersion},

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
            CreateExpanded = 'Az.AppPlatform.private\New-AzAppPlatformDeployment_CreateExpanded';
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
