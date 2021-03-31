namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.PowerShell;

    /// <summary>
    /// Contains information about the delivery package being shipped by the customer to the Microsoft data center.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(DeliveryPackageInformationTypeConverter))]
    public partial class DeliveryPackageInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeliveryPackageInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).CarrierName = (string) content.GetValueForProperty("CarrierName",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).CarrierName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).TrackingNumber = (string) content.GetValueForProperty("TrackingNumber",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).TrackingNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).DriveCount = (long?) content.GetValueForProperty("DriveCount",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).DriveCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).ShipDate = (string) content.GetValueForProperty("ShipDate",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).ShipDate, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeliveryPackageInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).CarrierName = (string) content.GetValueForProperty("CarrierName",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).CarrierName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).TrackingNumber = (string) content.GetValueForProperty("TrackingNumber",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).TrackingNumber, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).DriveCount = (long?) content.GetValueForProperty("DriveCount",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).DriveCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).ShipDate = (string) content.GetValueForProperty("ShipDate",((Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformationInternal)this).ShipDate, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeliveryPackageInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.DeliveryPackageInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeliveryPackageInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeliveryPackageInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IDeliveryPackageInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Contains information about the delivery package being shipped by the customer to the Microsoft data center.
    [System.ComponentModel.TypeConverter(typeof(DeliveryPackageInformationTypeConverter))]
    public partial interface IDeliveryPackageInformation

    {

    }
}