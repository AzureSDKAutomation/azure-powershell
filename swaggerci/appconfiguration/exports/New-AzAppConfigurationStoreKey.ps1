
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
Regenerates an access key for the specified configuration store.
.Description
Regenerates an access key for the specified configuration store.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IRegenerateKeyParameters
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IAppConfigurationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IApiKey
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAppConfigurationIdentity>: Identity Parameter
  [ConfigStoreName <String>]: The name of the configuration store.
  [GroupName <String>]: The name of the private link resource group.
  [Id <String>]: Resource identity path
  [KeyValueName <String>]: Identifier of key and label combination. Key and label are joined by $ character. Label is optional.
  [PrivateEndpointConnectionName <String>]: Private endpoint connection name
  [ResourceGroupName <String>]: The name of the resource group to which the container registry belongs.
  [SubscriptionId <String>]: The Microsoft Azure subscription ID.

REGENERATEKEYPARAMETER <IRegenerateKeyParameters>: The parameters used to regenerate an API key.
  [Id <String>]: The id of the key to regenerate.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.appconfiguration/new-azappconfigurationstorekey
#>
function New-AzAppConfigurationStoreKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IApiKey])]
[CmdletBinding(DefaultParameterSetName='RegenerateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Parameter(ParameterSetName='RegenerateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Path')]
    [System.String]
    # The name of the configuration store.
    ${ConfigStoreName},

    [Parameter(ParameterSetName='Regenerate', Mandatory)]
    [Parameter(ParameterSetName='RegenerateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Path')]
    [System.String]
    # The name of the resource group to which the container registry belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Regenerate')]
    [Parameter(ParameterSetName='RegenerateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Microsoft Azure subscription ID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RegenerateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RegenerateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IAppConfigurationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Regenerate', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='RegenerateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IRegenerateKeyParameters]
    # The parameters used to regenerate an API key.
    # To construct, see NOTES section for REGENERATEKEYPARAMETER properties and create a hash table.
    ${RegenerateKeyParameter},

    [Parameter(ParameterSetName='RegenerateExpanded')]
    [Parameter(ParameterSetName='RegenerateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Body')]
    [System.String]
    # The id of the key to regenerate.
    ${Id},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category('Runtime')]
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
            Regenerate = 'Az.AppConfiguration.private\New-AzAppConfigurationStoreKey_Regenerate';
            RegenerateExpanded = 'Az.AppConfiguration.private\New-AzAppConfigurationStoreKey_RegenerateExpanded';
            RegenerateViaIdentity = 'Az.AppConfiguration.private\New-AzAppConfigurationStoreKey_RegenerateViaIdentity';
            RegenerateViaIdentityExpanded = 'Az.AppConfiguration.private\New-AzAppConfigurationStoreKey_RegenerateViaIdentityExpanded';
        }
        if (('Regenerate', 'RegenerateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
