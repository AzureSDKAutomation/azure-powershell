namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Describes the Machine Extension Target Properties</summary>
    public partial class ExtensionTarget :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IExtensionTarget,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IExtensionTargetInternal
    {

        /// <summary>Creates an new <see cref="ExtensionTarget" /> instance.</summary>
        public ExtensionTarget()
        {

        }
    }
    /// Describes the Machine Extension Target Properties
    public partial interface IExtensionTarget :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210520.IExtensionTargetProperties>
    {

    }
    /// Describes the Machine Extension Target Properties
    internal partial interface IExtensionTargetInternal

    {

    }
}