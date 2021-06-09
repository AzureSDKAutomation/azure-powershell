namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Test keys payload</summary>
    public partial class TestKeys :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ITestKeys,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ITestKeysInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Indicates whether the test endpoint feature enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="PrimaryKey" /> property.</summary>
        private string _primaryKey;

        /// <summary>Primary key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string PrimaryKey { get => this._primaryKey; set => this._primaryKey = value; }

        /// <summary>Backing field for <see cref="PrimaryTestEndpoint" /> property.</summary>
        private string _primaryTestEndpoint;

        /// <summary>Primary test endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string PrimaryTestEndpoint { get => this._primaryTestEndpoint; set => this._primaryTestEndpoint = value; }

        /// <summary>Backing field for <see cref="SecondaryKey" /> property.</summary>
        private string _secondaryKey;

        /// <summary>Secondary key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string SecondaryKey { get => this._secondaryKey; set => this._secondaryKey = value; }

        /// <summary>Backing field for <see cref="SecondaryTestEndpoint" /> property.</summary>
        private string _secondaryTestEndpoint;

        /// <summary>Secondary test endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string SecondaryTestEndpoint { get => this._secondaryTestEndpoint; set => this._secondaryTestEndpoint = value; }

        /// <summary>Creates an new <see cref="TestKeys" /> instance.</summary>
        public TestKeys()
        {

        }
    }
    /// Test keys payload
    public partial interface ITestKeys :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether the test endpoint feature enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the test endpoint feature enabled or not",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>Primary key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary key",
        SerializedName = @"primaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKey { get; set; }
        /// <summary>Primary test endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary test endpoint",
        SerializedName = @"primaryTestEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryTestEndpoint { get; set; }
        /// <summary>Secondary key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Secondary key",
        SerializedName = @"secondaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKey { get; set; }
        /// <summary>Secondary test endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Secondary test endpoint",
        SerializedName = @"secondaryTestEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryTestEndpoint { get; set; }

    }
    /// Test keys payload
    internal partial interface ITestKeysInternal

    {
        /// <summary>Indicates whether the test endpoint feature enabled or not</summary>
        bool? Enabled { get; set; }
        /// <summary>Primary key</summary>
        string PrimaryKey { get; set; }
        /// <summary>Primary test endpoint</summary>
        string PrimaryTestEndpoint { get; set; }
        /// <summary>Secondary key</summary>
        string SecondaryKey { get; set; }
        /// <summary>Secondary test endpoint</summary>
        string SecondaryTestEndpoint { get; set; }

    }
}