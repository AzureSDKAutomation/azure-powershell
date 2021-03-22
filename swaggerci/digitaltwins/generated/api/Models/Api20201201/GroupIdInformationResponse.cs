namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The available private link resources for a Digital Twin.</summary>
    public partial class GroupIdInformationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformationResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformation[] _value;

        /// <summary>The list of available private link resources for a Digital Twin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="GroupIdInformationResponse" /> instance.</summary>
        public GroupIdInformationResponse()
        {

        }
    }
    /// The available private link resources for a Digital Twin.
    public partial interface IGroupIdInformationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The list of available private link resources for a Digital Twin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of available private link resources for a Digital Twin.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformation[] Value { get; set; }

    }
    /// The available private link resources for a Digital Twin.
    internal partial interface IGroupIdInformationResponseInternal

    {
        /// <summary>The list of available private link resources for a Digital Twin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IGroupIdInformation[] Value { get; set; }

    }
}