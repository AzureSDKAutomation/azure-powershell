namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>Properties related to Digital Twins Endpoint</summary>
    public partial class DigitalTwinsEndpointResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AuthenticationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? _authenticationType;

        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get => this._authenticationType; set => this._authenticationType = value; }

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private global::System.DateTime? _createdTime;

        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedTime { get => this._createdTime; }

        /// <summary>Backing field for <see cref="DeadLetterSecret" /> property.</summary>
        private string _deadLetterSecret;

        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string DeadLetterSecret { get => this._deadLetterSecret; set => this._deadLetterSecret = value; }

        /// <summary>Backing field for <see cref="DeadLetterUri" /> property.</summary>
        private string _deadLetterUri;

        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string DeadLetterUri { get => this._deadLetterUri; set => this._deadLetterUri = value; }

        /// <summary>Backing field for <see cref="EndpointType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType _endpointType;

        /// <summary>The type of Digital Twins endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get => this._endpointType; set => this._endpointType = value; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal.CreatedTime { get => this._createdTime; set { {_createdTime = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsEndpointResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? _provisioningState;

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DigitalTwinsEndpointResourceProperties" /> instance.</summary>
        public DigitalTwinsEndpointResourceProperties()
        {

        }
    }
    /// Properties related to Digital Twins Endpoint
    public partial interface IDigitalTwinsEndpointResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the authentication type being used for connecting to the endpoint.",
        SerializedName = @"authenticationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time when the Endpoint was added to DigitalTwinsInstance.",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get;  }
        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dead letter storage secret for key-based authentication. Will be obfuscated during read.",
        SerializedName = @"deadLetterSecret",
        PossibleTypes = new [] { typeof(string) })]
        string DeadLetterSecret { get; set; }
        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dead letter storage URL for identity-based authentication.",
        SerializedName = @"deadLetterUri",
        PossibleTypes = new [] { typeof(string) })]
        string DeadLetterUri { get; set; }
        /// <summary>The type of Digital Twins endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of Digital Twins endpoint",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get;  }

    }
    /// Properties related to Digital Twins Endpoint
    internal partial interface IDigitalTwinsEndpointResourcePropertiesInternal

    {
        /// <summary>Specifies the authentication type being used for connecting to the endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>Time when the Endpoint was added to DigitalTwinsInstance.</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>
        /// Dead letter storage secret for key-based authentication. Will be obfuscated during read.
        /// </summary>
        string DeadLetterSecret { get; set; }
        /// <summary>Dead letter storage URL for identity-based authentication.</summary>
        string DeadLetterUri { get; set; }
        /// <summary>The type of Digital Twins endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointType EndpointType { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState? ProvisioningState { get; set; }

    }
}