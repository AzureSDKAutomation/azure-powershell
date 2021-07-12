
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
Create or update a SessionHostConfiguration.
.Description
Create or update a SessionHostConfiguration.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfiguration
.Link
https://docs.microsoft.com/en-us/powershell/module/az.desktopvirtualizationapi/new-azdesktopvirtualizationapisessionhostconfiguration
#>
function New-AzDesktopVirtualizationApiSessionHostConfiguration {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostConfiguration])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the host pool within the specified resource group
    ${HostPoolName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.VirtualMachineDiskType]
    # The disk type used by virtual machine in hostpool session host.
    ${DiskType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The keyvault resource id to the keyvault secrets.
    ${DomainAdminPasswordKeyVaultResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The keyvault secret name the password is stored in.
    ${DomainAdminPasswordSecretName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The user name to the account.
    ${DomainAdminUserName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DomainJoinType]
    # The type of domain join done by the virtual machine.
    ${DomainInfoJoinType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The MDM Provider GUID used during MDM enrollment for Azure AD joined virtual machines.
    ${DomainInfoMdmProviderGuid},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The domain a virtual machine connected to a hostpool will join.
    ${DomainInfoName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The resource id of the custom image or shared image.
    # Image type must be CustomImage.
    ${ImageInfoCustomId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The uri to the storage blob which contains the VHD.
    # Image type must be StorageBlob.
    ${ImageInfoStorageBlobUri},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType]
    # The type of image session hosts use in the hostpool.
    ${ImageInfoType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The keyvault resource id to the keyvault secrets.
    ${LocalAdminPasswordKeyVaultResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The keyvault secret name the password is stored in.
    ${LocalAdminPasswordSecretName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The user name to the account.
    ${LocalAdminUserName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The exact version of the image.
    ${MarketPlaceInfoExactVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The offer of the image.
    ${MarketPlaceInfoOffer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The publisher of the image.
    ${MarketPlaceInfoPublisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The sku of the image.
    ${MarketPlaceInfoSku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The uri to the storage blob containing scripts to be run on the virtual machine after provisioning.
    ${VMCustomConfigurationUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category('Body')]
    [System.String]
    # The id of the size of a virtual machine connected to a hostpool.
    ${VMSizeId},

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
            CreateExpanded = 'Az.DesktopVirtualizationApi.private\New-AzDesktopVirtualizationApiSessionHostConfiguration_CreateExpanded';
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
