namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.PowerShell;

    /// <summary>Response when errors occurred</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseTypeConverter))]
    public partial class ErrorResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ErrorResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ErrorResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ErrorResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponseErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Target, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseErrorDetailsItem[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseErrorDetailsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponseErrorDetailsItemTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.AnyTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ErrorResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponseErrorTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Target, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseErrorDetailsItem[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseErrorDetailsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.ErrorResponseErrorDetailsItemTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Innererror = (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.IAny) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponseInternal)this).Innererror, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.AnyTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ErrorResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IErrorResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response when errors occurred
    [System.ComponentModel.TypeConverter(typeof(ErrorResponseTypeConverter))]
    public partial interface IErrorResponse

    {

    }
}