namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Properties of HostPool.</summary>
    public partial class HostPoolProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGroupReference" /> property.</summary>
        private string[] _applicationGroupReference;

        /// <summary>List of applicationGroup links.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string[] ApplicationGroupReference { get => this._applicationGroupReference; }

        /// <summary>Backing field for <see cref="CloudPcResource" /> property.</summary>
        private bool? _cloudPcResource;

        /// <summary>Is cloud pc resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? CloudPcResource { get => this._cloudPcResource; }

        /// <summary>Backing field for <see cref="CustomRdpProperty" /> property.</summary>
        private string _customRdpProperty;

        /// <summary>Custom rdp property of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string CustomRdpProperty { get => this._customRdpProperty; set => this._customRdpProperty = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="HostPoolType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType _hostPoolType;

        /// <summary>HostPool type for desktop.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType HostPoolType { get => this._hostPoolType; set => this._hostPoolType = value; }

        /// <summary>Backing field for <see cref="LoadBalancerType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType _loadBalancerType;

        /// <summary>The type of the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType LoadBalancerType { get => this._loadBalancerType; set => this._loadBalancerType = value; }

        /// <summary>Backing field for <see cref="MaxSessionLimit" /> property.</summary>
        private int? _maxSessionLimit;

        /// <summary>The max session limit of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? MaxSessionLimit { get => this._maxSessionLimit; set => this._maxSessionLimit = value; }

        /// <summary>Internal Acessors for ApplicationGroupReference</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.ApplicationGroupReference { get => this._applicationGroupReference; set { {_applicationGroupReference = value;} } }

        /// <summary>Internal Acessors for CloudPcResource</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.CloudPcResource { get => this._cloudPcResource; set { {_cloudPcResource = value;} } }

        /// <summary>Internal Acessors for MigrationRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.MigrationRequest { get => (this._migrationRequest = this._migrationRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MigrationRequestProperties()); set { {_migrationRequest = value;} } }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.ObjectId { get => this._objectId; set { {_objectId = value;} } }

        /// <summary>Internal Acessors for RegistrationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfo Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.RegistrationInfo { get => (this._registrationInfo = this._registrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.RegistrationInfo()); set { {_registrationInfo = value;} } }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.SessionHostComponentUpdateConfiguration { get => (this._sessionHostComponentUpdateConfiguration = this._sessionHostComponentUpdateConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostComponentUpdateConfigurationProperties()); set { {_sessionHostComponentUpdateConfiguration = value;} } }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfigurationPrimaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMaintenanceWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.SessionHostComponentUpdateConfigurationPrimaryWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindow = value; }

        /// <summary>Internal Acessors for SessionHostComponentUpdateConfigurationSecondaryWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISecondaryWindowProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IHostPoolPropertiesInternal.SessionHostComponentUpdateConfigurationSecondaryWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindow = value; }

        /// <summary>Backing field for <see cref="MigrationRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestProperties _migrationRequest;

        /// <summary>The registration info of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestProperties MigrationRequest { get => (this._migrationRequest = this._migrationRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.MigrationRequestProperties()); set => this._migrationRequest = value; }

        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MigrationRequestMigrationPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestPropertiesInternal)MigrationRequest).MigrationPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestPropertiesInternal)MigrationRequest).MigrationPath = value ?? null; }

        /// <summary>The type of operation for migration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation? MigrationRequestOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestPropertiesInternal)MigrationRequest).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestPropertiesInternal)MigrationRequest).Operation = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation)""); }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>ObjectId of HostPool. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; }

        /// <summary>Backing field for <see cref="PersonalDesktopAssignmentType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? _personalDesktopAssignmentType;

        /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get => this._personalDesktopAssignmentType; set => this._personalDesktopAssignmentType = value; }

        /// <summary>Backing field for <see cref="PreferredAppGroupType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType _preferredAppGroupType;

        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType PreferredAppGroupType { get => this._preferredAppGroupType; set => this._preferredAppGroupType = value; }

        /// <summary>Day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindowDayOfWeek = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek)""); }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? PrimaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindowHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).PrimaryWindowHour = value ?? default(int); }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? _publicNetworkAccess;

        /// <summary>
        /// Enabled allows this resource to be accessed from both public and private networks, Disabled allows this resource to only
        /// be accessed via private endpoints
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="RegistrationInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfo _registrationInfo;

        /// <summary>The registration info of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfo RegistrationInfo { get => (this._registrationInfo = this._registrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.RegistrationInfo()); set => this._registrationInfo = value; }

        /// <summary>Expiration time of registration token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public global::System.DateTime? RegistrationInfoExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).ExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).ExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>The type of resetting the token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation? RegistrationInfoRegistrationTokenOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).RegistrationTokenOperation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).RegistrationTokenOperation = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation)""); }

        /// <summary>The registration token base64 encoded string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string RegistrationInfoToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).Token; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfoInternal)RegistrationInfo).Token = value ?? null; }

        /// <summary>Backing field for <see cref="Ring" /> property.</summary>
        private int? _ring;

        /// <summary>The ring number of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? Ring { get => this._ring; set => this._ring = value; }

        /// <summary>Set of days of the week on which this schedule is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string[] SecondaryWindowDaysOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindowDaysOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindowDaysOfWeek = value ?? null /* arrayOf */; }

        /// <summary>The update start hour of the day. (0 - 23)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? SecondaryWindowHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindowHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).SecondaryWindowHour = value ?? default(int); }

        /// <summary>
        /// Backing field for <see cref="SessionHostComponentUpdateConfiguration" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties _sessionHostComponentUpdateConfiguration;

        /// <summary>
        /// The session host configuration for updating agent, monitoring agent, and stack component.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationProperties SessionHostComponentUpdateConfiguration { get => (this._sessionHostComponentUpdateConfiguration = this._sessionHostComponentUpdateConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.SessionHostComponentUpdateConfigurationProperties()); set => this._sessionHostComponentUpdateConfiguration = value; }

        /// <summary>The type of maintenance for session host components.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType? SessionHostComponentUpdateConfigurationMaintenanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).MaintenanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).MaintenanceType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostComponentUpdateType)""); }

        /// <summary>
        /// Time zone for maintenance as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string SessionHostComponentUpdateConfigurationMaintenanceWindowTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).MaintenanceWindowTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).MaintenanceWindowTimeZone = value ?? null; }

        /// <summary>Whether to use localTime of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public bool? SessionHostComponentUpdateConfigurationUseSessionHostLocalTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).UseSessionHostLocalTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostComponentUpdateConfigurationPropertiesInternal)SessionHostComponentUpdateConfiguration).UseSessionHostLocalTime = value ?? default(bool); }

        /// <summary>Backing field for <see cref="SsoClientId" /> property.</summary>
        private string _ssoClientId;

        /// <summary>ClientId for the registered Relying Party used to issue WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string SsoClientId { get => this._ssoClientId; set => this._ssoClientId = value; }

        /// <summary>Backing field for <see cref="SsoClientSecretKeyVaultPath" /> property.</summary>
        private string _ssoClientSecretKeyVaultPath;

        /// <summary>Path to Azure KeyVault storing the secret used for communication to ADFS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string SsoClientSecretKeyVaultPath { get => this._ssoClientSecretKeyVaultPath; set => this._ssoClientSecretKeyVaultPath = value; }

        /// <summary>Backing field for <see cref="SsoSecretType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType? _ssoSecretType;

        /// <summary>The type of single sign on Secret Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SsoSecretType? SsoSecretType { get => this._ssoSecretType; set => this._ssoSecretType = value; }

        /// <summary>Backing field for <see cref="SsoadfsAuthority" /> property.</summary>
        private string _ssoadfsAuthority;

        /// <summary>URL to customer ADFS server for signing WVD SSO certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string SsoadfsAuthority { get => this._ssoadfsAuthority; set => this._ssoadfsAuthority = value; }

        /// <summary>Backing field for <see cref="StartVMOnConnect" /> property.</summary>
        private bool? _startVMOnConnect;

        /// <summary>The flag to turn on/off StartVMOnConnect feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? StartVMOnConnect { get => this._startVMOnConnect; set => this._startVMOnConnect = value; }

        /// <summary>Backing field for <see cref="VMTemplate" /> property.</summary>
        private string _vMTemplate;

        /// <summary>VM template for sessionhosts configuration within hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string VMTemplate { get => this._vMTemplate; set => this._vMTemplate = value; }

        /// <summary>Backing field for <see cref="ValidationEnvironment" /> property.</summary>
        private bool? _validationEnvironment;

        /// <summary>Is validation environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? ValidationEnvironment { get => this._validationEnvironment; set => this._validationEnvironment = value; }

        /// <summary>Creates an new <see cref="HostPoolProperties" /> instance.</summary>
        public HostPoolProperties()
        {

        }
    }
    /// Properties of HostPool.
    public partial interface IHostPoolProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>List of applicationGroup links.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of applicationGroup links.",
        SerializedName = @"applicationGroupReferences",
        PossibleTypes = new [] { typeof(string) })]
        string[] ApplicationGroupReference { get;  }
        /// <summary>Is cloud pc resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Is cloud pc resource.",
        SerializedName = @"cloudPcResource",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CloudPcResource { get;  }
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
        /// <summary>HostPool type for desktop.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"HostPool type for desktop.",
        SerializedName = @"hostPoolType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType HostPoolType { get; set; }
        /// <summary>The type of the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of the load balancer.",
        SerializedName = @"loadBalancerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType LoadBalancerType { get; set; }
        /// <summary>The max session limit of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The max session limit of HostPool.",
        SerializedName = @"maxSessionLimit",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxSessionLimit { get; set; }
        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the legacy object to migrate.",
        SerializedName = @"migrationPath",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationRequestMigrationPath { get; set; }
        /// <summary>The type of operation for migration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operation for migration.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation? MigrationRequestOperation { get; set; }
        /// <summary>ObjectId of HostPool. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ObjectId of HostPool. (internal use)",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get;  }
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
        Required = true,
        ReadOnly = false,
        Description = @"The type of preferred application group type, default to Desktop Application Group",
        SerializedName = @"preferredAppGroupType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType PreferredAppGroupType { get; set; }
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
        /// <summary>
        /// Enabled allows this resource to be accessed from both public and private networks, Disabled allows this resource to only
        /// be accessed via private endpoints
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enabled allows this resource to be accessed from both public and private networks, Disabled allows this resource to only be accessed via private endpoints",
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
        /// <summary>The registration token base64 encoded string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The registration token base64 encoded string.",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationInfoToken { get; set; }
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
    /// Properties of HostPool.
    internal partial interface IHostPoolPropertiesInternal

    {
        /// <summary>List of applicationGroup links.</summary>
        string[] ApplicationGroupReference { get; set; }
        /// <summary>Is cloud pc resource.</summary>
        bool? CloudPcResource { get; set; }
        /// <summary>Custom rdp property of HostPool.</summary>
        string CustomRdpProperty { get; set; }
        /// <summary>Description of HostPool.</summary>
        string Description { get; set; }
        /// <summary>Friendly name of HostPool.</summary>
        string FriendlyName { get; set; }
        /// <summary>HostPool type for desktop.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType HostPoolType { get; set; }
        /// <summary>The type of the load balancer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.LoadBalancerType LoadBalancerType { get; set; }
        /// <summary>The max session limit of HostPool.</summary>
        int? MaxSessionLimit { get; set; }
        /// <summary>The registration info of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IMigrationRequestProperties MigrationRequest { get; set; }
        /// <summary>The path to the legacy object to migrate.</summary>
        string MigrationRequestMigrationPath { get; set; }
        /// <summary>The type of operation for migration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation? MigrationRequestOperation { get; set; }
        /// <summary>ObjectId of HostPool. (internal use)</summary>
        string ObjectId { get; set; }
        /// <summary>PersonalDesktopAssignment type for HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary>
        /// The type of preferred application group type, default to Desktop Application Group
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PreferredAppGroupType PreferredAppGroupType { get; set; }
        /// <summary>Day of the week.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.DayOfWeek? PrimaryWindowDayOfWeek { get; set; }
        /// <summary>The update start hour of the day. (0 - 23)</summary>
        int? PrimaryWindowHour { get; set; }
        /// <summary>
        /// Enabled allows this resource to be accessed from both public and private networks, Disabled allows this resource to only
        /// be accessed via private endpoints
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>The registration info of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IRegistrationInfo RegistrationInfo { get; set; }
        /// <summary>Expiration time of registration token.</summary>
        global::System.DateTime? RegistrationInfoExpirationTime { get; set; }
        /// <summary>The type of resetting the token.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.RegistrationTokenOperation? RegistrationInfoRegistrationTokenOperation { get; set; }
        /// <summary>The registration token base64 encoded string.</summary>
        string RegistrationInfoToken { get; set; }
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
        /// <summary>VM template for sessionhosts configuration within hostpool.</summary>
        string VMTemplate { get; set; }
        /// <summary>Is validation environment.</summary>
        bool? ValidationEnvironment { get; set; }

    }
}