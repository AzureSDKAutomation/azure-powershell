namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Workspace properties that can be patched.</summary>
    public partial class WorkspacePatch :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatch,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchInternal
    {

        /// <summary>List of applicationGroup links.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string[] ApplicationGroupReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).ApplicationGroupReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).ApplicationGroupReference = value ?? null /* arrayOf */; }

        /// <summary>Description of Workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Friendly name of Workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchPropertiesInternal)Property).FriendlyName = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.WorkspacePatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchProperties _property;

        /// <summary>Detailed properties for Workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.WorkspacePatchProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchTags _tag;

        /// <summary>tags to be updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.WorkspacePatchTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="WorkspacePatch" /> instance.</summary>
        public WorkspacePatch()
        {

        }
    }
    /// Workspace properties that can be patched.
    public partial interface IWorkspacePatch :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>List of applicationGroup links.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of applicationGroup links.",
        SerializedName = @"applicationGroupReferences",
        PossibleTypes = new [] { typeof(string) })]
        string[] ApplicationGroupReference { get; set; }
        /// <summary>Description of Workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of Workspace.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Friendly name of Workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of Workspace.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>tags to be updated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"tags to be updated",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchTags Tag { get; set; }

    }
    /// Workspace properties that can be patched.
    internal partial interface IWorkspacePatchInternal

    {
        /// <summary>List of applicationGroup links.</summary>
        string[] ApplicationGroupReference { get; set; }
        /// <summary>Description of Workspace.</summary>
        string Description { get; set; }
        /// <summary>Friendly name of Workspace.</summary>
        string FriendlyName { get; set; }
        /// <summary>Detailed properties for Workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchProperties Property { get; set; }
        /// <summary>tags to be updated</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IWorkspacePatchTags Tag { get; set; }

    }
}