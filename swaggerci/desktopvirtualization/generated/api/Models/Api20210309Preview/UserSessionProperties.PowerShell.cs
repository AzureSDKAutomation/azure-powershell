namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell;

    /// <summary>Schema for UserSession properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(UserSessionPropertiesTypeConverter))]
    public partial class UserSessionProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.UserSessionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserSessionProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.UserSessionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UserSessionProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserSessionProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.UserSessionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserSessionProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).UserPrincipalName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ApplicationType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationType?) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ApplicationType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).SessionState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionState?) content.GetValueForProperty("SessionState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).SessionState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ActiveDirectoryUserName = (string) content.GetValueForProperty("ActiveDirectoryUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ActiveDirectoryUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).CreateTime = (global::System.DateTime?) content.GetValueForProperty("CreateTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).CreateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.UserSessionProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UserSessionProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).UserPrincipalName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ApplicationType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationType?) content.GetValueForProperty("ApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ApplicationType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ApplicationType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).SessionState = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionState?) content.GetValueForProperty("SessionState",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).SessionState, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ActiveDirectoryUserName = (string) content.GetValueForProperty("ActiveDirectoryUserName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).ActiveDirectoryUserName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).CreateTime = (global::System.DateTime?) content.GetValueForProperty("CreateTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210309Preview.IUserSessionPropertiesInternal)this).CreateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }
    }
    /// Schema for UserSession properties.
    [System.ComponentModel.TypeConverter(typeof(UserSessionPropertiesTypeConverter))]
    public partial interface IUserSessionProperties

    {

    }
}