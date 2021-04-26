namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>Parameters describes the request to regenerate access keys</summary>
    public partial class RegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IRegenerateKeyParameters,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.IRegenerateKeyParametersInternal
    {

        /// <summary>Backing field for <see cref="KeyType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType? _keyType;

        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType? KeyType { get => this._keyType; set => this._keyType = value; }

        /// <summary>Creates an new <see cref="RegenerateKeyParameters" /> instance.</summary>
        public RegenerateKeyParameters()
        {

        }
    }
    /// Parameters describes the request to regenerate access keys
    public partial interface IRegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).",
        SerializedName = @"keyType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType? KeyType { get; set; }

    }
    /// Parameters describes the request to regenerate access keys
    internal partial interface IRegenerateKeyParametersInternal

    {
        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Support.KeyType? KeyType { get; set; }

    }
}