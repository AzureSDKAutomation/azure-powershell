namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Extensions;

    /// <summary>Input values.</summary>
    public partial class DeviceServiceCheckNameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceCheckNameAvailabilityParameters,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceServiceCheckNameAvailabilityParametersInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the Windows IoT Device Service to check.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// Creates an new <see cref="DeviceServiceCheckNameAvailabilityParameters" /> instance.
        /// </summary>
        public DeviceServiceCheckNameAvailabilityParameters()
        {

        }
    }
    /// Input values.
    public partial interface IDeviceServiceCheckNameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Windows IoT Device Service to check.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the Windows IoT Device Service to check.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Input values.
    internal partial interface IDeviceServiceCheckNameAvailabilityParametersInternal

    {
        /// <summary>The name of the Windows IoT Device Service to check.</summary>
        string Name { get; set; }

    }
}