namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The top level data export resource container.</summary>
    public partial class DataExport :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExport,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.Resource();

        /// <summary>The latest data export rule modification time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string CreatedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).CreatedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).CreatedDate = value ?? null; }

        /// <summary>The data export rule ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string DataExportId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DataExportId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DataExportId = value ?? null; }

        /// <summary>
        /// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string DestinationResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationResourceId = value ?? null; }

        /// <summary>The type of the destination resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? DestinationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationType; }

        /// <summary>Active when enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public bool? Enable { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).Enable; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).Enable = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>Date and time when the export was last modified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string LastModifiedDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).LastModifiedDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).LastModifiedDate = value ?? null; }

        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string MetaDataEventHubName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).MetaDataEventHubName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).MetaDataEventHubName = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Destination</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestination Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportInternal.Destination { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).Destination = value; }

        /// <summary>Internal Acessors for DestinationMetaData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportInternal.DestinationMetaData { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationMetaData; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationMetaData = value; }

        /// <summary>Internal Acessors for DestinationType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.Type? Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportInternal.DestinationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).DestinationType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties _property;

        /// <summary>data export properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.DataExportProperties()); set => this._property = value; }

        /// <summary>An array of tables to export, for example: [“Heartbeat, SecurityEvent”].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string[] TableName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).TableName; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportPropertiesInternal)Property).TableName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="DataExport" /> instance.</summary>
        public DataExport()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The top level data export resource container.
    public partial interface IDataExport :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource
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
        Required = false,
        ReadOnly = false,
        Description = @"An array of tables to export, for example: [“Heartbeat, SecurityEvent”].",
        SerializedName = @"tableNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableName { get; set; }

    }
    /// The top level data export resource container.
    internal partial interface IDataExportInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal
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
        /// <summary>data export properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataExportProperties Property { get; set; }
        /// <summary>An array of tables to export, for example: [“Heartbeat, SecurityEvent”].</summary>
        string[] TableName { get; set; }

    }
}