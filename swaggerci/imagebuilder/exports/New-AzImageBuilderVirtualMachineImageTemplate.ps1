
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
Create or update a virtual machine image template
.Description
Create or update a virtual machine image template
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplate
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

CUSTOMIZE <IImageTemplateCustomizer[]>: Specifies the properties used to describe the customization steps of the image, like Image source etc
  Type <String>: The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
  [Name <String>]: Friendly Name to provide context on what this customization step does

DISTRIBUTE <IImageTemplateDistributor[]>: The distribution targets where the image output needs to go to.
  RunOutputName <String>: The name to be used for the associated RunOutput.
  Type <String>: Type of distribution.
  [ArtifactTag <IImageTemplateDistributorArtifactTags>]: Tags that will be applied to the artifact once it has been created/updated by the distributor.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.imagebuilder/new-azimagebuildervirtualmachineimagetemplate
#>
function New-AzImageBuilderVirtualMachineImageTemplate {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplate])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Path')]
    [System.String]
    # The name of the image Template
    ${ImageTemplateName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription Id forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.Int32]
    # Maximum duration to wait while building the image template.
    # Omit or specify 0 to use the default (4 hours).
    ${BuildTimeoutInMinute},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplateCustomizer[]]
    # Specifies the properties used to describe the customization steps of the image, like Image source etc
    # To construct, see NOTES section for CUSTOMIZE properties and create a hash table.
    ${Customize},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplateDistributor[]]
    # The distribution targets where the image output needs to go to.
    # To construct, see NOTES section for DISTRIBUTE properties and create a hash table.
    ${Distribute},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Support.ResourceIdentityType]
    # The type of identity used for the image template.
    # The type 'None' will remove any identities from the image template.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplateIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The list of user identities associated with the image template.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.String]
    # Specifies the type of source image you want to start with.
    ${SourceType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.Int32]
    # Size of the OS disk in GB.
    # Omit or specify 0 to use Azure's default OS disk size.
    ${VMProfileOsdiskSizeGb},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.String]
    # Size of the virtual machine used to build, customize and capture images.
    # Omit or specify empty string to use the default (Standard_D1_v2).
    ${VMProfileVmsize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Body')]
    [System.String]
    # Resource id of a pre-existing subnet.
    ${VnetConfigSubnetId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Category('Runtime')]
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
            CreateExpanded = 'Az.ImageBuilder.private\New-AzImageBuilderVirtualMachineImageTemplate_CreateExpanded';
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
