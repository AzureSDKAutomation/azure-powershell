namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Management group properties.</summary>
    public partial class ManagementGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private global::System.DateTime? _created;

        /// <summary>The datetime that the management group was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DataReceived" /> property.</summary>
        private global::System.DateTime? _dataReceived;

        /// <summary>The last datetime that the management group received data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? DataReceived { get => this._dataReceived; set => this._dataReceived = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The unique ID of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IsGateway" /> property.</summary>
        private bool? _isGateway;

        /// <summary>Gets or sets a value indicating whether the management group is a gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? IsGateway { get => this._isGateway; set => this._isGateway = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ServerCount" /> property.</summary>
        private int? _serverCount;

        /// <summary>The number of servers connected to the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public int? ServerCount { get => this._serverCount; set => this._serverCount = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The SKU of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ManagementGroupProperties" /> instance.</summary>
        public ManagementGroupProperties()
        {

        }
    }
    /// Management group properties.
    public partial interface IManagementGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The datetime that the management group was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The datetime that the management group was created.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Created { get; set; }
        /// <summary>The last datetime that the management group received data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last datetime that the management group received data.",
        SerializedName = @"dataReceived",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DataReceived { get; set; }
        /// <summary>The unique ID of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique ID of the management group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Gets or sets a value indicating whether the management group is a gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a value indicating whether the management group is a gateway.",
        SerializedName = @"isGateway",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsGateway { get; set; }
        /// <summary>The name of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the management group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The number of servers connected to the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of servers connected to the management group.",
        SerializedName = @"serverCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ServerCount { get; set; }
        /// <summary>The SKU of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU of System Center that is managing the management group.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }
        /// <summary>The version of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of System Center that is managing the management group.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Management group properties.
    internal partial interface IManagementGroupPropertiesInternal

    {
        /// <summary>The datetime that the management group was created.</summary>
        global::System.DateTime? Created { get; set; }
        /// <summary>The last datetime that the management group received data.</summary>
        global::System.DateTime? DataReceived { get; set; }
        /// <summary>The unique ID of the management group.</summary>
        string Id { get; set; }
        /// <summary>Gets or sets a value indicating whether the management group is a gateway.</summary>
        bool? IsGateway { get; set; }
        /// <summary>The name of the management group.</summary>
        string Name { get; set; }
        /// <summary>The number of servers connected to the management group.</summary>
        int? ServerCount { get; set; }
        /// <summary>The SKU of System Center that is managing the management group.</summary>
        string Sku { get; set; }
        /// <summary>The version of System Center that is managing the management group.</summary>
        string Version { get; set; }

    }
}