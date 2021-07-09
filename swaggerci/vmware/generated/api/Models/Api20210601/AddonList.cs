namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Extensions;

    /// <summary>A paged list of addons</summary>
    public partial class AddonList :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonList,
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon[] Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddonListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon[] _value;

        /// <summary>The items on a page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="AddonList" /> instance.</summary>
        public AddonList()
        {

        }
    }
    /// A paged list of addons
    public partial interface IAddonList :
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next page if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next page if any",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The items on a page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The items on a page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon[] Value { get;  }

    }
    /// A paged list of addons
    internal partial interface IAddonListInternal

    {
        /// <summary>URL to get the next page if any</summary>
        string NextLink { get; set; }
        /// <summary>The items on a page</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IAddon[] Value { get; set; }

    }
}