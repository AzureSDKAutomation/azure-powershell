namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Status from this instance of the extension.</summary>
    public partial class ExtensionStatus :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionStatus,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20200701Preview.IExtensionStatusInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Status code provided by the Extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="DisplayStatus" /> property.</summary>
        private string _displayStatus;

        /// <summary>Short description of status of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string DisplayStatus { get => this._displayStatus; set => this._displayStatus = value; }

        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.LevelType? _level;

        /// <summary>Level of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.LevelType? Level { get => this._level; set => this._level = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Detailed message of the status from the Extension instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private string _time;

        /// <summary>DateLiteral (per ISO8601) noting the time of installation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string Time { get => this._time; set => this._time = value; }

        /// <summary>Creates an new <see cref="ExtensionStatus" /> instance.</summary>
        public ExtensionStatus()
        {

        }
    }
    /// Status from this instance of the extension.
    public partial interface IExtensionStatus :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Status code provided by the Extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status code provided by the Extension",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>Short description of status of this instance of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Short description of status of this instance of the extension.",
        SerializedName = @"displayStatus",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayStatus { get; set; }
        /// <summary>Level of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Level of the status.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.LevelType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.LevelType? Level { get; set; }
        /// <summary>Detailed message of the status from the Extension instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Detailed message of the status from the Extension instance.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>DateLiteral (per ISO8601) noting the time of installation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DateLiteral (per ISO8601) noting the time of installation status.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(string) })]
        string Time { get; set; }

    }
    /// Status from this instance of the extension.
    internal partial interface IExtensionStatusInternal

    {
        /// <summary>Status code provided by the Extension</summary>
        string Code { get; set; }
        /// <summary>Short description of status of this instance of the extension.</summary>
        string DisplayStatus { get; set; }
        /// <summary>Level of the status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Support.LevelType? Level { get; set; }
        /// <summary>Detailed message of the status from the Extension instance.</summary>
        string Message { get; set; }
        /// <summary>DateLiteral (per ISO8601) noting the time of installation status.</summary>
        string Time { get; set; }

    }
}