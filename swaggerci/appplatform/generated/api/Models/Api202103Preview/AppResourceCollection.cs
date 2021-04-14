namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Object that includes an array of App resources and a possible link for next set</summary>
    public partial class AppResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResource[] _value;

        /// <summary>Collection of App resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AppResourceCollection" /> instance.</summary>
        public AppResourceCollection()
        {

        }
    }
    /// Object that includes an array of App resources and a possible link for next set
    public partial interface IAppResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL client should use to fetch the next page (per server side paging).
        It's null for now, added for future use.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of App resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of App resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResource[] Value { get; set; }

    }
    /// Object that includes an array of App resources and a possible link for next set
    internal partial interface IAppResourceCollectionInternal

    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Collection of App resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IAppResource[] Value { get; set; }

    }
}