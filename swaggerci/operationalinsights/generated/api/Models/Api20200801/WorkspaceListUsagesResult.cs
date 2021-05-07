namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list workspace usages operation response.</summary>
    public partial class WorkspaceListUsagesResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspaceListUsagesResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspaceListUsagesResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric[] _value;

        /// <summary>Gets or sets a list of usage metrics for a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WorkspaceListUsagesResult" /> instance.</summary>
        public WorkspaceListUsagesResult()
        {

        }
    }
    /// The list workspace usages operation response.
    public partial interface IWorkspaceListUsagesResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets a list of usage metrics for a workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a list of usage metrics for a workspace.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric[] Value { get; set; }

    }
    /// The list workspace usages operation response.
    internal partial interface IWorkspaceListUsagesResultInternal

    {
        /// <summary>Gets or sets a list of usage metrics for a workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IUsageMetric[] Value { get; set; }

    }
}