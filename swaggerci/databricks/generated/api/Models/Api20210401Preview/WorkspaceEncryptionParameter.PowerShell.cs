namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.PowerShell;

    /// <summary>The object that contains details of encryption used on the workspace.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspaceEncryptionParameterTypeConverter))]
    public partial class WorkspaceEncryptionParameter
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkspaceEncryptionParameter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkspaceEncryptionParameter(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkspaceEncryptionParameter" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkspaceEncryptionParameter(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryption) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Value, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeySource = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource?) content.GetValueForProperty("ValueKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeySource, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyName = (string) content.GetValueForProperty("ValueKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVersion = (string) content.GetValueForProperty("ValueKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVaultUri = (string) content.GetValueForProperty("ValueKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVaultUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkspaceEncryptionParameter(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryption) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Value, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.EncryptionTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType?) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeySource = (Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource?) content.GetValueForProperty("ValueKeySource",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeySource, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyName = (string) content.GetValueForProperty("ValueKeyName",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVersion = (string) content.GetValueForProperty("ValueKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVaultUri = (string) content.GetValueForProperty("ValueKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)this).ValueKeyVaultUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// The object that contains details of encryption used on the workspace.
    [System.ComponentModel.TypeConverter(typeof(WorkspaceEncryptionParameterTypeConverter))]
    public partial interface IWorkspaceEncryptionParameter

    {

    }
}