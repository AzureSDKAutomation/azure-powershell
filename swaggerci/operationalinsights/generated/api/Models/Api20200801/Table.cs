namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Workspace data table definition.</summary>
    public partial class Table :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.TableProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableProperties _property;

        /// <summary>Table properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.TableProperties()); set => this._property = value; }

        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? RetentionInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITablePropertiesInternal)Property).RetentionInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITablePropertiesInternal)Property).RetentionInDay = value ?? default(int); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Table" /> instance.</summary>
        public Table()
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
    /// Workspace data table definition.
    public partial interface ITable :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource
    {
        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace retention.",
        SerializedName = @"retentionInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionInDay { get; set; }

    }
    /// Workspace data table definition.
    internal partial interface ITableInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal
    {
        /// <summary>Table properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ITableProperties Property { get; set; }
        /// <summary>
        /// The data table data retention in days, between 30 and 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        int? RetentionInDay { get; set; }

    }
}