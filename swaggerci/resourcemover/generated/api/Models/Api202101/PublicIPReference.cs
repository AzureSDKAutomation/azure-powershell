namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Extensions;

    /// <summary>Defines reference to a public IP.</summary>
    public partial class PublicIPReference :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IPublicIPReference,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IPublicIPReferenceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReference"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReference __azureResourceReference = new Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.AzureResourceReference();

        /// <summary>Gets the ARM resource ID of the tracked resource being referenced.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Inherited)]
        public string SourceArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReferenceInternal)__azureResourceReference).SourceArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReferenceInternal)__azureResourceReference).SourceArmResourceId = value ; }

        /// <summary>Creates an new <see cref="PublicIPReference" /> instance.</summary>
        public PublicIPReference()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureResourceReference), __azureResourceReference);
            await eventListener.AssertObjectIsValid(nameof(__azureResourceReference), __azureResourceReference);
        }
    }
    /// Defines reference to a public IP.
    public partial interface IPublicIPReference :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReference
    {

    }
    /// Defines reference to a public IP.
    internal partial interface IPublicIPReferenceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IAzureResourceReferenceInternal
    {

    }
}