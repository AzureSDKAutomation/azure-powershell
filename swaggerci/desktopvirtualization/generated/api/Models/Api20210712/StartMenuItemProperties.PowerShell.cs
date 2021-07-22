namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell;

    /// <summary>Schema for StartMenuItem properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(StartMenuItemPropertiesTypeConverter))]
    public partial class StartMenuItemProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.StartMenuItemProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StartMenuItemProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.StartMenuItemProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StartMenuItemProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StartMenuItemProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.StartMenuItemProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StartMenuItemProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).AppAlias = (string) content.GetValueForProperty("AppAlias",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).AppAlias, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).FilePath = (string) content.GetValueForProperty("FilePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).FilePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).CommandLineArgument = (string) content.GetValueForProperty("CommandLineArgument",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).CommandLineArgument, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconPath = (string) content.GetValueForProperty("IconPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconIndex = (int?) content.GetValueForProperty("IconIndex",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconIndex, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.StartMenuItemProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StartMenuItemProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).AppAlias = (string) content.GetValueForProperty("AppAlias",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).AppAlias, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).FilePath = (string) content.GetValueForProperty("FilePath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).FilePath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).CommandLineArgument = (string) content.GetValueForProperty("CommandLineArgument",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).CommandLineArgument, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconPath = (string) content.GetValueForProperty("IconPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconIndex = (int?) content.GetValueForProperty("IconIndex",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.IStartMenuItemPropertiesInternal)this).IconIndex, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Schema for StartMenuItem properties.
    [System.ComponentModel.TypeConverter(typeof(StartMenuItemPropertiesTypeConverter))]
    public partial interface IStartMenuItemProperties

    {

    }
}