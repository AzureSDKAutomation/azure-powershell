namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>A dashboard part metadata.</summary>
    public partial class DashboardPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPartMetadataInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="DashboardPartMetadata" /> instance.</summary>
        public DashboardPartMetadata()
        {

        }
    }
    /// A dashboard part metadata.
    public partial interface IDashboardPartMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The type of dashboard part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of dashboard part.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// A dashboard part metadata.
    internal partial interface IDashboardPartMetadataInternal

    {
        /// <summary>The type of dashboard part.</summary>
        string Type { get; set; }

    }
}