namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The properties of a DigitalTwinsInstance.</summary>
    public partial class DigitalTwinsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private global::System.DateTime? _createdTime;

        /// <summary>Time when DigitalTwinsInstance was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedTime { get => this._createdTime; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>Api endpoint to work with DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; }

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private global::System.DateTime? _lastUpdatedTime;

        /// <summary>Time when DigitalTwinsInstance was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdatedTime { get => this._lastUpdatedTime; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal.CreatedTime { get => this._createdTime; set { {_createdTime = value;} } }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal.HostName { get => this._hostName; set { {_hostName = value;} } }

        /// <summary>Internal Acessors for LastUpdatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal.LastUpdatedTime { get => this._lastUpdatedTime; set { {_lastUpdatedTime = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] _privateEndpointConnection;

        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] PrivateEndpointConnection { get => this._privateEndpointConnection; set => this._privateEndpointConnection = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? _publicNetworkAccess;

        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Creates an new <see cref="DigitalTwinsProperties" /> instance.</summary>
        public DigitalTwinsProperties()
        {

        }
    }
    /// The properties of a DigitalTwinsInstance.
    public partial interface IDigitalTwinsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>Time when DigitalTwinsInstance was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time when DigitalTwinsInstance was created.",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get;  }
        /// <summary>Api endpoint to work with DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Api endpoint to work with DigitalTwinsInstance.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>Time when DigitalTwinsInstance was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time when DigitalTwinsInstance was updated.",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdatedTime { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public network access for the DigitalTwinsInstance.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
    /// The properties of a DigitalTwinsInstance.
    internal partial interface IDigitalTwinsPropertiesInternal

    {
        /// <summary>Time when DigitalTwinsInstance was created.</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Api endpoint to work with DigitalTwinsInstance.</summary>
        string HostName { get; set; }
        /// <summary>Time when DigitalTwinsInstance was updated.</summary>
        global::System.DateTime? LastUpdatedTime { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
}