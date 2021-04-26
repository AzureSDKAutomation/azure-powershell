namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Schema for StartMenuItem properties.</summary>
    public partial class StartMenuItemProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IStartMenuItemProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IStartMenuItemPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AppAlias" /> property.</summary>
        private string _appAlias;

        /// <summary>Alias of StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string AppAlias { get => this._appAlias; set => this._appAlias = value; }

        /// <summary>Backing field for <see cref="CommandLineArgument" /> property.</summary>
        private string _commandLineArgument;

        /// <summary>Command line arguments for StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string CommandLineArgument { get => this._commandLineArgument; set => this._commandLineArgument = value; }

        /// <summary>Backing field for <see cref="FilePath" /> property.</summary>
        private string _filePath;

        /// <summary>Path to the file of StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FilePath { get => this._filePath; set => this._filePath = value; }

        /// <summary>Backing field for <see cref="IconIndex" /> property.</summary>
        private int? _iconIndex;

        /// <summary>Index of the icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? IconIndex { get => this._iconIndex; set => this._iconIndex = value; }

        /// <summary>Backing field for <see cref="IconPath" /> property.</summary>
        private string _iconPath;

        /// <summary>Path to the icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string IconPath { get => this._iconPath; set => this._iconPath = value; }

        /// <summary>Creates an new <see cref="StartMenuItemProperties" /> instance.</summary>
        public StartMenuItemProperties()
        {

        }
    }
    /// Schema for StartMenuItem properties.
    public partial interface IStartMenuItemProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Alias of StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Alias of StartMenuItem.",
        SerializedName = @"appAlias",
        PossibleTypes = new [] { typeof(string) })]
        string AppAlias { get; set; }
        /// <summary>Command line arguments for StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Command line arguments for StartMenuItem.",
        SerializedName = @"commandLineArguments",
        PossibleTypes = new [] { typeof(string) })]
        string CommandLineArgument { get; set; }
        /// <summary>Path to the file of StartMenuItem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the file of StartMenuItem.",
        SerializedName = @"filePath",
        PossibleTypes = new [] { typeof(string) })]
        string FilePath { get; set; }
        /// <summary>Index of the icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Index of the icon.",
        SerializedName = @"iconIndex",
        PossibleTypes = new [] { typeof(int) })]
        int? IconIndex { get; set; }
        /// <summary>Path to the icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the icon.",
        SerializedName = @"iconPath",
        PossibleTypes = new [] { typeof(string) })]
        string IconPath { get; set; }

    }
    /// Schema for StartMenuItem properties.
    internal partial interface IStartMenuItemPropertiesInternal

    {
        /// <summary>Alias of StartMenuItem.</summary>
        string AppAlias { get; set; }
        /// <summary>Command line arguments for StartMenuItem.</summary>
        string CommandLineArgument { get; set; }
        /// <summary>Path to the file of StartMenuItem.</summary>
        string FilePath { get; set; }
        /// <summary>Index of the icon.</summary>
        int? IconIndex { get; set; }
        /// <summary>Path to the icon.</summary>
        string IconPath { get; set; }

    }
}