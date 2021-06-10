namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>The List hybrid machine operation response.</summary>
    public partial class MachineListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachineListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of hybrid machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachine[] _value;

        /// <summary>The list of hybrid machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachine[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MachineListResult" /> instance.</summary>
        public MachineListResult()
        {

        }
    }
    /// The List hybrid machine operation response.
    public partial interface IMachineListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of hybrid machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of hybrid machines.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of hybrid machines.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of hybrid machines.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachine) })]
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachine[] Value { get; set; }

    }
    /// The List hybrid machine operation response.
    internal partial interface IMachineListResultInternal

    {
        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of hybrid machines.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>The list of hybrid machines.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IMachine[] Value { get; set; }

    }
}