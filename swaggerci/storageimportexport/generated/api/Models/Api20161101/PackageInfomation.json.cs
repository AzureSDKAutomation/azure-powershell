namespace Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Extensions;

    /// <summary>
    /// Contains information about the package being shipped by the customer to the Microsoft data center.
    /// </summary>
    public partial class PackageInfomation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Models.Api20161101.IPackageInfomation FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json ? new PackageInfomation(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject into a new instance of <see cref="PackageInfomation" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PackageInfomation(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_carrierName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("carrierName"), out var __jsonCarrierName) ? (string)__jsonCarrierName : (string)CarrierName;}
            {_trackingNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("trackingNumber"), out var __jsonTrackingNumber) ? (string)__jsonTrackingNumber : (string)TrackingNumber;}
            {_driveCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNumber>("driveCount"), out var __jsonDriveCount) ? (int)__jsonDriveCount : DriveCount;}
            {_shipDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString>("shipDate"), out var __jsonShipDate) ? (string)__jsonShipDate : (string)ShipDate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PackageInfomation" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PackageInfomation" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._carrierName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._carrierName.ToString()) : null, "carrierName" ,container.Add );
            AddIf( null != (((object)this._trackingNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._trackingNumber.ToString()) : null, "trackingNumber" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNumber(this._driveCount), "driveCount" ,container.Add );
            AddIf( null != (((object)this._shipDate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageImportExport.Runtime.Json.JsonString(this._shipDate.ToString()) : null, "shipDate" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}