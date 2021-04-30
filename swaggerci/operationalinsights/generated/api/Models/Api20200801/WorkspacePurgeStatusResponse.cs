namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Response containing status for a specific purge operation.</summary>
    public partial class WorkspacePurgeStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeStatusResponse,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspacePurgeStatusResponseInternal
    {

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState _status;

        /// <summary>Status of the operation represented by the requested Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="WorkspacePurgeStatusResponse" /> instance.</summary>
        public WorkspacePurgeStatusResponse()
        {

        }
    }
    /// Response containing status for a specific purge operation.
    public partial interface IWorkspacePurgeStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Status of the operation represented by the requested Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Status of the operation represented by the requested Id.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState Status { get; set; }

    }
    /// Response containing status for a specific purge operation.
    internal partial interface IWorkspacePurgeStatusResponseInternal

    {
        /// <summary>Status of the operation represented by the requested Id.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.PurgeState Status { get; set; }

    }
}