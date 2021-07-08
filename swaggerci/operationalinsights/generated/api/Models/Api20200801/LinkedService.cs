namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The top level Linked service resource container.</summary>
    public partial class LinkedService :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedService,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal,
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
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServiceProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties _property;

        /// <summary>The properties of the linked service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServiceProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the linked service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus)""); }

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).ResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.LinkedServiceTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string WriteAccessResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).WriteAccessResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal)Property).WriteAccessResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="LinkedService" /> instance.</summary>
        public LinkedService()
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
    /// The top level Linked service resource container.
    public partial interface ILinkedService :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResource
    {
        /// <summary>The provisioning state of the linked service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provisioning state of the linked service.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require read access",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags Tag { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require write access",
        SerializedName = @"writeAccessResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string WriteAccessResourceId { get; set; }

    }
    /// The top level Linked service resource container.
    internal partial interface ILinkedServiceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api10.IResourceInternal
    {
        /// <summary>The properties of the linked service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties Property { get; set; }
        /// <summary>The provisioning state of the linked service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceTags Tag { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        string WriteAccessResourceId { get; set; }

    }
}