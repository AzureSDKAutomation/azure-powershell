
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
Create a new Kubernetes Cluster Extension Instance.
.Description
Create a new Kubernetes Cluster Extension Instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstance
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

STATUSES <IExtensionStatus[]>: Status from this instance of the extension.
  [Code <String>]: Status code provided by the Extension
  [DisplayStatus <String>]: Short description of status of this instance of the extension.
  [Level <LevelType?>]: Level of the status.
  [Message <String>]: Detailed message of the status from the Extension instance.
  [Time <String>]: DateLiteral (per ISO8601) noting the time of installation status.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.sourcecontrolconfiguration/new-azsourcecontrolconfigurationextension
#>
function New-AzSourceControlConfigurationExtension {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionInstance])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [System.String]
    # The name of the kubernetes cluster.
    ${ClusterName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [System.String]
    # The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
    ${ClusterResourceName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [System.String]
    # The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
    ${ClusterRp},

    [Parameter(Mandatory)]
    [Alias('ExtensionInstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [System.String]
    # Name of an instance of the Extension.
    ${InstanceName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000)
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to note if this instance participates in auto upgrade of minor version, or not.
    ${AutoUpgradeMinorVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.String]
    # Namespace where the extension Release must be placed, for a Cluster scoped extensionInstance.
    # If this namespace does not exist, it will be created
    ${ClusterReleaseNamespace},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionProtectedSettings]))]
    [System.Collections.Hashtable]
    # Configuration settings that are sensitive, as name-value pairs for configuring this instance of the extension.
    ${ConfigurationProtectedSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IConfigurationSettings]))]
    [System.Collections.Hashtable]
    # Configuration settings, as name-value pairs for configuring this instance of the extension.
    ${ConfigurationSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.String]
    # Type of the Extension, of which this resource is an instance of.
    # It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.
    ${ExtensionType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.ResourceIdentityType]
    # The type of identity used for the configuration.
    # Type 'SystemAssigned' will use an implicitly created identity.
    # Type 'None' will not use Managed Identity for the configuration.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.String]
    # Namespace where the extensionInstance will be created for an Namespace scoped extensionInstance.
    # If this namespace does not exist, it will be created
    ${NamespaceTargetNamespace},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.String]
    # ReleaseTrain this extension instance participates in for auto-upgrade (e.g.
    # Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.
    ${ReleaseTrain},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IExtensionStatus[]]
    # Status from this instance of the extension.
    # To construct, see NOTES section for STATUSES properties and create a hash table.
    ${Statuses},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Body')]
    [System.String]
    # Version of the extension for this extension instance, if it is 'pinned' to a specific version.
    # autoUpgradeMinorVersion must be 'false'.
    ${Version},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Category('Runtime')]
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
            CreateExpanded = 'Az.SourceControlConfiguration.private\New-AzSourceControlConfigurationExtension_CreateExpanded';
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
