namespace Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.Extensions;

    /// <summary>the list of ManagementConfiguration response</summary>
    public partial class ManagementConfigurationPropertiesList :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfigurationPropertiesList,
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfigurationPropertiesListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfiguration[] _value;

        /// <summary>List of Management Configuration properties within the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Operations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Operations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfiguration[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ManagementConfigurationPropertiesList" /> instance.</summary>
        public ManagementConfigurationPropertiesList()
        {

        }
    }
    /// the list of ManagementConfiguration response
    public partial interface IManagementConfigurationPropertiesList :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.IJsonSerializable
    {
        /// <summary>List of Management Configuration properties within the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Management Configuration properties within the subscription.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfiguration[] Value { get; set; }

    }
    /// the list of ManagementConfiguration response
    internal partial interface IManagementConfigurationPropertiesListInternal

    {
        /// <summary>List of Management Configuration properties within the subscription.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.IManagementConfiguration[] Value { get; set; }

    }
}