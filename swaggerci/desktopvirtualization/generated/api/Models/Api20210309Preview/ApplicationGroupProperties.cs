namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Schema for ApplicationGroup properties.</summary>
    public partial class ApplicationGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGroupType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType _applicationGroupType;

        /// <summary>Resource Type of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType ApplicationGroupType { get => this._applicationGroupType; set => this._applicationGroupType = value; }

        /// <summary>Backing field for <see cref="CloudPcResource" /> property.</summary>
        private bool? _cloudPcResource;

        /// <summary>Is cloud pc resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? CloudPcResource { get => this._cloudPcResource; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="HostPoolArmPath" /> property.</summary>
        private string _hostPoolArmPath;

        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string HostPoolArmPath { get => this._hostPoolArmPath; set => this._hostPoolArmPath = value; }

        /// <summary>Internal Acessors for CloudPcResource</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupPropertiesInternal.CloudPcResource { get => this._cloudPcResource; set { {_cloudPcResource = value;} } }

        /// <summary>Internal Acessors for MigrationRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupPropertiesInternal.MigrationRequest { get => (this._migrationRequest = this._migrationRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.MigrationRequestProperties()); set { {_migrationRequest = value;} } }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupPropertiesInternal.ObjectId { get => this._objectId; set { {_objectId = value;} } }

        /// <summary>Internal Acessors for WorkspaceArmPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IApplicationGroupPropertiesInternal.WorkspaceArmPath { get => this._workspaceArmPath; set { {_workspaceArmPath = value;} } }

        /// <summary>Backing field for <see cref="MigrationRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestProperties _migrationRequest;

        /// <summary>The registration info of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestProperties MigrationRequest { get => (this._migrationRequest = this._migrationRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.MigrationRequestProperties()); set => this._migrationRequest = value; }

        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string MigrationRequestMigrationPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestPropertiesInternal)MigrationRequest).MigrationPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestPropertiesInternal)MigrationRequest).MigrationPath = value ?? null; }

        /// <summary>The type of operation for migration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation? MigrationRequestOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestPropertiesInternal)MigrationRequest).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestPropertiesInternal)MigrationRequest).Operation = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation)""); }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>ObjectId of ApplicationGroup. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; }

        /// <summary>Backing field for <see cref="WorkspaceArmPath" /> property.</summary>
        private string _workspaceArmPath;

        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string WorkspaceArmPath { get => this._workspaceArmPath; }

        /// <summary>Creates an new <see cref="ApplicationGroupProperties" /> instance.</summary>
        public ApplicationGroupProperties()
        {

        }
    }
    /// Schema for ApplicationGroup properties.
    public partial interface IApplicationGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Resource Type of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource Type of ApplicationGroup.",
        SerializedName = @"applicationGroupType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType ApplicationGroupType { get; set; }
        /// <summary>Is cloud pc resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Is cloud pc resource.",
        SerializedName = @"cloudPcResource",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CloudPcResource { get;  }
        /// <summary>Description of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of ApplicationGroup.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Friendly name of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of ApplicationGroup.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"HostPool arm path of ApplicationGroup.",
        SerializedName = @"hostPoolArmPath",
        PossibleTypes = new [] { typeof(string) })]
        string HostPoolArmPath { get; set; }
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
        /// <summary>ObjectId of ApplicationGroup. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ObjectId of ApplicationGroup. (internal use)",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get;  }
        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Workspace arm path of ApplicationGroup.",
        SerializedName = @"workspaceArmPath",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceArmPath { get;  }

    }
    /// Schema for ApplicationGroup properties.
    internal partial interface IApplicationGroupPropertiesInternal

    {
        /// <summary>Resource Type of ApplicationGroup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationGroupType ApplicationGroupType { get; set; }
        /// <summary>Is cloud pc resource.</summary>
        bool? CloudPcResource { get; set; }
        /// <summary>Description of ApplicationGroup.</summary>
        string Description { get; set; }
        /// <summary>Friendly name of ApplicationGroup.</summary>
        string FriendlyName { get; set; }
        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        string HostPoolArmPath { get; set; }
        /// <summary>The registration info of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IMigrationRequestProperties MigrationRequest { get; set; }
        /// <summary>The path to the legacy object to migrate.</summary>
        string MigrationRequestMigrationPath { get; set; }
        /// <summary>The type of operation for migration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Operation? MigrationRequestOperation { get; set; }
        /// <summary>ObjectId of ApplicationGroup. (internal use)</summary>
        string ObjectId { get; set; }
        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        string WorkspaceArmPath { get; set; }

    }
}