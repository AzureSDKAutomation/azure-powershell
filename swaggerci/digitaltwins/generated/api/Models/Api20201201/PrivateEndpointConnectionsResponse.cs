namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The available private link connections for a Digital Twin.</summary>
    public partial class PrivateEndpointConnectionsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnectionsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] _value;

        /// <summary>The list of available private link connections for a Digital Twin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionsResponse" /> instance.</summary>
        public PrivateEndpointConnectionsResponse()
        {

        }
    }
    /// The available private link connections for a Digital Twin.
    public partial interface IPrivateEndpointConnectionsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The list of available private link connections for a Digital Twin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of available private link connections for a Digital Twin.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] Value { get; set; }

    }
    /// The available private link connections for a Digital Twin.
    internal partial interface IPrivateEndpointConnectionsResponseInternal

    {
        /// <summary>The list of available private link connections for a Digital Twin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] Value { get; set; }

    }
}