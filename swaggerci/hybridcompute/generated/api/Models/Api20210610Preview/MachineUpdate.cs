namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes a hybrid machine Update.</summary>
    public partial class MachineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdate __resourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.ResourceUpdate();

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity _identity;

        /// <summary>Identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.Identity()); set => this._identity = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType)""); }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LinuxConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LinuxConfigurationPatchSettingsAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LinuxConfigurationPatchSettingsAssessmentMode = value ?? null; }

        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCity = value ?? null; }

        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataCountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataCountryOrRegion = value ?? null; }

        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataDistrict { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataDistrict; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataDistrict = value ?? null; }

        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string LocationDataName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationDataName = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.Identity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for LinuxConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.LinuxConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LinuxConfigurationPatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LinuxConfigurationPatchSetting = value; }

        /// <summary>Internal Acessors for LocationData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.LocationData { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationData; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).LocationData = value; }

        /// <summary>Internal Acessors for OSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.OSProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfile = value; }

        /// <summary>Internal Acessors for OSProfileComputerName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileComputerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileComputerName = value; }

        /// <summary>Internal Acessors for OSProfileLinuxConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.OSProfileLinuxConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileLinuxConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileLinuxConfiguration = value; }

        /// <summary>Internal Acessors for OSProfileWindowsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.OSProfileWindowsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileWindowsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileWindowsConfiguration = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for WindowConfigurationPatchSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateInternal.WindowConfigurationPatchSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).WindowConfigurationPatchSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).WindowConfigurationPatchSetting = value; }

        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).OSProfileComputerName; }

        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string ParentClusterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).ParentClusterResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).ParentClusterResourceId = value ?? null; }

        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string PrivateLinkScopeResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).PrivateLinkScopeResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).PrivateLinkScopeResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties _property;

        /// <summary>Hybrid Compute Machine properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.MachineUpdateProperties()); set => this._property = value; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdateInternal)__resourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdateInternal)__resourceUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string WindowsConfigurationPatchSettingsAssessmentMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).WindowsConfigurationPatchSettingsAssessmentMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdatePropertiesInternal)Property).WindowsConfigurationPatchSettingsAssessmentMode = value ?? null; }

        /// <summary>Creates an new <see cref="MachineUpdate" /> instance.</summary>
        public MachineUpdate()
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
            await eventListener.AssertNotNull(nameof(__resourceUpdate), __resourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__resourceUpdate), __resourceUpdate);
        }
    }
    /// Describes a hybrid machine Update.
    public partial interface IMachineUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdate
    {
        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal ID of resource identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of resource.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>The city or locality where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The city or locality where the resource is located.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The country or region where the resource is located",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The district, state, or province where the resource is located.",
        SerializedName = @"district",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A canonical name for the geographic or physical location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LocationDataName { get; set; }
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the host OS name of the hybrid machine.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileComputerName { get;  }
        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.",
        SerializedName = @"parentClusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ParentClusterResourceId { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the private link scope this machine is assigned to, if any.",
        SerializedName = @"privateLinkScopeResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeResourceId { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }

    }
    /// Describes a hybrid machine Update.
    internal partial interface IMachineUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IResourceUpdateInternal
    {
        /// <summary>Identity for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.IIdentity Identity { get; set; }
        /// <summary>The principal ID of resource identity.</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>The tenant ID of resource.</summary>
        string IdentityTenantId { get; set; }
        /// <summary>The identity type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.ResourceIdentityType? IdentityType { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings LinuxConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        string LinuxConfigurationPatchSettingsAssessmentMode { get; set; }
        /// <summary>Metadata pertaining to the geographic location of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api10.ILocationData LocationData { get; set; }
        /// <summary>The city or locality where the resource is located.</summary>
        string LocationDataCity { get; set; }
        /// <summary>The country or region where the resource is located</summary>
        string LocationDataCountryOrRegion { get; set; }
        /// <summary>The district, state, or province where the resource is located.</summary>
        string LocationDataDistrict { get; set; }
        /// <summary>A canonical name for the geographic or physical location.</summary>
        string LocationDataName { get; set; }
        /// <summary>Specifies the operating system settings for the hybrid machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfile OSProfile { get; set; }
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        string OSProfileComputerName { get; set; }
        /// <summary>Specifies the linux configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileLinuxConfiguration OSProfileLinuxConfiguration { get; set; }
        /// <summary>Specifies the windows configuration for update management.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IOSProfileWindowsConfiguration OSProfileWindowsConfiguration { get; set; }
        /// <summary>
        /// The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
        /// </summary>
        string ParentClusterResourceId { get; set; }
        /// <summary>The resource id of the private link scope this machine is assigned to, if any.</summary>
        string PrivateLinkScopeResourceId { get; set; }
        /// <summary>Hybrid Compute Machine properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IMachineUpdateProperties Property { get; set; }
        /// <summary>Specifies the patch settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings WindowConfigurationPatchSetting { get; set; }
        /// <summary>Specifies the assessment mode.</summary>
        string WindowsConfigurationPatchSettingsAssessmentMode { get; set; }

    }
}