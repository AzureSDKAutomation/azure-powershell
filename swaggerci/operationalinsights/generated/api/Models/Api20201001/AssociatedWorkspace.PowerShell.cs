namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.PowerShell;

    /// <summary>The list of Log Analytics workspaces associated with the cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(AssociatedWorkspaceTypeConverter))]
    public partial class AssociatedWorkspace
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AssociatedWorkspace(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceName = (string) content.GetValueForProperty("WorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).ResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).AssociateDate = (string) content.GetValueForProperty("AssociateDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).AssociateDate, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AssociatedWorkspace(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceId = (string) content.GetValueForProperty("WorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceName = (string) content.GetValueForProperty("WorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).WorkspaceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).ResourceId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).AssociateDate = (string) content.GetValueForProperty("AssociateDate",((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal)this).AssociateDate, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AssociatedWorkspace(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.AssociatedWorkspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AssociatedWorkspace(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AssociatedWorkspace" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The list of Log Analytics workspaces associated with the cluster.
    [System.ComponentModel.TypeConverter(typeof(AssociatedWorkspaceTypeConverter))]
    public partial interface IAssociatedWorkspace

    {

    }
}