namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>
    /// Result of the request to check name availability. It contains a flag and possible reason of failure.
    /// </summary>
    public partial class NameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.INameAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.INameAvailabilityInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The message of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>Indicates whether the name is available or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>The reason of the availability. Required if name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="NameAvailability" /> instance.</summary>
        public NameAvailability()
        {

        }
    }
    /// Result of the request to check name availability. It contains a flag and possible reason of failure.
    public partial interface INameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>The message of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message of the operation.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Indicates whether the name is available or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the name is available or not.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>The reason of the availability. Required if name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason of the availability. Required if name is not available.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get; set; }

    }
    /// Result of the request to check name availability. It contains a flag and possible reason of failure.
    internal partial interface INameAvailabilityInternal

    {
        /// <summary>The message of the operation.</summary>
        string Message { get; set; }
        /// <summary>Indicates whether the name is available or not.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason of the availability. Required if name is not available.</summary>
        string Reason { get; set; }

    }
}