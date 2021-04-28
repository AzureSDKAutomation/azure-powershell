namespace Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208
{
    using Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.PowerShell;

    /// <summary>The resource management error response.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorTypeConverter))]
    public partial class Error
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Error"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Error(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Error"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Error(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Error"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Error(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Error1 = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAutoGenerated) content.GetValueForProperty("Error1",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Error1, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Target, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAdditionalInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.Error"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Error(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Error1 = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAutoGenerated) content.GetValueForProperty("Error1",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Error1, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Code, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Message, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Target, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).AdditionalInfo = (Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAdditionalInfo[]) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Error" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Models.Api20201208.IError FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Healthbot.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The resource management error response.
    [System.ComponentModel.TypeConverter(typeof(ErrorTypeConverter))]
    public partial interface IError

    {

    }
}