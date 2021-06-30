namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The available private link resources for a workspace</summary>
    public partial class PrivateLinkResourcesList :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateLinkResourcesList,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateLinkResourcesListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation[] _value;

        /// <summary>The list of available private link resources for a workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourcesList" /> instance.</summary>
        public PrivateLinkResourcesList()
        {

        }
    }
    /// The available private link resources for a workspace
    public partial interface IPrivateLinkResourcesList :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to get the next set of private link resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of available private link resources for a workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of available private link resources for a workspace",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation[] Value { get; set; }

    }
    /// The available private link resources for a workspace
    internal partial interface IPrivateLinkResourcesListInternal

    {
        /// <summary>The URL to get the next set of private link resources.</summary>
        string NextLink { get; set; }
        /// <summary>The list of available private link resources for a workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IGroupIdInformation[] Value { get; set; }

    }
}