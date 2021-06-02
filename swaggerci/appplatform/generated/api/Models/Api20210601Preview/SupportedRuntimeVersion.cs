namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Supported deployment runtime version descriptor.</summary>
    public partial class SupportedRuntimeVersion :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISupportedRuntimeVersion,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ISupportedRuntimeVersionInternal
    {

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimePlatform? _platform;

        /// <summary>The platform of this runtime version (possible values: "Java" or ".NET").</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimePlatform? Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimeValue? _value;

        /// <summary>The raw value which could be passed to deployment CRUD operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimeValue? Value { get => this._value; set => this._value = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The detailed version (major.minor) of the platform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SupportedRuntimeVersion" /> instance.</summary>
        public SupportedRuntimeVersion()
        {

        }
    }
    /// Supported deployment runtime version descriptor.
    public partial interface ISupportedRuntimeVersion :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The platform of this runtime version (possible values: "Java" or ".NET").</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The platform of this runtime version (possible values: ""Java"" or "".NET"").",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimePlatform) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimePlatform? Platform { get; set; }
        /// <summary>The raw value which could be passed to deployment CRUD operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The raw value which could be passed to deployment CRUD operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimeValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimeValue? Value { get; set; }
        /// <summary>The detailed version (major.minor) of the platform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detailed version (major.minor) of the platform.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Supported deployment runtime version descriptor.
    internal partial interface ISupportedRuntimeVersionInternal

    {
        /// <summary>The platform of this runtime version (possible values: "Java" or ".NET").</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimePlatform? Platform { get; set; }
        /// <summary>The raw value which could be passed to deployment CRUD operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.SupportedRuntimeValue? Value { get; set; }
        /// <summary>The detailed version (major.minor) of the platform.</summary>
        string Version { get; set; }

    }
}