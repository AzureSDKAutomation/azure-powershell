namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The group information for creating a private endpoint on a workspace</summary>
    public partial class GroupIdInformation :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.Resource();

        /// <summary>The group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).GroupId = value ?? null; }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.GroupIdInformationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationProperties _property;

        /// <summary>The group id properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.GroupIdInformationProperties()); set => this._property = value; }

        /// <summary>The required members for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string[] RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).RequiredMember; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).RequiredMember = value ?? null /* arrayOf */; }

        /// <summary>The required DNS zones for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string[] RequiredZoneName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).RequiredZoneName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationPropertiesInternal)Property).RequiredZoneName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="GroupIdInformation" /> instance.</summary>
        public GroupIdInformation()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The group information for creating a private endpoint on a workspace
    public partial interface IGroupIdInformation :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResource
    {
        /// <summary>The group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>The required members for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required members for a specific group id",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required DNS zones for a specific group id",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredZoneName { get; set; }

    }
    /// The group information for creating a private endpoint on a workspace
    internal partial interface IGroupIdInformationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IResourceInternal
    {
        /// <summary>The group id</summary>
        string GroupId { get; set; }
        /// <summary>The group id properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformationProperties Property { get; set; }
        /// <summary>The required members for a specific group id</summary>
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id</summary>
        string[] RequiredZoneName { get; set; }

    }
}