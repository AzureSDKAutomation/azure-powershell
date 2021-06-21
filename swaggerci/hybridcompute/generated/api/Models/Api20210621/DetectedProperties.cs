namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Detected properties from the machine.</summary>
    public partial class DetectedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IDetectedProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IDetectedPropertiesInternal
    {

        /// <summary>Creates an new <see cref="DetectedProperties" /> instance.</summary>
        public DetectedProperties()
        {

        }
    }
    /// Detected properties from the machine.
    public partial interface IDetectedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IAssociativeArray<string>
    {

    }
    /// Detected properties from the machine.
    internal partial interface IDetectedPropertiesInternal

    {

    }
}