namespace Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.Extensions;

    /// <summary>Tenant configuration properties.</summary>
    public partial class ConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Api20200901Preview.IConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="EnforcePrivateMarkdownStorage" /> property.</summary>
        private bool? _enforcePrivateMarkdownStorage;

        /// <summary>
        /// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration
        /// will be prohibited.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Portal.Origin(Microsoft.Azure.PowerShell.Cmdlets.Portal.PropertyOrigin.Owned)]
        public bool? EnforcePrivateMarkdownStorage { get => this._enforcePrivateMarkdownStorage; set => this._enforcePrivateMarkdownStorage = value; }

        /// <summary>Creates an new <see cref="ConfigurationProperties" /> instance.</summary>
        public ConfigurationProperties()
        {

        }
    }
    /// Tenant configuration properties.
    public partial interface IConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.IJsonSerializable
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
    /// Tenant configuration properties.
    internal partial interface IConfigurationPropertiesInternal

    {
        /// <summary>
        /// When flag is set to true Markdown tile will require external storage configuration (URI). The inline content configuration
        /// will be prohibited.
        /// </summary>
        bool? EnforcePrivateMarkdownStorage { get; set; }

    }
}