
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
Lists the available consortiums for a subscription.
.Description
Lists the available consortiums for a subscription.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IConsortium
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainlocationconsortium
#>
function Get-AzBlockchainLocationConsortium {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IConsortium])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Location Name.
    ${LocationName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainLocationConsortium_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Lists the API keys for a blockchain member.
.Description
Lists the API keys for a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmemberapikey
#>
function Get-AzBlockchainMemberApiKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainMemberApiKey_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Lists the consortium members for a blockchain member.
.Description
Lists the consortium members for a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IConsortiumMember
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmemberconsortiummember
#>
function Get-AzBlockchainMemberConsortiumMember {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IConsortiumMember])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainMemberConsortiumMember_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Get Async operation result.
.Description
Get Async operation result.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IOperationResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmemberoperationresult
#>
function Get-AzBlockchainMemberOperationResult {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IOperationResult])]
[CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Location name.
    ${LocationName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Operation Id.
    ${OperationId},

    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Get = 'Az.Blockchain.private\Get-AzBlockchainMemberOperationResult_Get';
            GetViaIdentity = 'Az.Blockchain.private\Get-AzBlockchainMemberOperationResult_GetViaIdentity';
        }
        if (('Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Regenerate the API keys for a blockchain member.
.Description
Regenerate the API keys for a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

APIKEY <IApiKey>: API key payload which is exposed in the request/response of the resource provider.
  [KeyName <String>]: Gets or sets the API key name.
  [Value <String>]: Gets or sets the API key value.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmemberregenerateapikey
#>
function Get-AzBlockchainMemberRegenerateApiKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='ListExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='List', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey]
    # API key payload which is exposed in the request/response of the resource provider.
    # To construct, see NOTES section for APIKEY properties and create a hash table.
    ${ApiKey},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key name.
    ${KeyName},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key value.
    ${Value},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainMemberRegenerateApiKey_List';
            ListExpanded = 'Az.Blockchain.private\Get-AzBlockchainMemberRegenerateApiKey_ListExpanded';
        }
        if (('List', 'ListExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Get details about a blockchain member.
.Description
Get details about a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainmember
#>
function Get-AzBlockchainMember {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember])]
[CmdletBinding(DefaultParameterSetName='List1', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('BlockchainMemberName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Get = 'Az.Blockchain.private\Get-AzBlockchainMember_Get';
            GetViaIdentity = 'Az.Blockchain.private\Get-AzBlockchainMember_GetViaIdentity';
            List = 'Az.Blockchain.private\Get-AzBlockchainMember_List';
            List1 = 'Az.Blockchain.private\Get-AzBlockchainMember_List1';
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
Lists the Skus of the resource type.
.Description
Lists the Skus of the resource type.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IResourceTypeSku
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchainsku
#>
function Get-AzBlockchainSku {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IResourceTypeSku])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainSku_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
List the API keys for the transaction node.
.Description
List the API keys for the transaction node.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchaintransactionnodeapikey
#>
function Get-AzBlockchainTransactionNodeApiKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${TransactionNodeName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainTransactionNodeApiKey_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Regenerate the API keys for the blockchain member.
.Description
Regenerate the API keys for the blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

APIKEY <IApiKey>: API key payload which is exposed in the request/response of the resource provider.
  [KeyName <String>]: Gets or sets the API key name.
  [Value <String>]: Gets or sets the API key value.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchaintransactionnoderegenerateapikey
#>
function Get-AzBlockchainTransactionNodeRegenerateApiKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='ListExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${TransactionNodeName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='List', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IApiKey]
    # API key payload which is exposed in the request/response of the resource provider.
    # To construct, see NOTES section for APIKEY properties and create a hash table.
    ${ApiKey},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key name.
    ${KeyName},

    [Parameter(ParameterSetName='ListExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the API key value.
    ${Value},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            List = 'Az.Blockchain.private\Get-AzBlockchainTransactionNodeRegenerateApiKey_List';
            ListExpanded = 'Az.Blockchain.private\Get-AzBlockchainTransactionNodeRegenerateApiKey_ListExpanded';
        }
        if (('List', 'ListExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
Get the details of the transaction node.
.Description
Get the details of the transaction node.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/get-azblockchaintransactionnode
#>
function Get-AzBlockchainTransactionNode {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('TransactionNodeName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Get = 'Az.Blockchain.private\Get-AzBlockchainTransactionNode_Get';
            GetViaIdentity = 'Az.Blockchain.private\Get-AzBlockchainTransactionNode_GetViaIdentity';
            List = 'Az.Blockchain.private\Get-AzBlockchainTransactionNode_List';
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
Create a blockchain member.
.Description
Create a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FIREWALLRULE <IFirewallRule[]>: Gets or sets firewall rules
  [EndIPAddress <String>]: Gets or sets the end IP address of the firewall rule range.
  [RuleName <String>]: Gets or sets the name of the firewall rules.
  [StartIPAddress <String>]: Gets or sets the start IP address of the firewall rule range.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/new-azblockchainmember
#>
function New-AzBlockchainMember {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('BlockchainMemberName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the consortium for the blockchain member.
    ${Consortium},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the managed consortium management account password.
    ${ConsortiumManagementAccountPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets the display name of the member in the consortium.
    ${ConsortiumMemberDisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets the role of the member in the consortium.
    ${ConsortiumRole},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IFirewallRule[]]
    # Gets or sets firewall rules
    # To construct, see NOTES section for FIREWALLRULE properties and create a hash table.
    ${FirewallRule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # The GEO location of the blockchain service.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the basic auth password of the blockchain member.
    ${Password},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainProtocol])]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.BlockchainProtocol]
    # Gets or sets the blockchain protocol.
    ${Protocol},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets Sku name
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets Sku tier
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Tags of the service which is a list of key value pairs that describes the resource.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.Int32]
    # Gets or sets the nodes capacity.
    ${ValidatorNodeSkuCapacity},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            CreateExpanded = 'Az.Blockchain.private\New-AzBlockchainMember_CreateExpanded';
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
Create or update the transaction node.
.Description
Create or update the transaction node.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FIREWALLRULE <IFirewallRule[]>: Gets or sets the firewall rules.
  [EndIPAddress <String>]: Gets or sets the end IP address of the firewall rule range.
  [RuleName <String>]: Gets or sets the name of the firewall rules.
  [StartIPAddress <String>]: Gets or sets the start IP address of the firewall rule range.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/new-azblockchaintransactionnode
#>
function New-AzBlockchainTransactionNode {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(Mandatory)]
    [Alias('TransactionNodeName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IFirewallRule[]]
    # Gets or sets the firewall rules.
    # To construct, see NOTES section for FIREWALLRULE properties and create a hash table.
    ${FirewallRule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the transaction node location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the transaction node dns endpoint basic auth password.
    ${Password},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            CreateExpanded = 'Az.Blockchain.private\New-AzBlockchainTransactionNode_CreateExpanded';
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
Delete a blockchain member.
.Description
Delete a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/remove-azblockchainmember
#>
function Remove-AzBlockchainMember {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('BlockchainMemberName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Delete = 'Az.Blockchain.private\Remove-AzBlockchainMember_Delete';
            DeleteViaIdentity = 'Az.Blockchain.private\Remove-AzBlockchainMember_DeleteViaIdentity';
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
Delete the transaction node.
.Description
Delete the transaction node.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/remove-azblockchaintransactionnode
#>
function Remove-AzBlockchainTransactionNode {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('TransactionNodeName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Delete = 'Az.Blockchain.private\Remove-AzBlockchainTransactionNode_Delete';
            DeleteViaIdentity = 'Az.Blockchain.private\Remove-AzBlockchainTransactionNode_DeleteViaIdentity';
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
To check whether a resource name is available.
.Description
To check whether a resource name is available.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.INameAvailabilityRequest
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.INameAvailability
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.

NAMEAVAILABILITYREQUEST <INameAvailabilityRequest>: Name availability request payload which is exposed in the request of the resource provider.
  [Name <String>]: Gets or sets the name to check.
  [Type <String>]: Gets or sets the type of the resource to check.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/test-azblockchainlocationnameavailability
#>
function Test-AzBlockchainLocationNameAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.INameAvailability])]
[CmdletBinding(DefaultParameterSetName='CheckExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Check', Mandatory)]
    [Parameter(ParameterSetName='CheckExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Location Name.
    ${LocationName},

    [Parameter(ParameterSetName='Check')]
    [Parameter(ParameterSetName='CheckExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CheckViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CheckViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Check', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CheckViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.INameAvailabilityRequest]
    # Name availability request payload which is exposed in the request of the resource provider.
    # To construct, see NOTES section for NAMEAVAILABILITYREQUEST properties and create a hash table.
    ${NameAvailabilityRequest},

    [Parameter(ParameterSetName='CheckExpanded')]
    [Parameter(ParameterSetName='CheckViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the name to check.
    ${Name},

    [Parameter(ParameterSetName='CheckExpanded')]
    [Parameter(ParameterSetName='CheckViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Gets or sets the type of the resource to check.
    ${Type},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            Check = 'Az.Blockchain.private\Test-AzBlockchainLocationNameAvailability_Check';
            CheckExpanded = 'Az.Blockchain.private\Test-AzBlockchainLocationNameAvailability_CheckExpanded';
            CheckViaIdentity = 'Az.Blockchain.private\Test-AzBlockchainLocationNameAvailability_CheckViaIdentity';
            CheckViaIdentityExpanded = 'Az.Blockchain.private\Test-AzBlockchainLocationNameAvailability_CheckViaIdentityExpanded';
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
Update a blockchain member.
.Description
Update a blockchain member.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FIREWALLRULE <IFirewallRule[]>: Gets or sets the firewall rules.
  [EndIPAddress <String>]: Gets or sets the end IP address of the firewall rule range.
  [RuleName <String>]: Gets or sets the name of the firewall rules.
  [StartIPAddress <String>]: Gets or sets the start IP address of the firewall rule range.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/update-azblockchainmember
#>
function Update-AzBlockchainMember {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMember])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('BlockchainMemberName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the managed consortium management account password.
    ${ConsortiumManagementAccountPassword},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IFirewallRule[]]
    # Gets or sets the firewall rules.
    # To construct, see NOTES section for FIREWALLRULE properties and create a hash table.
    ${FirewallRule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the transaction node dns endpoint basic auth password.
    ${Password},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IBlockchainMemberUpdateTags]))]
    [System.Collections.Hashtable]
    # Tags of the service which is a list of key value pairs that describes the resource.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            UpdateExpanded = 'Az.Blockchain.private\Update-AzBlockchainMember_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.Blockchain.private\Update-AzBlockchainMember_UpdateViaIdentityExpanded';
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
Update the transaction node.
.Description
Update the transaction node.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FIREWALLRULE <IFirewallRule[]>: Gets or sets the firewall rules.
  [EndIPAddress <String>]: Gets or sets the end IP address of the firewall rule range.
  [RuleName <String>]: Gets or sets the name of the firewall rules.
  [StartIPAddress <String>]: Gets or sets the start IP address of the firewall rule range.

INPUTOBJECT <IBlockchainIdentity>: Identity Parameter
  [BlockchainMemberName <String>]: Blockchain member name.
  [Id <String>]: Resource identity path
  [LocationName <String>]: Location name.
  [OperationId <String>]: Operation Id.
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SubscriptionId <String>]: Gets the subscription Id which uniquely identifies the Microsoft Azure subscription. The subscription ID is part of the URI for every service call.
  [TransactionNodeName <String>]: Transaction node name.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.blockchain/update-azblockchaintransactionnode
#>
function Update-AzBlockchainTransactionNode {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.ITransactionNode])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Blockchain member name.
    ${BlockchainMemberName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('TransactionNodeName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # Transaction node name.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets the subscription Id which uniquely identifies the Microsoft Azure subscription.
    # The subscription ID is part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.IBlockchainIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Models.Api20180601Preview.IFirewallRule[]]
    # Gets or sets the firewall rules.
    # To construct, see NOTES section for FIREWALLRULE properties and create a hash table.
    ${FirewallRule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Body')]
    [System.String]
    # Sets the transaction node dns endpoint basic auth password.
    ${Password},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Category('Runtime')]
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
            UpdateExpanded = 'Az.Blockchain.private\Update-AzBlockchainTransactionNode_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.Blockchain.private\Update-AzBlockchainTransactionNode_UpdateViaIdentityExpanded';
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
