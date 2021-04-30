namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Error record of the config server settings</summary>
    public partial class ConfigServerSettingsErrorRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecord,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IConfigServerSettingsErrorRecordInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string[] _message;

        /// <summary>The detail error messages of the record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the config server settings error record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>The uri of the config server settings error record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="ConfigServerSettingsErrorRecord" /> instance.</summary>
        public ConfigServerSettingsErrorRecord()
        {

        }
    }
    /// Error record of the config server settings
    public partial interface IConfigServerSettingsErrorRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The detail error messages of the record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detail error messages of the record",
        SerializedName = @"messages",
        PossibleTypes = new [] { typeof(string) })]
        string[] Message { get; set; }
        /// <summary>The name of the config server settings error record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the config server settings error record",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The uri of the config server settings error record</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri of the config server settings error record",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Error record of the config server settings
    internal partial interface IConfigServerSettingsErrorRecordInternal

    {
        /// <summary>The detail error messages of the record</summary>
        string[] Message { get; set; }
        /// <summary>The name of the config server settings error record</summary>
        string Name { get; set; }
        /// <summary>The uri of the config server settings error record</summary>
        string Uri { get; set; }

    }
}