namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    public partial class ResourceSkuCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuCapabilities,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuCapabilitiesInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets an invariant to describe the feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>Gets an invariant if the feature is measured by quantity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceSkuCapabilities" /> instance.</summary>
        public ResourceSkuCapabilities()
        {

        }
    }
    public partial interface IResourceSkuCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Gets an invariant to describe the feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets an invariant to describe the feature.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Gets an invariant if the feature is measured by quantity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets an invariant if the feature is measured by quantity.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    internal partial interface IResourceSkuCapabilitiesInternal

    {
        /// <summary>Gets an invariant to describe the feature.</summary>
        string Name { get; set; }
        /// <summary>Gets an invariant if the feature is measured by quantity.</summary>
        string Value { get; set; }

    }
}