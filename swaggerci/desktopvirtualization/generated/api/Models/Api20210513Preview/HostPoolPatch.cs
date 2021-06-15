namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>HostPool properties that can be patched.</summary>
    public partial class HostPoolPatch :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatch,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.Resource();

        /// <summary>Custom rdp property of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string CustomRdpProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).CustomRdpProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).CustomRdpProperty = value ?? null; }

        /// <summary>Description of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Friendly name of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).FriendlyName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>The type of the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType? LoadBalancerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).LoadBalancerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).LoadBalancerType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType)""); }

        /// <summary>The max session limit of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? MaxSessionLimit { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).MaxSessionLimit; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).MaxSessionLimit = value ?? default(int); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolPatchProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RegistrationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoPatch Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal.RegistrationInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfo = value; }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal.SessionHostComponentUpdateConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfiguration = value; }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfigurationPrimaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal.SessionHostComponentUpdateConfigurationPrimaryWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationPrimaryWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationPrimaryWindow = value; }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfigurationSecondaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchInternal.SessionHostComponentUpdateConfigurationSecondaryWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationSecondaryWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationSecondaryWindow = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PersonalDesktopAssignmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PersonalDesktopAssignmentType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType)""); }

        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType? PreferredAppGroupType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PreferredAppGroupType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PreferredAppGroupType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType)""); }

        /// <summary>Day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PrimaryWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PrimaryWindowDayOfWeek = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek)""); }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? PrimaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PrimaryWindowHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PrimaryWindowHour = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchProperties _property;

        /// <summary>HostPool properties that can be patched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolPatchProperties()); set => this._property = value; }

        /// <summary>Enabled to allow this resource to be access from the public network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess)""); }

        /// <summary>Expiration time of registration token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? RegistrationInfoExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfoExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfoExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>The type of resetting the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation? RegistrationInfoRegistrationTokenOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfoRegistrationTokenOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).RegistrationInfoRegistrationTokenOperation = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation)""); }

        /// <summary>The ring number of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? Ring { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).Ring; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).Ring = value ?? default(int); }

        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string[] SecondaryWindowDaysOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SecondaryWindowDaysOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SecondaryWindowDaysOfWeek = value ?? null /* arrayOf */; }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? SecondaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SecondaryWindowHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SecondaryWindowHour = value ?? default(int); }

        /// <summary>The type of maintenance for session host components.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? SessionHostComponentUpdateConfigurationMaintenanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationMaintenanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationMaintenanceType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType)""); }

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone = value ?? null; }

        /// <summary>Whether to use localTime of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? SessionHostComponentUpdateConfigurationUseSessionHostLocalTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationUseSessionHostLocalTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SessionHostComponentUpdateConfigurationUseSessionHostLocalTime = value ?? default(bool); }

        /// <summary>ClientId for the registered Relying Party used to issue WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SsoClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoClientId = value ?? null; }

        /// <summary>Path to Azure KeyVault storing the secret used for communication to ADFS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SsoClientSecretKeyVaultPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoClientSecretKeyVaultPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoClientSecretKeyVaultPath = value ?? null; }

        /// <summary>The type of single sign on Secret Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType? SsoSecretType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoSecretType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoSecretType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType)""); }

        /// <summary>URL to customer ADFS server for signing WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SsoadfsAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoadfsAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).SsoadfsAuthority = value ?? null; }

        /// <summary>The flag to turn on/off StartVMOnConnect feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? StartVMOnConnect { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).StartVMOnConnect; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).StartVMOnConnect = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchTags _tag;

        /// <summary>tags to be updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.HostPoolPatchTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>VM template for sessionhosts configuration within hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string VMTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).VMTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).VMTemplate = value ?? null; }

        /// <summary>Is validation environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? ValidationEnvironment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).ValidationEnvironment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchPropertiesInternal)Property).ValidationEnvironment = value ?? default(bool); }

        /// <summary>Creates an new <see cref="HostPoolPatch" /> instance.</summary>
        public HostPoolPatch()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// HostPool properties that can be patched.
    public partial interface IHostPoolPatch :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResource
    {
        /// <summary>Custom rdp property of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom rdp property of HostPool.",
        SerializedName = @"customRdpProperty",
        PossibleTypes = new [] { typeof(string) })]
        string CustomRdpProperty { get; set; }
        /// <summary>Description of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of HostPool.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Friendly name of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of HostPool.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The type of the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the load balancer.",
        SerializedName = @"loadBalancerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType? LoadBalancerType { get; set; }
        /// <summary>The max session limit of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The max session limit of HostPool.",
        SerializedName = @"maxSessionLimit",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxSessionLimit { get; set; }
        /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PersonalDesktopAssignment type for HostPool.",
        SerializedName = @"personalDesktopAssignmentType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of preferred application group type, default to Desktop Application Group",
        SerializedName = @"preferredAppGroupType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType? PreferredAppGroupType { get; set; }
        /// <summary>Day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day of the week.",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update start hour of the day. (0 - 23)",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int? PrimaryWindowHour { get; set; }
        /// <summary>Enabled to allow this resource to be access from the public network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enabled to allow this resource to be access from the public network",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Expiration time of registration token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expiration time of registration token.",
        SerializedName = @"expirationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RegistrationInfoExpirationTime { get; set; }
        /// <summary>The type of resetting the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of resetting the token.",
        SerializedName = @"registrationTokenOperation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation? RegistrationInfoRegistrationTokenOperation { get; set; }
        /// <summary>The ring number of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ring number of HostPool.",
        SerializedName = @"ring",
        PossibleTypes = new [] { typeof(int) })]
        int? Ring { get; set; }
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set of days of the week on which this schedule is active.",
        SerializedName = @"daysOfWeek",
        PossibleTypes = new [] { typeof(string) })]
        string[] SecondaryWindowDaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update start hour of the day. (0 - 23)",
        SerializedName = @"hour",
        PossibleTypes = new [] { typeof(int) })]
        int? SecondaryWindowHour { get; set; }
        /// <summary>The type of maintenance for session host components.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of maintenance for session host components.",
        SerializedName = @"maintenanceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? SessionHostComponentUpdateConfigurationMaintenanceType { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.",
        SerializedName = @"maintenanceWindowTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone { get; set; }
        /// <summary>Whether to use localTime of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to use localTime of the virtual machine.",
        SerializedName = @"useSessionHostLocalTime",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SessionHostComponentUpdateConfigurationUseSessionHostLocalTime { get; set; }
        /// <summary>ClientId for the registered Relying Party used to issue WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ClientId for the registered Relying Party used to issue WVD SSO certificates.",
        SerializedName = @"ssoClientId",
        PossibleTypes = new [] { typeof(string) })]
        string SsoClientId { get; set; }
        /// <summary>Path to Azure KeyVault storing the secret used for communication to ADFS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to Azure KeyVault storing the secret used for communication to ADFS.",
        SerializedName = @"ssoClientSecretKeyVaultPath",
        PossibleTypes = new [] { typeof(string) })]
        string SsoClientSecretKeyVaultPath { get; set; }
        /// <summary>The type of single sign on Secret Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of single sign on Secret Type.",
        SerializedName = @"ssoSecretType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType? SsoSecretType { get; set; }
        /// <summary>URL to customer ADFS server for signing WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to customer ADFS server for signing WVD SSO certificates.",
        SerializedName = @"ssoadfsAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string SsoadfsAuthority { get; set; }
        /// <summary>The flag to turn on/off StartVMOnConnect feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The flag to turn on/off StartVMOnConnect feature.",
        SerializedName = @"startVMOnConnect",
        PossibleTypes = new [] { typeof(bool) })]
        bool? StartVMOnConnect { get; set; }
        /// <summary>tags to be updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"tags to be updated",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchTags Tag { get; set; }
        /// <summary>VM template for sessionhosts configuration within hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM template for sessionhosts configuration within hostpool.",
        SerializedName = @"vmTemplate",
        PossibleTypes = new [] { typeof(string) })]
        string VMTemplate { get; set; }
        /// <summary>Is validation environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is validation environment.",
        SerializedName = @"validationEnvironment",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidationEnvironment { get; set; }

    }
    /// HostPool properties that can be patched.
    internal partial interface IHostPoolPatchInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceInternal
    {
        /// <summary>Custom rdp property of HostPool.</summary>
        string CustomRdpProperty { get; set; }
        /// <summary>Description of HostPool.</summary>
        string Description { get; set; }
        /// <summary>Friendly name of HostPool.</summary>
        string FriendlyName { get; set; }
        /// <summary>The type of the load balancer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType? LoadBalancerType { get; set; }
        /// <summary>The max session limit of HostPool.</summary>
        int? MaxSessionLimit { get; set; }
        /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType? PreferredAppGroupType { get; set; }
        /// <summary>Day of the week.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? PrimaryWindowHour { get; set; }
        /// <summary>HostPool properties that can be patched.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchProperties Property { get; set; }
        /// <summary>Enabled to allow this resource to be access from the public network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>The registration info of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoPatch RegistrationInfo { get; set; }
        /// <summary>Expiration time of registration token.</summary>
        global::System.DateTime? RegistrationInfoExpirationTime { get; set; }
        /// <summary>The type of resetting the token.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation? RegistrationInfoRegistrationTokenOperation { get; set; }
        /// <summary>The ring number of HostPool.</summary>
        int? Ring { get; set; }
        /// <summary>Set of days of the week on which this schedule is active.</summary>
        string[] SecondaryWindowDaysOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? SecondaryWindowHour { get; set; }
        /// <summary>
        /// The session host configuration for updating agent, monitoring agent, and stack component.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties SessionHostComponentUpdateConfiguration { get; set; }
        /// <summary>The type of maintenance for session host components.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? SessionHostComponentUpdateConfigurationMaintenanceType { get; set; }
        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone { get; set; }
        /// <summary>
        /// Primary Window of the maintenance. Maintenance windows are 2 hours long. We try to push component update in this window
        /// first.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties SessionHostComponentUpdateConfigurationPrimaryWindow { get; set; }
        /// <summary>
        /// Secondary maintenance windows. Maintenance windows are 2 hours long. We try to exercise this only when the primary window
        /// update fails.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties SessionHostComponentUpdateConfigurationSecondaryWindow { get; set; }
        /// <summary>Whether to use localTime of the virtual machine.</summary>
        bool? SessionHostComponentUpdateConfigurationUseSessionHostLocalTime { get; set; }
        /// <summary>ClientId for the registered Relying Party used to issue WVD SSO certificates.</summary>
        string SsoClientId { get; set; }
        /// <summary>Path to Azure KeyVault storing the secret used for communication to ADFS.</summary>
        string SsoClientSecretKeyVaultPath { get; set; }
        /// <summary>The type of single sign on Secret Type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType? SsoSecretType { get; set; }
        /// <summary>URL to customer ADFS server for signing WVD SSO certificates.</summary>
        string SsoadfsAuthority { get; set; }
        /// <summary>The flag to turn on/off StartVMOnConnect feature.</summary>
        bool? StartVMOnConnect { get; set; }
        /// <summary>tags to be updated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPatchTags Tag { get; set; }
        /// <summary>VM template for sessionhosts configuration within hostpool.</summary>
        string VMTemplate { get; set; }
        /// <summary>Is validation environment.</summary>
        bool? ValidationEnvironment { get; set; }

    }
}