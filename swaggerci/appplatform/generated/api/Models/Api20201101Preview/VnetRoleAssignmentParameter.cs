namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Vnet Role Assignment parameters payload</summary>
    public partial class VnetRoleAssignmentParameter :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IVnetRoleAssignmentParameter,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20201101Preview.IVnetRoleAssignmentParameterInternal
    {

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The resource Id of the Vnet to be checked</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Creates an new <see cref="VnetRoleAssignmentParameter" /> instance.</summary>
        public VnetRoleAssignmentParameter()
        {

        }
    }
    /// Vnet Role Assignment parameters payload
    public partial interface IVnetRoleAssignmentParameter :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The resource Id of the Vnet to be checked</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource Id of the Vnet to be checked",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }

    }
    /// Vnet Role Assignment parameters payload
    internal partial interface IVnetRoleAssignmentParameterInternal

    {
        /// <summary>The resource Id of the Vnet to be checked</summary>
        string Scope { get; set; }

    }
}