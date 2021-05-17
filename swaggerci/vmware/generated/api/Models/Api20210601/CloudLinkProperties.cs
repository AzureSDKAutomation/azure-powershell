namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>The properties of a cloud link.</summary>
    public partial class CloudLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICloudLinkProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICloudLinkPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LinkedCloud" /> property.</summary>
        private string _linkedCloud;

        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string LinkedCloud { get => this._linkedCloud; set => this._linkedCloud = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus? Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ICloudLinkPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus? _status;

        /// <summary>The state of the cloud link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="CloudLinkProperties" /> instance.</summary>
        public CloudLinkProperties()
        {

        }
    }
    /// The properties of a cloud link.
    public partial interface ICloudLinkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier of the other private cloud participating in the link.",
        SerializedName = @"linkedCloud",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedCloud { get; set; }
        /// <summary>The state of the cloud link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the cloud link.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus? Status { get;  }

    }
    /// The properties of a cloud link.
    internal partial interface ICloudLinkPropertiesInternal

    {
        /// <summary>Identifier of the other private cloud participating in the link.</summary>
        string LinkedCloud { get; set; }
        /// <summary>The state of the cloud link.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.CloudLinkStatus? Status { get; set; }

    }
}