namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Data Export properties.</summary>
    public partial class DataExportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreatedDate" /> property.</summary>
        private string _createdDate;

        /// <summary>The latest data export rule modification time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string CreatedDate { get => this._createdDate; set => this._createdDate = value; }

        /// <summary>Backing field for <see cref="DataExportId" /> property.</summary>
        private string _dataExportId;

        /// <summary>The data export rule ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string DataExportId { get => this._dataExportId; set => this._dataExportId = value; }

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination _destination;

        /// <summary>destination properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination Destination { get => (this._destination = this._destination ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.Destination()); set => this._destination = value; }

        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string DestinationResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).ResourceId = value ?? null; }

        /// <summary>The type of the destination resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? DestinationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).Type; }

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Active when enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Backing field for <see cref="LastModifiedDate" /> property.</summary>
        private string _lastModifiedDate;

        /// <summary>Date and time when the export was last modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string LastModifiedDate { get => this._lastModifiedDate; set => this._lastModifiedDate = value; }

        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetaDataEventHubName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).MetaDataEventHubName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).MetaDataEventHubName = value ?? null; }

        /// <summary>Internal Acessors for Destination</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal.Destination { get => (this._destination = this._destination ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.Destination()); set { {_destination = value;} } }

        /// <summary>Internal Acessors for DestinationMetaData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal.DestinationMetaData { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).MetaData; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).MetaData = value; }

        /// <summary>Internal Acessors for DestinationType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal.DestinationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationInternal)Destination).Type = value; }

        /// <summary>Backing field for <see cref="TableName" /> property.</summary>
        private string[] _tableName;

        /// <summary>An array of tables to export, for example: [“Heartbeat, SecurityEvent”].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string[] TableName { get => this._tableName; set => this._tableName = value; }

        /// <summary>Creates an new <see cref="DataExportProperties" /> instance.</summary>
        public DataExportProperties()
        {

        }
    }
    /// Data Export properties.
    public partial interface IDataExportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The latest data export rule modification time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The latest data export rule modification time.",
        SerializedName = @"createdDate",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedDate { get; set; }
        /// <summary>The data export rule ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data export rule ID.",
        SerializedName = @"dataExportId",
        PossibleTypes = new [] { typeof(string) })]
        string DataExportId { get; set; }
        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationResourceId { get; set; }
        /// <summary>The type of the destination resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the destination resource",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? DestinationType { get;  }
        /// <summary>Active when enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Active when enabled.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }
        /// <summary>Date and time when the export was last modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date and time when the export was last modified.",
        SerializedName = @"lastModifiedDate",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedDate { get; set; }
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
        /// <summary>An array of tables to export, for example: [“Heartbeat, SecurityEvent”].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An array of tables to export, for example: [“Heartbeat, SecurityEvent”].",
        SerializedName = @"tableNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableName { get; set; }

    }
    /// Data Export properties.
    internal partial interface IDataExportPropertiesInternal

    {
        /// <summary>The latest data export rule modification time.</summary>
        string CreatedDate { get; set; }
        /// <summary>The data export rule ID.</summary>
        string DataExportId { get; set; }
        /// <summary>destination properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination Destination { get; set; }
        /// <summary>destination meta data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData DestinationMetaData { get; set; }
        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        string DestinationResourceId { get; set; }
        /// <summary>The type of the destination resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? DestinationType { get; set; }
        /// <summary>Active when enabled.</summary>
        bool? Enable { get; set; }
        /// <summary>Date and time when the export was last modified.</summary>
        string LastModifiedDate { get; set; }
        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        string MetaDataEventHubName { get; set; }
        /// <summary>An array of tables to export, for example: [“Heartbeat, SecurityEvent”].</summary>
        string[] TableName { get; set; }

    }
}