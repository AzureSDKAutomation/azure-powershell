namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Tenant configuration.</summary>
    public partial class Configuration :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.Resource();

        /// <summary>
        /// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration
        /// will be prohibited.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inlined)]
        public bool? EnforcePrivateMarkdownStorage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationPropertiesInternal)Property).EnforcePrivateMarkdownStorage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationPropertiesInternal)Property).EnforcePrivateMarkdownStorage = value ?? default(bool); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.ConfigurationProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationProperties _property;

        /// <summary>Tenant configuration properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.ConfigurationProperties()); set => this._property = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Configuration" /> instance.</summary>
        public Configuration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Tenant configuration.
    public partial interface IConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResource
    {
        /// <summary>
        /// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration
        /// will be prohibited.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration will be prohibited.",
        SerializedName = @"enforcePrivateMarkdownStorage",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnforcePrivateMarkdownStorage { get; set; }

    }
    /// Tenant configuration.
    internal partial interface IConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20.IResourceInternal
    {
        /// <summary>
        /// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration
        /// will be prohibited.
        /// </summary>
        bool? EnforcePrivateMarkdownStorage { get; set; }
        /// <summary>Tenant configuration properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationProperties Property { get; set; }

    }
}