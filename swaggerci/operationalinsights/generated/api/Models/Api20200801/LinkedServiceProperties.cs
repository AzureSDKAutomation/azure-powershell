namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Linked service properties.</summary>
    public partial class LinkedServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServiceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ILinkedServicePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? _provisioningState;

        /// <summary>The provisioning state of the linked service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="WriteAccessResourceId" /> property.</summary>
        private string _writeAccessResourceId;

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string WriteAccessResourceId { get => this._writeAccessResourceId; set => this._writeAccessResourceId = value; }

        /// <summary>Creates an new <see cref="LinkedServiceProperties" /> instance.</summary>
        public LinkedServiceProperties()
        {

        }
    }
    /// Linked service properties.
    public partial interface ILinkedServiceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state of the linked service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provisioning state of the linked service.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require read access",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the resource that will be linked to the workspace. This should be used for linking resources which require write access",
        SerializedName = @"writeAccessResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string WriteAccessResourceId { get; set; }

    }
    /// Linked service properties.
    internal partial interface ILinkedServicePropertiesInternal

    {
        /// <summary>The provisioning state of the linked service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.LinkedServiceEntityStatus? ProvisioningState { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require read access
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This should be used for linking resources which
        /// require write access
        /// </summary>
        string WriteAccessResourceId { get; set; }

    }
}