namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>Data POST-ed to the nameAvailability action</summary>
    public partial class NameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.INameAvailabilityParameters,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.INameAvailabilityParametersInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The CommunicationService name to validate. e.g."my-CommunicationService-name-here"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The resource type. Should be always "Microsoft.Communication/CommunicationServices".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="NameAvailabilityParameters" /> instance.</summary>
        public NameAvailabilityParameters()
        {

        }
    }
    /// Data POST-ed to the nameAvailability action
    public partial interface INameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The CommunicationService name to validate. e.g."my-CommunicationService-name-here"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The CommunicationService name to validate. e.g.""my-CommunicationService-name-here""",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The resource type. Should be always "Microsoft.Communication/CommunicationServices".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource type. Should be always ""Microsoft.Communication/CommunicationServices"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Data POST-ed to the nameAvailability action
    internal partial interface INameAvailabilityParametersInternal

    {
        /// <summary>
        /// The CommunicationService name to validate. e.g."my-CommunicationService-name-here"
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The resource type. Should be always "Microsoft.Communication/CommunicationServices".
        /// </summary>
        string Type { get; set; }

    }
}