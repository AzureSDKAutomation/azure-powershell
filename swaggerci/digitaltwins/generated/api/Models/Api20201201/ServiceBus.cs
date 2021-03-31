namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>Properties related to ServiceBus.</summary>
    public partial class ServiceBus :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IServiceBus,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IServiceBusInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties __digitalTwinsEndpointResourceProperties = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsEndpointResourceProperties();

        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).AuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).AuthenticationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType)""); }

        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).CreatedTime; }

        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string DeadLetterSecret { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).DeadLetterSecret; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).DeadLetterSecret = value ?? null; }

        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string DeadLetterUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).DeadLetterUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).DeadLetterUri = value ?? null; }

        /// <summary>The type of Digital Twins endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).EndpointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).EndpointType = value ; }

        /// <summary>Backing field for <see cref="EndpointUri" /> property.</summary>
        private string _endpointUri;

        /// <summary>
        /// The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol sb://
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string EndpointUri { get => this._endpointUri; set => this._endpointUri = value; }

        /// <summary>Backing field for <see cref="EntityPath" /> property.</summary>
        private string _entityPath;

        /// <summary>The ServiceBus Topic name for identity-based authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string EntityPath { get => this._entityPath; set => this._entityPath = value; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal.CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).CreatedTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).ProvisioningState = value; }

        /// <summary>Backing field for <see cref="PrimaryConnectionString" /> property.</summary>
        private string _primaryConnectionString;

        /// <summary>
        /// PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string PrimaryConnectionString { get => this._primaryConnectionString; set => this._primaryConnectionString = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal)__digitalTwinsEndpointResourceProperties).ProvisioningState; }

        /// <summary>Backing field for <see cref="SecondaryConnectionString" /> property.</summary>
        private string _secondaryConnectionString;

        /// <summary>
        /// SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string SecondaryConnectionString { get => this._secondaryConnectionString; set => this._secondaryConnectionString = value; }

        /// <summary>Creates an new <see cref="ServiceBus" /> instance.</summary>
        public ServiceBus()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__digitalTwinsEndpointResourceProperties), __digitalTwinsEndpointResourceProperties);
            await eventListener.AssertObjectIsValid(nameof(__digitalTwinsEndpointResourceProperties), __digitalTwinsEndpointResourceProperties);
        }
    }
    /// Properties related to ServiceBus.
    public partial interface IServiceBus :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties
    {
        /// <summary>
        /// The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol sb://
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol sb://",
        SerializedName = @"endpointUri",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointUri { get; set; }
        /// <summary>The ServiceBus Topic name for identity-based authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ServiceBus Topic name for identity-based authentication",
        SerializedName = @"entityPath",
        PossibleTypes = new [] { typeof(string) })]
        string EntityPath { get; set; }
        /// <summary>
        /// PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.",
        SerializedName = @"primaryConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryConnectionString { get; set; }
        /// <summary>
        /// SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.",
        SerializedName = @"secondaryConnectionString",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryConnectionString { get; set; }

    }
    /// Properties related to ServiceBus.
    internal partial interface IServiceBusInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal
    {
        /// <summary>
        /// The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol sb://
        /// </summary>
        string EndpointUri { get; set; }
        /// <summary>The ServiceBus Topic name for identity-based authentication</summary>
        string EntityPath { get; set; }
        /// <summary>
        /// PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        string PrimaryConnectionString { get; set; }
        /// <summary>
        /// SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read.
        /// </summary>
        string SecondaryConnectionString { get; set; }

    }
}