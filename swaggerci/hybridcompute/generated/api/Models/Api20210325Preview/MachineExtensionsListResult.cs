namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the Machine Extensions List Result.</summary>
    public partial class MachineExtensionsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtensionsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtension[] _value;

        /// <summary>The list of extensions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtension[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MachineExtensionsListResult" /> instance.</summary>
        public MachineExtensionsListResult()
        {

        }
    }
    /// Describes the Machine Extensions List Result.
    public partial interface IMachineExtensionsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of extensions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of extensions",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtension) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtension[] Value { get; set; }

    }
    /// Describes the Machine Extensions List Result.
    internal partial interface IMachineExtensionsListResultInternal

    {
        /// <summary>
        /// The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>The list of extensions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineExtension[] Value { get; set; }

    }
}