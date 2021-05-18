namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the properties of a Machine Extension.</summary>
    public partial class MachineExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>Backing field for <see cref="ForceUpdateTag" /> property.</summary>
        private string _forceUpdateTag;

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ForceUpdateTag { get => this._forceUpdateTag; set => this._forceUpdateTag = value; }

        /// <summary>Backing field for <see cref="InstanceView" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceView _instanceView;

        /// <summary>The machine extension instance view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceView InstanceView { get => (this._instanceView = this._instanceView ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.MachineExtensionInstanceView()); set => this._instanceView = value; }

        /// <summary>The machine extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Name = value ?? null; }

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Type = value ?? null; }

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string InstanceViewTypeHandlerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).TypeHandlerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).TypeHandlerVersion = value ?? null; }

        /// <summary>Internal Acessors for InstanceView</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceView Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionPropertiesInternal.InstanceView { get => (this._instanceView = this._instanceView ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.MachineExtensionInstanceView()); set { {_instanceView = value;} } }

        /// <summary>Internal Acessors for InstanceViewStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewStatus Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionPropertiesInternal.InstanceViewStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).Status = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny _protectedSetting;

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny ProtectedSetting { get => (this._protectedSetting = this._protectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Any()); set => this._protectedSetting = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny _setting;

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.IAny Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Any()); set => this._setting = value; }

        /// <summary>The status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusCode = value ?? null; }

        /// <summary>The short localizable label for the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusDisplayStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusDisplayStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusDisplayStatus = value ?? null; }

        /// <summary>The level code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes? StatusLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusLevel = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Support.StatusLevelTypes)""); }

        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public string StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusMessage = value ?? null; }

        /// <summary>The time of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewInternal)InstanceView).StatusTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="TypeHandlerVersion" /> property.</summary>
        private string _typeHandlerVersion;

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string TypeHandlerVersion { get => this._typeHandlerVersion; set => this._typeHandlerVersion = value; }

        /// <summary>Creates an new <see cref="MachineExtensionProperties" /> instance.</summary>
        public MachineExtensionProperties()
        {

        }
    }
    /// Describes the properties of a Machine Extension.
    public partial interface IMachineExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
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
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the version of the script handler.",
        SerializedName = @"typeHandlerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TypeHandlerVersion { get; set; }

    }
    /// Describes the properties of a Machine Extension.
    internal partial interface IMachineExtensionPropertiesInternal

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
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceView InstanceView { get; set; }
        /// <summary>The machine extension name.</summary>
        string InstanceViewName { get; set; }
        /// <summary>Instance view status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IMachineExtensionInstanceViewStatus InstanceViewStatus { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string InstanceViewType { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string InstanceViewTypeHandlerVersion { get; set; }
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
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string TypeHandlerVersion { get; set; }

    }
}