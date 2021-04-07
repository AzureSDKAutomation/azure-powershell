namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell;

    /// <summary>An identity that can be associated with a resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceIdentityTypeConverter))]
    public partial class ResourceIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).UserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).TenantId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.IdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).UserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityUserAssignedIdentities) content.GetValueForProperty("UserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).UserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.ResourceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IResourceIdentityInternal)this).TenantId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An identity that can be associated with a resource.
    [System.ComponentModel.TypeConverter(typeof(ResourceIdentityTypeConverter))]
    public partial interface IResourceIdentity

    {

    }
}