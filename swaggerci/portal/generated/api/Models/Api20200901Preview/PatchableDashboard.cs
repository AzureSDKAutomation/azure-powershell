namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>The shared dashboard resource definition.</summary>
    public partial class PatchableDashboard :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboard,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardInternal
    {

        /// <summary>The dashboard lenses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLens[] Lens { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesInternal)Property).Lens; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesInternal)Property).Lens = value ?? null /* arrayOf */; }

        /// <summary>The dashboard metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesMetadata Metadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesInternal)Property).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesInternal)Property).Metadata = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardProperties Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardProperties _property;

        /// <summary>The shared dashboard properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.DashboardProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.PatchableDashboardTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PatchableDashboard" /> instance.</summary>
        public PatchableDashboard()
        {

        }
    }
    /// The shared dashboard resource definition.
    public partial interface IPatchableDashboard :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
    {
        /// <summary>The dashboard lenses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dashboard lenses.",
        SerializedName = @"lenses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLens) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLens[] Lens { get; set; }
        /// <summary>The dashboard metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dashboard metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesMetadata Metadata { get; set; }
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardTags Tag { get; set; }

    }
    /// The shared dashboard resource definition.
    internal partial interface IPatchableDashboardInternal

    {
        /// <summary>The dashboard lenses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardLens[] Lens { get; set; }
        /// <summary>The dashboard metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardPropertiesMetadata Metadata { get; set; }
        /// <summary>The shared dashboard properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IDashboardProperties Property { get; set; }
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IPatchableDashboardTags Tag { get; set; }

    }
}