namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list of Log Analytics workspaces associated with the cluster.</summary>
    public partial class AssociatedWorkspace
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject into a new instance of <see cref="AssociatedWorkspace" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AssociatedWorkspace(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_workspaceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("workspaceId"), out var __jsonWorkspaceId) ? (string)__jsonWorkspaceId : (string)WorkspaceId;}
            {_workspaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("workspaceName"), out var __jsonWorkspaceName) ? (string)__jsonWorkspaceName : (string)WorkspaceName;}
            {_resourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("resourceId"), out var __jsonResourceId) ? (string)__jsonResourceId : (string)ResourceId;}
            {_associateDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString>("associateDate"), out var __jsonAssociateDate) ? (string)__jsonAssociateDate : (string)AssociateDate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace FromJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject json ? new AssociatedWorkspace(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AssociatedWorkspace" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AssociatedWorkspace" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._workspaceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._workspaceId.ToString()) : null, "workspaceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._workspaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._workspaceName.ToString()) : null, "workspaceName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._resourceId.ToString()) : null, "resourceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._associateDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Json.JsonString(this._associateDate.ToString()) : null, "associateDate" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}