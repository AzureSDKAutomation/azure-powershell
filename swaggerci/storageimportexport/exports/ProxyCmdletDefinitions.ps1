
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
Returns the BitLocker Keys for all drives in the specified job.
.Description
Returns the BitLocker Keys for all drives in the specified job.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveBitLockerKey
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/get-azstorageimportexportbitlockerkey
#>
function Get-AzStorageImportExportBitLockerKey {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveBitLockerKey])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the import/export job.
    ${JobName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The resource group name uniquely identifies the resource group within the user subscription.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The subscription ID for the Azure user.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            List = 'Az.StorageImportExport.private\Get-AzStorageImportExportBitLockerKey_List';
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
Gets information about an existing job.
.Description
Gets information about an existing job.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IStorageImportExportIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [JobName <String>]: The name of the import/export job.
  [LocationName <String>]: The name of the location. For example, West US or westus.
  [ResourceGroupName <String>]: The resource group name uniquely identifies the resource group within the user subscription.
  [SubscriptionId <String>]: The subscription ID for the Azure user.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/get-azstorageimportexportjob
#>
function Get-AzStorageImportExportJob {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('JobName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the import/export job.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List1', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The resource group name uniquely identifies the resource group within the user subscription.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The subscription ID for the Azure user.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Query')]
    [System.String]
    # Can be used to restrict the results to certain conditions.
    ${Filter},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Query')]
    [System.Int32]
    # An integer value that specifies how many jobs at most should be returned.
    # The value cannot exceed 100.
    ${Top},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            Get = 'Az.StorageImportExport.private\Get-AzStorageImportExportJob_Get';
            GetViaIdentity = 'Az.StorageImportExport.private\Get-AzStorageImportExportJob_GetViaIdentity';
            List = 'Az.StorageImportExport.private\Get-AzStorageImportExportJob_List';
            List1 = 'Az.StorageImportExport.private\Get-AzStorageImportExportJob_List1';
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
Returns the details about a location to which you can ship the disks associated with an import or export job.
A location is an Azure region.
.Description
Returns the details about a location to which you can ship the disks associated with an import or export job.
A location is an Azure region.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IStorageImportExportIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [JobName <String>]: The name of the import/export job.
  [LocationName <String>]: The name of the location. For example, West US or westus.
  [ResourceGroupName <String>]: The resource group name uniquely identifies the resource group within the user subscription.
  [SubscriptionId <String>]: The subscription ID for the Azure user.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/get-azstorageimportexportlocation
#>
function Get-AzStorageImportExportLocation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ILocation])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('LocationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the location.
    # For example, West US or westus.
    ${Name},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            Get = 'Az.StorageImportExport.private\Get-AzStorageImportExportLocation_Get';
            GetViaIdentity = 'Az.StorageImportExport.private\Get-AzStorageImportExportLocation_GetViaIdentity';
            List = 'Az.StorageImportExport.private\Get-AzStorageImportExportLocation_List';
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
Creates a new job or updates an existing job in the specified subscription.
.Description
Creates a new job or updates an existing job in the specified subscription.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DRIVELIST <IDriveStatus[]>: List of up to ten drives that comprise the job. The drive list is a required element for an import job; it is not specified for export jobs.
  [BitLockerKey <String>]: The BitLocker key used to encrypt the drive.
  [BytesSucceeded <Int64?>]: Bytes successfully transferred for the drive.
  [CopyStatus <String>]: Detailed status about the data transfer process. This field is not returned in the response until the drive is in the Transferring state.
  [DriveHeaderHash <String>]: The drive header hash value.
  [DriveId <String>]: The drive's hardware serial number, without spaces.
  [ErrorLogUri <String>]: A URI that points to the blob containing the error log for the data transfer operation.
  [ManifestFile <String>]: The relative path of the manifest file on the drive. 
  [ManifestHash <String>]: The Base16-encoded MD5 hash of the manifest file on the drive.
  [ManifestUri <String>]: A URI that points to the blob containing the drive manifest file. 
  [PercentComplete <Int64?>]: Percentage completed for the drive. 
  [State <DriveState?>]: The drive's current state. 
  [VerboseLogUri <String>]: A URI that points to the blob containing the verbose log for the data transfer operation. 
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/new-azstorageimportexportjob
#>
function New-AzStorageImportExportJob {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('JobName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the import/export job.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The resource group name uniquely identifies the resource group within the user subscription.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription ID for the Azure user.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # The tenant ID of the client making the request.
    ${ClientTenantId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Default value is false.
    # Indicates whether the manifest files on the drives should be copied to block blobs.
    ${BackupDriveManifest},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String[]]
    # A collection of blob-prefix strings.
    ${BlobListBlobPathPrefix},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String[]]
    # A collection of blob-path strings.
    ${BlobPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether a request has been submitted to cancel the job.
    ${CancelRequested},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the carrier that is used to ship the import or export drives.
    ${DeliveryPackageCarrierName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Int64]
    # The number of drives included in the package.
    ${DeliveryPackageDriveCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The date when the package is shipped.
    ${DeliveryPackageShipDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The tracking number of the package.
    ${DeliveryPackageTrackingNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The virtual blob directory to which the copy logs and backups of drive manifest files (if enabled) will be stored.
    ${DiagnosticsPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[]]
    # List of up to ten drives that comprise the job.
    # The drive list is a required element for an import job; it is not specified for export jobs.
    # To construct, see NOTES section for DRIVELIST properties and create a hash table.
    ${DriveList},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType])]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Support.EncryptionKekType]
    # The type of kek encryption key
    ${EncryptionKeyKekType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Specifies the url for kek encryption key.
    ${EncryptionKeyKekUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Specifies the keyvault resource id for kek encryption key.
    ${EncryptionKeyKekVaultResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The relative URI to the block blob that contains the list of blob paths or blob path prefixes as defined above, beginning with the container name.
    # If the blob is in root container, the URI must begin with $root.
    ${ExportBlobListBlobPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # A blob path that points to a block blob containing a list of blob names that were not exported due to insufficient drive space.
    # If all blobs were exported successfully, then this element is not included in the response.
    ${IncompleteBlobListUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The type of job
    ${JobType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Specifies the supported Azure location where the job should be created
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Default value is Error.
    # Indicates whether error logging or verbose logging will be enabled.
    ${LogLevel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Int32]
    # Overall percentage completed for the job.
    ${PercentComplete},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Specifies the provisioning state of the job.
    ${ProvisioningState},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The city name to use when returning the drives.
    ${ReturnAddressCity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The country or region to use when returning the drives.
    ${ReturnAddressCountryOrRegion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Email address of the recipient of the returned drives.
    ${ReturnAddressEmail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Phone number of the recipient of the returned drives.
    ${ReturnAddressPhone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The postal code to use when returning the drives.
    ${ReturnAddressPostalCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the recipient who will receive the hard drives when they are returned.
    ${ReturnAddressRecipientName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The state or province to use when returning the drives.
    ${ReturnAddressStateOrProvince},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The first line of the street address to use when returning the drives.
    ${ReturnAddressStreetAddress1},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The second line of the street address to use when returning the drives.
    ${ReturnAddressStreetAddress2},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the carrier that is used to ship the import or export drives.
    ${ReturnPackageCarrierName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Int32]
    # The number of drives included in the package.
    ${ReturnPackageDriveCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The date when the package is shipped.
    ${ReturnPackageShipDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The tracking number of the package.
    ${ReturnPackageTrackingNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The customer's account number with the carrier.
    ${ReturnShippingCarrierAccountNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The carrier's name.
    ${ReturnShippingCarrierName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The city name to use when returning the drives.
    ${ShippingInformationCity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The country or region to use when returning the drives.
    ${ShippingInformationCountryOrRegion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Phone number of the recipient of the returned drives.
    ${ShippingInformationPhone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The postal code to use when returning the drives.
    ${ShippingInformationPostalCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the recipient who will receive the hard drives when they are returned.
    ${ShippingInformationRecipientName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The state or province to use when returning the drives.
    ${ShippingInformationStateOrProvince},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The first line of the street address to use when returning the drives.
    ${ShippingInformationStreetAddress1},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The second line of the street address to use when returning the drives.
    ${ShippingInformationStreetAddress2},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Current state of the job.
    ${State},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The resource identifier of the storage account where data will be imported to or exported from.
    ${StorageAccountId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny]
    # Specifies the tags that will be assigned to the job.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            CreateExpanded = 'Az.StorageImportExport.private\New-AzStorageImportExportJob_CreateExpanded';
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
Deletes an existing job.
Only jobs in the Creating or Completed states can be deleted.
.Description
Deletes an existing job.
Only jobs in the Creating or Completed states can be deleted.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IStorageImportExportIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [JobName <String>]: The name of the import/export job.
  [LocationName <String>]: The name of the location. For example, West US or westus.
  [ResourceGroupName <String>]: The resource group name uniquely identifies the resource group within the user subscription.
  [SubscriptionId <String>]: The subscription ID for the Azure user.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/remove-azstorageimportexportjob
#>
function Remove-AzStorageImportExportJob {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('JobName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the import/export job.
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The resource group name uniquely identifies the resource group within the user subscription.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription ID for the Azure user.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            Delete = 'Az.StorageImportExport.private\Remove-AzStorageImportExportJob_Delete';
            DeleteViaIdentity = 'Az.StorageImportExport.private\Remove-AzStorageImportExportJob_DeleteViaIdentity';
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
Updates specific properties of a job.
You can call this operation to notify the Import/Export service that the hard drives comprising the import or export job have been shipped to the Microsoft data center.
It can also be used to cancel an existing job.
.Description
Updates specific properties of a job.
You can call this operation to notify the Import/Export service that the hard drives comprising the import or export job have been shipped to the Microsoft data center.
It can also be used to cancel an existing job.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DRIVELIST <IDriveStatus[]>: List of drives that comprise the job.
  [BitLockerKey <String>]: The BitLocker key used to encrypt the drive.
  [BytesSucceeded <Int64?>]: Bytes successfully transferred for the drive.
  [CopyStatus <String>]: Detailed status about the data transfer process. This field is not returned in the response until the drive is in the Transferring state.
  [DriveHeaderHash <String>]: The drive header hash value.
  [DriveId <String>]: The drive's hardware serial number, without spaces.
  [ErrorLogUri <String>]: A URI that points to the blob containing the error log for the data transfer operation.
  [ManifestFile <String>]: The relative path of the manifest file on the drive. 
  [ManifestHash <String>]: The Base16-encoded MD5 hash of the manifest file on the drive.
  [ManifestUri <String>]: A URI that points to the blob containing the drive manifest file. 
  [PercentComplete <Int64?>]: Percentage completed for the drive. 
  [State <DriveState?>]: The drive's current state. 
  [VerboseLogUri <String>]: A URI that points to the blob containing the verbose log for the data transfer operation. 

INPUTOBJECT <IStorageImportExportIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [JobName <String>]: The name of the import/export job.
  [LocationName <String>]: The name of the location. For example, West US or westus.
  [ResourceGroupName <String>]: The resource group name uniquely identifies the resource group within the user subscription.
  [SubscriptionId <String>]: The subscription ID for the Azure user.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.storageimportexport/update-azstorageimportexportjob
#>
function Update-AzStorageImportExportJob {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IJobResponse])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('JobName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The name of the import/export job.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [System.String]
    # The resource group name uniquely identifies the resource group within the user subscription.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription ID for the Azure user.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IStorageImportExportIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Header')]
    [System.String]
    # Specifies the preferred language for the response.
    ${AcceptLanguage},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the manifest files on the drives should be copied to block blobs.
    ${BackupDriveManifest},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # If specified, the value must be true.
    # The service will attempt to cancel the job.
    ${CancelRequested},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the carrier that is used to ship the import or export drives.
    ${DeliveryPackageCarrierName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.Int64]
    # The number of drives included in the package.
    ${DeliveryPackageDriveCount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The date when the package is shipped.
    ${DeliveryPackageShipDate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The tracking number of the package.
    ${DeliveryPackageTrackingNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDriveStatus[]]
    # List of drives that comprise the job.
    # To construct, see NOTES section for DRIVELIST properties and create a hash table.
    ${DriveList},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Indicates whether error logging or verbose logging is enabled.
    ${LogLevel},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The city name to use when returning the drives.
    ${ReturnAddressCity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The country or region to use when returning the drives.
    ${ReturnAddressCountryOrRegion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Email address of the recipient of the returned drives.
    ${ReturnAddressEmail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # Phone number of the recipient of the returned drives.
    ${ReturnAddressPhone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The postal code to use when returning the drives.
    ${ReturnAddressPostalCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The name of the recipient who will receive the hard drives when they are returned.
    ${ReturnAddressRecipientName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The state or province to use when returning the drives.
    ${ReturnAddressStateOrProvince},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The first line of the street address to use when returning the drives.
    ${ReturnAddressStreetAddress1},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The second line of the street address to use when returning the drives.
    ${ReturnAddressStreetAddress2},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The customer's account number with the carrier.
    ${ReturnShippingCarrierAccountNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # The carrier's name.
    ${ReturnShippingCarrierName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [System.String]
    # If specified, the value must be Shipping, which tells the Import/Export service that the package for the job has been shipped.
    # The ReturnAddress and DeliveryPackage properties must have been set either in this request or in a previous request, otherwise the request will fail.
    ${State},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny]
    # Specifies the tags that will be assigned to the job
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Category('Runtime')]
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
            UpdateExpanded = 'Az.StorageImportExport.private\Update-AzStorageImportExportJob_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.StorageImportExport.private\Update-AzStorageImportExportJob_UpdateViaIdentityExpanded';
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
