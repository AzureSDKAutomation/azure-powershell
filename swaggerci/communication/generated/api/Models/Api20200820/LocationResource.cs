namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>An ARM resource with its own location (not a global or an inherited location).</summary>
    public partial class LocationResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILocationResourceInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The Azure location where the CommunicationService is running.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Creates an new <see cref="LocationResource" /> instance.</summary>
        public LocationResource()
        {

        }
    }
    /// An ARM resource with its own location (not a global or an inherited location).
    public partial interface ILocationResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>The Azure location where the CommunicationService is running.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure location where the CommunicationService is running.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    /// An ARM resource with its own location (not a global or an inherited location).
    internal partial interface ILocationResourceInternal

    {
        /// <summary>The Azure location where the CommunicationService is running.</summary>
        string Location { get; set; }

    }
}