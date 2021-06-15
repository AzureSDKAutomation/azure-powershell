namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>List of scaling plan definitions.</summary>
    public partial class ScalingPlanList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlanList,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlanListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlanListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlan[] _value;

        /// <summary>List of scaling plan definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlan[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ScalingPlanList" /> instance.</summary>
        public ScalingPlanList()
        {

        }
    }
    /// List of scaling plan definitions.
    public partial interface IScalingPlanList :
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
        /// <summary>List of scaling plan definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of scaling plan definitions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlan[] Value { get; set; }

    }
    /// List of scaling plan definitions.
    internal partial interface IScalingPlanListInternal

    {
        /// <summary>Link to the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>List of scaling plan definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.IScalingPlan[] Value { get; set; }

    }
}