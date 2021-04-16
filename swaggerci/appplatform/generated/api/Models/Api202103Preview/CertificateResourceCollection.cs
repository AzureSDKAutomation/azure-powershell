namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>
    /// Collection compose of certificate resources list and a possible link for next page.
    /// </summary>
    public partial class CertificateResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to next page of certificate list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResource[] _value;

        /// <summary>The certificate resources list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CertificateResourceCollection" /> instance.</summary>
        public CertificateResourceCollection()
        {

        }
    }
    /// Collection compose of certificate resources list and a possible link for next page.
    public partial interface ICertificateResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The link to next page of certificate list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to next page of certificate list.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The certificate resources list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The certificate resources list.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResource[] Value { get; set; }

    }
    /// Collection compose of certificate resources list and a possible link for next page.
    internal partial interface ICertificateResourceCollectionInternal

    {
        /// <summary>The link to next page of certificate list.</summary>
        string NextLink { get; set; }
        /// <summary>The certificate resources list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ICertificateResource[] Value { get; set; }

    }
}