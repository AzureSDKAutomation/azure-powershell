
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
