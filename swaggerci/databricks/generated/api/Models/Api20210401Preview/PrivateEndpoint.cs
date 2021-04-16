namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The private endpoint property of a private endpoint connection</summary>
    public partial class PrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IPrivateEndpointInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Creates an new <see cref="PrivateEndpoint" /> instance.</summary>
        public PrivateEndpoint()
        {

        }
    }
    /// The private endpoint property of a private endpoint connection
    public partial interface IPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }

    }
    /// The private endpoint property of a private endpoint connection
    internal partial interface IPrivateEndpointInternal

    {
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }

    }
}