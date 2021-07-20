namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Properties that are common to all tracked resources.</summary>
    public partial class ResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private global::System.DateTime? _creationTime;

        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationTime { get => this._creationTime; }

        /// <summary>Internal Acessors for CreationTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.CreationTime { get => this._creationTime; set { {_creationTime = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="ResourceProperties" /> instance.</summary>
        public ResourceProperties()
        {

        }
    }
    /// Properties that are common to all tracked resources.
    public partial interface IResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>The time the resource was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time the resource was created.",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationTime { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Properties that are common to all tracked resources.
    internal partial interface IResourcePropertiesInternal

    {
        /// <summary>The time the resource was created.</summary>
        global::System.DateTime? CreationTime { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}