namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Regenerate test key request payload</summary>
    public partial class RegenerateTestKeyRequestPayload :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRegenerateTestKeyRequestPayload,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IRegenerateTestKeyRequestPayloadInternal
    {

        /// <summary>Backing field for <see cref="KeyType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TestKeyType _keyType;

        /// <summary>Type of the test key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TestKeyType KeyType { get => this._keyType; set => this._keyType = value; }

        /// <summary>Creates an new <see cref="RegenerateTestKeyRequestPayload" /> instance.</summary>
        public RegenerateTestKeyRequestPayload()
        {

        }
    }
    /// Regenerate test key request payload
    public partial interface IRegenerateTestKeyRequestPayload :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Type of the test key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of the test key",
        SerializedName = @"keyType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TestKeyType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TestKeyType KeyType { get; set; }

    }
    /// Regenerate test key request payload
    internal partial interface IRegenerateTestKeyRequestPayloadInternal

    {
        /// <summary>Type of the test key</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TestKeyType KeyType { get; set; }

    }
}