namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>List of StartMenuItem definitions.</summary>
    public partial class StartMenuItemList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemList,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItem[] _value;

        /// <summary>List of StartMenuItem definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItem[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="StartMenuItemList" /> instance.</summary>
        public StartMenuItemList()
        {

        }
    }
    /// List of StartMenuItem definitions.
    public partial interface IStartMenuItemList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of StartMenuItem definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of StartMenuItem definitions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItem[] Value { get; set; }

    }
    /// List of StartMenuItem definitions.
    internal partial interface IStartMenuItemListInternal

    {
        /// <summary>Link to the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>List of StartMenuItem definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItem[] Value { get; set; }

    }
}