namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>List of private link connections.</summary>
    public partial class PrivateEndpointConnectionsList :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionsList,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnectionsListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] _value;

        /// <summary>The list of returned private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionsList" /> instance.</summary>
        public PrivateEndpointConnectionsList()
        {

        }
    }
    /// List of private link connections.
    public partial interface IPrivateEndpointConnectionsList :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to get the next set of endpoint connections.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of returned private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of returned private endpoint connection.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] Value { get; set; }

    }
    /// List of private link connections.
    internal partial interface IPrivateEndpointConnectionsListInternal

    {
        /// <summary>The URL to get the next set of endpoint connections.</summary>
        string NextLink { get; set; }
        /// <summary>The list of returned private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointConnection[] Value { get; set; }

    }
}