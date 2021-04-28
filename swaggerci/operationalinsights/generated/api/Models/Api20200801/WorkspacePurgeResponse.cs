namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Response containing operationId for a specific purge action.</summary>
    public partial class WorkspacePurgeResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponse,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>Id to use when querying for status for a particular purge operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="XmsStatusLocation" /> property.</summary>
        private string _xmsStatusLocation;

        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string XmsStatusLocation { get => this._xmsStatusLocation; set => this._xmsStatusLocation = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("x-ms-status-location", out var __xMSStatusLocationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeResponseInternal)this).XmsStatusLocation = System.Linq.Enumerable.FirstOrDefault(__xMSStatusLocationHeader0) is string __headerXMSStatusLocationHeader0 ? __headerXMSStatusLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="WorkspacePurgeResponse" /> instance.</summary>
        public WorkspacePurgeResponse()
        {

        }
    }
    /// Response containing operationId for a specific purge action.
    public partial interface IWorkspacePurgeResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Id to use when querying for status for a particular purge operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Id to use when querying for status for a particular purge operation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"x-ms-status-location",
        PossibleTypes = new [] { typeof(string) })]
        string XmsStatusLocation { get; set; }

    }
    /// Response containing operationId for a specific purge action.
    internal partial interface IWorkspacePurgeResponseInternal

    {
        /// <summary>Id to use when querying for status for a particular purge operation.</summary>
        string OperationId { get; set; }

        string XmsStatusLocation { get; set; }

    }
}