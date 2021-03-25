namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Extensions;

    public partial class MoveResourceFilterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveResourceFilterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IMoveResourceFilterPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="MoveResourceFilterProperties" /> instance.</summary>
        public MoveResourceFilterProperties()
        {

        }
    }
    public partial interface IMoveResourceFilterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IJsonSerializable
    {
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }

    }
    internal partial interface IMoveResourceFilterPropertiesInternal

    {
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }

    }
}