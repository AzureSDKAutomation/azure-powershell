namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    public partial class ResourceModelWithAllowedPropertySetSku :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetSku,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetSkuInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISku"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISku __sku = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.Sku();

        /// <summary>
        /// If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the
        /// resource this may be omitted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public int? Capacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Capacity = value ?? default(int); }

        /// <summary>
        /// If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Family { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Family = value ?? null; }

        /// <summary>The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Name = value ; }

        /// <summary>
        /// The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Size { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Size; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Size = value ?? null; }

        /// <summary>
        /// This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required
        /// on a PUT.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier? Tier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal)__sku).Tier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier)""); }

        /// <summary>Creates an new <see cref="ResourceModelWithAllowedPropertySetSku" /> instance.</summary>
        public ResourceModelWithAllowedPropertySetSku()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__sku), __sku);
            await eventListener.AssertObjectIsValid(nameof(__sku), __sku);
        }
    }
    public partial interface IResourceModelWithAllowedPropertySetSku :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISku
    {

    }
    internal partial interface IResourceModelWithAllowedPropertySetSkuInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISkuInternal
    {

    }
}