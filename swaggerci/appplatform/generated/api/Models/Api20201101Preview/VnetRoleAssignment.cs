namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Check Vnet role assignment response payload</summary>
    public partial class VnetRoleAssignment :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IVnetRoleAssignment,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IVnetRoleAssignmentInternal
    {

        /// <summary>Backing field for <see cref="HasPermission" /> property.</summary>
        private bool? _hasPermission;

        /// <summary>Indicates whether the owner role is assigned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? HasPermission { get => this._hasPermission; set => this._hasPermission = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>Reason why the assignment is not found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="VnetRoleAssignment" /> instance.</summary>
        public VnetRoleAssignment()
        {

        }
    }
    /// Check Vnet role assignment response payload
    public partial interface IVnetRoleAssignment :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether the owner role is assigned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the owner role is assigned",
        SerializedName = @"hasPermission",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasPermission { get; set; }
        /// <summary>Reason why the assignment is not found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reason why the assignment is not found",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get; set; }

    }
    /// Check Vnet role assignment response payload
    internal partial interface IVnetRoleAssignmentInternal

    {
        /// <summary>Indicates whether the owner role is assigned</summary>
        bool? HasPermission { get; set; }
        /// <summary>Reason why the assignment is not found</summary>
        string Reason { get; set; }

    }
}