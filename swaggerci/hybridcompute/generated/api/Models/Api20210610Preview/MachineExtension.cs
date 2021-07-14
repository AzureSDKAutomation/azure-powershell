namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes a Machine Extension.</summary>
    public partial class MachineExtension :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtension,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.TrackedResource();

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public bool? AutoUpgradeMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).AutoUpgradeMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).AutoUpgradeMinorVersion = value ?? default(bool); }

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string ForceUpdateTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ForceUpdateTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ForceUpdateTag = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Id; }

        /// <summary>The machine extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewName = value ?? null; }

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewType = value ?? null; }

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewTypeHandlerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewTypeHandlerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewTypeHandlerVersion = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for InstanceView</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInstanceView Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal.InstanceView { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceView; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceView = value; }

        /// <summary>Internal Acessors for InstanceViewStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInstanceViewStatus Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal.InstanceViewStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).InstanceViewStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionProperties Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineExtensionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Name; }

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PropertiesType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionProperties _property;

        /// <summary>Describes Machine Extension Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineExtensionProperties()); set => this._property = value; }

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny ProtectedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ProtectedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ProtectedSetting = value ?? null /* model class */; }

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Publisher = value ?? null; }

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny Setting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Setting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).Setting = value ?? null /* model class */; }

        /// <summary>The status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusCode = value ?? null; }

        /// <summary>The short localizable label for the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusDisplayStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusDisplayStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusDisplayStatus = value ?? null; }

        /// <summary>The level code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes? StatusLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusLevel = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes)""); }

        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusMessage = value ?? null; }

        /// <summary>The time of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).StatusTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData _systemData;

        /// <summary>The system meta data relating to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IResourceInternal)__trackedResource).Type; }

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string TypeHandlerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).TypeHandlerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionPropertiesInternal)Property).TypeHandlerVersion = value ?? null; }

        /// <summary>Creates an new <see cref="MachineExtension" /> instance.</summary>
        public MachineExtension()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Describes a Machine Extension.
    public partial interface IMachineExtension :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResource
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the extension handler should be forced to update even if the extension configuration has not changed.",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>The machine extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The machine extension name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceViewName { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceViewType { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the version of the script handler.",
        SerializedName = @"typeHandlerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceViewTypeHandlerVersion { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesType { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.",
        SerializedName = @"protectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny ProtectedSetting { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the extension handler publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Json formatted public settings for the extension.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny Setting { get; set; }
        /// <summary>The status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string StatusCode { get; set; }
        /// <summary>The short localizable label for the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The short localizable label for the status.",
        SerializedName = @"displayStatus",
        PossibleTypes = new [] { typeof(string) })]
        string StatusDisplayStatus { get; set; }
        /// <summary>The level code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The level code.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes? StatusLevel { get; set; }
        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detailed status message, including for alerts and error messages.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get; set; }
        /// <summary>The time of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time of the status.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusTime { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the version of the script handler.",
        SerializedName = @"typeHandlerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TypeHandlerVersion { get; set; }

    }
    /// Describes a Machine Extension.
    internal partial interface IMachineExtensionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ITrackedResourceInternal
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        string ForceUpdateTag { get; set; }
        /// <summary>The machine extension instance view.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInstanceView InstanceView { get; set; }
        /// <summary>The machine extension name.</summary>
        string InstanceViewName { get; set; }
        /// <summary>Instance view status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionInstanceViewStatus InstanceViewStatus { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string InstanceViewType { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string InstanceViewTypeHandlerVersion { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string PropertiesType { get; set; }
        /// <summary>Describes Machine Extension Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineExtensionProperties Property { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny ProtectedSetting { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The name of the extension handler publisher.</summary>
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny Setting { get; set; }
        /// <summary>The status code.</summary>
        string StatusCode { get; set; }
        /// <summary>The short localizable label for the status.</summary>
        string StatusDisplayStatus { get; set; }
        /// <summary>The level code.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes? StatusLevel { get; set; }
        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        string StatusMessage { get; set; }
        /// <summary>The time of the status.</summary>
        global::System.DateTime? StatusTime { get; set; }
        /// <summary>The system meta data relating to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string TypeHandlerVersion { get; set; }

    }
}