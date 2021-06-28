
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
Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IDomainService
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

CONFIGDIAGNOSTICVALIDATORRESULT <IConfigDiagnosticsValidatorResult[]>: List of Configuration Diagnostics validator results.
  [Issue <IConfigDiagnosticsValidatorResultIssue[]>]: List of resource config validation issues.
    [DescriptionParam <String[]>]: List of domain resource property name or values used to compose a rich description.
    [Id <String>]: Validation issue identifier.
  [ReplicaSetSubnetDisplayName <String>]: Replica set location and subnet name
  [Status <Status?>]: Status for individual validator after running diagnostics.
  [ValidatorId <String>]: Validator identifier

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
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IDomainService])]
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
    [System.DateTime]
    # Last domain configuration diagnostics DateTime
    ${ConfigDiagnosticLastExecuted},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult[]]
    # List of Configuration Diagnostics validator results.
    # To construct, see NOTES section for CONFIGDIAGNOSTICVALIDATORRESULT properties and create a hash table.
    ${ConfigDiagnosticValidatorResult},

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
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosArmoring]
    # A flag to determine whether or not KerberosArmoring is enabled or disabled.
    ${DomainSecuritySettingKerberosArmoring},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption])]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.KerberosRc4Encryption]
    # A flag to determine whether or not KerberosRc4Encryption is enabled or disabled.
    ${DomainSecuritySettingKerberosRc4Encryption},

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
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IReplicaSet[]]
    # List of ReplicaSets
    # To construct, see NOTES section for REPLICASET properties and create a hash table.
    ${ReplicaSet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IForestTrust[]]
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
    [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IResourceTags]))]
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
