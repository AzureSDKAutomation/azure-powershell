
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
Lists all the available Domain Services operations.
.Description
Lists all the available Domain Services operations.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/get-azdomainservicesdomainserviceoperation
#>
function Get-AzDomainServicesDomainServiceOperation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            List = 'Az.DomainServices.private\Get-AzDomainServicesDomainServiceOperation_List';
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
The Get Domain Service operation retrieves a json representation of the Domain Service.
.Description
The Get Domain Service operation retrieves a json representation of the Domain Service.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/get-azdomainservicesdomainservice
#>
function Get-AzDomainServicesDomainService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('DomainServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            Get = 'Az.DomainServices.private\Get-AzDomainServicesDomainService_Get';
            GetViaIdentity = 'Az.DomainServices.private\Get-AzDomainServicesDomainService_GetViaIdentity';
            List = 'Az.DomainServices.private\Get-AzDomainServicesDomainService_List';
            List1 = 'Az.DomainServices.private\Get-AzDomainServicesDomainService_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Lists all the available OuContainer operations.
.Description
Lists all the available OuContainer operations.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/get-azdomainservicesoucontaineroperation
#>
function Get-AzDomainServicesOuContainerOperation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOperationEntity])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            List = 'Az.DomainServices.private\Get-AzDomainServicesOuContainerOperation_List';
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
Get OuContainer in DomainService instance.
.Description
Get OuContainer in DomainService instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/get-azdomainservicesoucontainer
#>
function Get-AzDomainServicesOuContainer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${DomainServiceName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('OuContainerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the OuContainer.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            Get = 'Az.DomainServices.private\Get-AzDomainServicesOuContainer_Get';
            GetViaIdentity = 'Az.DomainServices.private\Get-AzDomainServicesOuContainer_GetViaIdentity';
            List = 'Az.DomainServices.private\Get-AzDomainServicesOuContainer_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
The Create Domain Service operation creates a new domain service with the specified parameters.
If the specific service already exists, then any patchable properties will be updated and any immutable properties will remain unchanged.
.Description
The Create Domain Service operation creates a new domain service with the specified parameters.
If the specific service already exists, then any patchable properties will be updated and any immutable properties will remain unchanged.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

REPLICASET <IReplicaSet[]>: List of ReplicaSets
  [Location <String>]: Virtual network location
  [SubnetId <String>]: The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.

RESOURCEFORESTSETTING <IForestTrust[]>: List of settings for Resource Forest
  [FriendlyName <String>]: Friendly Name
  [RemoteDnsIP <String>]: Remote Dns ips
  [TrustDirection <String>]: Trust Direction
  [TrustPassword <String>]: Trust Password
  [TrustedDomainFqdn <String>]: Trusted Domain FQDN
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/new-azdomainservicesdomainservice
#>
function New-AzDomainServicesDomainService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('DomainServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Domain Configuration Type
    ${DomainConfigurationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The name of the Azure domain that the user would like to deploy Domain Services to.
    ${DomainName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1]
    # A flag to determine whether or not NtlmV1 is enabled or disabled.
    ${DomainSecuritySettingNtlmV1},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords]
    # A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncKerberosPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords]
    # A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncNtlmPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords]
    # A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncOnPremPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1]
    # A flag to determine whether or not TlsV1 is enabled or disabled.
    ${DomainSecuritySettingTlsV1},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource etag
    ${Etag},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.FilteredSync])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.FilteredSync]
    # Enabled or Disabled flag to turn on Group-based filtered sync
    ${FilteredSync},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.ExternalAccess])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.ExternalAccess]
    # A flag to determine whether or not Secure LDAP access over the internet is enabled or disabled.
    ${LdapSettingExternalAccess},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Ldaps])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Ldaps]
    # A flag to determine whether or not Secure LDAP is enabled or disabled.
    ${LdapSettingLdap},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The certificate required to configure Secure LDAP.
    # The parameter passed here should be a base64encoded representation of the certificate pfx file.
    ${LdapSettingPfxCertificate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The password to decrypt the provided Secure LDAP certificate pfx file.
    ${LdapSettingPfxCertificatePassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String[]]
    # The list of additional recipients
    ${NotificationSettingAdditionalRecipient},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins]
    # Should domain controller admins be notified
    ${NotificationSettingNotifyDcAdmin},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins]
    # Should global admins be notified
    ${NotificationSettingNotifyGlobalAdmin},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IReplicaSet[]]
    # List of ReplicaSets
    # To construct, see NOTES section for REPLICASET properties and create a hash table.
    ${ReplicaSet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IForestTrust[]]
    # List of settings for Resource Forest
    # To construct, see NOTES section for RESOURCEFORESTSETTING properties and create a hash table.
    ${ResourceForestSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource Forest
    ${ResourceForestSettingResourceForest},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Sku Type
    ${Sku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            CreateExpanded = 'Az.DomainServices.private\New-AzDomainServicesDomainService_CreateExpanded';
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
The Create OuContainer operation creates a new OuContainer under the specified Domain Service instance.
.Description
The Create OuContainer operation creates a new OuContainer under the specified Domain Service instance.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/new-azdomainservicesoucontainer
#>
function New-AzDomainServicesOuContainer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${DomainServiceName},

    [Parameter(Mandatory)]
    [Alias('OuContainerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the OuContainer.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account name
    ${AccountName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account password
    ${Password},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account spn
    ${Spn},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            CreateExpanded = 'Az.DomainServices.private\New-AzDomainServicesOuContainer_CreateExpanded';
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
The Delete Domain Service operation deletes an existing Domain Service.
.Description
The Delete Domain Service operation deletes an existing Domain Service.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/remove-azdomainservicesdomainservice
#>
function Remove-AzDomainServicesDomainService {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('DomainServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            Delete = 'Az.DomainServices.private\Remove-AzDomainServicesDomainService_Delete';
            DeleteViaIdentity = 'Az.DomainServices.private\Remove-AzDomainServicesDomainService_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
The Delete OuContainer operation deletes specified OuContainer.
.Description
The Delete OuContainer operation deletes specified OuContainer.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/remove-azdomainservicesoucontainer
#>
function Remove-AzDomainServicesOuContainer {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${DomainServiceName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('OuContainerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the OuContainer.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            Delete = 'Az.DomainServices.private\Remove-AzDomainServicesOuContainer_Delete';
            DeleteViaIdentity = 'Az.DomainServices.private\Remove-AzDomainServicesOuContainer_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
The Update Domain Service operation can be used to update the existing deployment.
The update call only supports the properties listed in the PATCH body.
.Description
The Update Domain Service operation can be used to update the existing deployment.
The update call only supports the properties listed in the PATCH body.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

REPLICASET <IReplicaSet[]>: List of ReplicaSets
  [Location <String>]: Virtual network location
  [SubnetId <String>]: The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.

RESOURCEFORESTSETTING <IForestTrust[]>: List of settings for Resource Forest
  [FriendlyName <String>]: Friendly Name
  [RemoteDnsIP <String>]: Remote Dns ips
  [TrustDirection <String>]: Trust Direction
  [TrustPassword <String>]: Trust Password
  [TrustedDomainFqdn <String>]: Trusted Domain FQDN
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/update-azdomainservicesdomainservice
#>
function Update-AzDomainServicesDomainService {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IDomainService])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('DomainServiceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Domain Configuration Type
    ${DomainConfigurationType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The name of the Azure domain that the user would like to deploy Domain Services to.
    ${DomainName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NtlmV1]
    # A flag to determine whether or not NtlmV1 is enabled or disabled.
    ${DomainSecuritySettingNtlmV1},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncKerberosPasswords]
    # A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncKerberosPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncNtlmPasswords]
    # A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncNtlmPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.SyncOnPremPasswords]
    # A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.
    ${DomainSecuritySettingSyncOnPremPassword},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.TlsV1]
    # A flag to determine whether or not TlsV1 is enabled or disabled.
    ${DomainSecuritySettingTlsV1},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource etag
    ${Etag},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.FilteredSync])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.FilteredSync]
    # Enabled or Disabled flag to turn on Group-based filtered sync
    ${FilteredSync},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.ExternalAccess])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.ExternalAccess]
    # A flag to determine whether or not Secure LDAP access over the internet is enabled or disabled.
    ${LdapSettingExternalAccess},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Ldaps])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Ldaps]
    # A flag to determine whether or not Secure LDAP is enabled or disabled.
    ${LdapSettingLdap},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The certificate required to configure Secure LDAP.
    # The parameter passed here should be a base64encoded representation of the certificate pfx file.
    ${LdapSettingPfxCertificate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The password to decrypt the provided Secure LDAP certificate pfx file.
    ${LdapSettingPfxCertificatePassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String[]]
    # The list of additional recipients
    ${NotificationSettingAdditionalRecipient},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins]
    # Should domain controller admins be notified
    ${NotificationSettingNotifyDcAdmin},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins]
    # Should global admins be notified
    ${NotificationSettingNotifyGlobalAdmin},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IReplicaSet[]]
    # List of ReplicaSets
    # To construct, see NOTES section for REPLICASET properties and create a hash table.
    ${ReplicaSet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IForestTrust[]]
    # List of settings for Resource Forest
    # To construct, see NOTES section for RESOURCEFORESTSETTING properties and create a hash table.
    ${ResourceForestSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Resource Forest
    ${ResourceForestSettingResourceForest},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # Sku Type
    ${Sku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            UpdateExpanded = 'Az.DomainServices.private\Update-AzDomainServicesDomainService_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DomainServices.private\Update-AzDomainServicesDomainService_UpdateViaIdentityExpanded';
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
The Update OuContainer operation can be used to update the existing OuContainers.
.Description
The Update OuContainer operation can be used to update the existing OuContainers.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDomainServicesIdentity>: Identity Parameter
  [DomainServiceName <String>]: The name of the domain service.
  [Id <String>]: Resource identity path
  [OuContainerName <String>]: The name of the OuContainer.
  [ResourceGroupName <String>]: The name of the resource group within the user's subscription. The name is case insensitive.
  [SubscriptionId <String>]: Gets subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.domainservices/update-azdomainservicesoucontainer
#>
function Update-AzDomainServicesOuContainer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api202001.IOuContainer])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the domain service.
    ${DomainServiceName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('OuContainerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the OuContainer.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [System.String]
    # The name of the resource group within the user's subscription.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription credentials which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.IDomainServicesIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account name
    ${AccountName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account password
    ${Password},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [System.String]
    # The account spn
    ${Spn},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Runtime')]
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
            UpdateExpanded = 'Az.DomainServices.private\Update-AzDomainServicesOuContainer_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DomainServices.private\Update-AzDomainServicesOuContainer_UpdateViaIdentityExpanded';
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
