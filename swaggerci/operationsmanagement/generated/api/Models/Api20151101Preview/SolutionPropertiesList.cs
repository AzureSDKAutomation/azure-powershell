namespace Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.Extensions;

    /// <summary>the list of solution response</summary>
    public partial class SolutionPropertiesList :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolutionPropertiesList,
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolutionPropertiesListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolution[] _value;

        /// <summary>List of solution properties within the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Operations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Operations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolution[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SolutionPropertiesList" /> instance.</summary>
        public SolutionPropertiesList()
        {

        }
    }
    /// the list of solution response
    public partial interface ISolutionPropertiesList :
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.IJsonSerializable
    {
        /// <summary>List of solution properties within the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Operations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of solution properties within the subscription.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolution) })]
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolution[] Value { get; set; }

    }
    /// the list of solution response
    internal partial interface ISolutionPropertiesListInternal

    {
        /// <summary>List of solution properties within the subscription.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Operations.Models.Api20151101Preview.ISolution[] Value { get; set; }

    }
}