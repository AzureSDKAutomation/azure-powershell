namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Destination properties.</summary>
    public partial class Destination :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal
    {

        /// <summary>Backing field for <see cref="MetaData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData _metaData;

        /// <summary>destination meta data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData MetaData { get => (this._metaData = this._metaData ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationMetaData()); set => this._metaData = value; }

        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetaDataEventHubName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaDataInternal)MetaData).EventHubName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaDataInternal)MetaData).EventHubName = value ?? null; }

        /// <summary>Internal Acessors for MetaData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal.MetaData { get => (this._metaData = this._metaData ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DestinationMetaData()); set { {_metaData = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? _type;

        /// <summary>The type of the destination resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Type { get => this._type; }

        /// <summary>Creates an new <see cref="Destination" /> instance.</summary>
        public Destination()
        {

        }
    }
    /// Destination properties.
    public partial interface IDestination :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        string MetaDataEventHubName { get; set; }
        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>The type of the destination resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the destination resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Type { get;  }

    }
    /// Destination properties.
    internal partial interface IDestinationInternal

    {
        /// <summary>destination meta data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData MetaData { get; set; }
        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        string MetaDataEventHubName { get; set; }
        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>The type of the destination resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Type { get; set; }

    }
}