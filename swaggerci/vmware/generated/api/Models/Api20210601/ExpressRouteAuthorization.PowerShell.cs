namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.PowerShell;

    /// <summary>ExpressRoute Circuit Authorization</summary>
    [System.ComponentModel.TypeConverter(typeof(ExpressRouteAuthorizationTypeConverter))]
    public partial class ExpressRouteAuthorization
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorization"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorization DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExpressRouteAuthorization(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorization"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorization DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExpressRouteAuthorization(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExpressRouteAuthorization(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorizationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ExpressRouteAuthorizationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ExpressRouteAuthorizationProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ExpressRouteAuthorizationId = (string) content.GetValueForProperty("ExpressRouteAuthorizationId",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ExpressRouteAuthorizationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Key = (string) content.GetValueForProperty("Key",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Key, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorization"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExpressRouteAuthorization(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.ExpressRouteAuthorizationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ExpressRouteAuthorizationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.ExpressRouteAuthorizationProvisioningState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ExpressRouteAuthorizationId = (string) content.GetValueForProperty("ExpressRouteAuthorizationId",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).ExpressRouteAuthorizationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Key = (string) content.GetValueForProperty("Key",((Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorizationInternal)this).Key, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExpressRouteAuthorization" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Models.Api20210601.IExpressRouteAuthorization FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ExpressRoute Circuit Authorization
    [System.ComponentModel.TypeConverter(typeof(ExpressRouteAuthorizationTypeConverter))]
    public partial interface IExpressRouteAuthorization

    {

    }
}