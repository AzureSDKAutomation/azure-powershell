namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list workspace management groups operation response.</summary>
    public partial class WorkspaceListManagementGroupsResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspaceListManagementGroupsResult,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IWorkspaceListManagementGroupsResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup[] _value;

        /// <summary>Gets or sets a list of management groups attached to the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WorkspaceListManagementGroupsResult" /> instance.</summary>
        public WorkspaceListManagementGroupsResult()
        {

        }
    }
    /// The list workspace management groups operation response.
    public partial interface IWorkspaceListManagementGroupsResult :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets a list of management groups attached to the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a list of management groups attached to the workspace.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup[] Value { get; set; }

    }
    /// The list workspace management groups operation response.
    internal partial interface IWorkspaceListManagementGroupsResultInternal

    {
        /// <summary>Gets or sets a list of management groups attached to the workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup[] Value { get; set; }

    }
}