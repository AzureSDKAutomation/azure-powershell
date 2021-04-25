namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>A management group that is connected to a workspace</summary>
    public partial class ManagementGroup :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroup,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupInternal
    {

        /// <summary>The datetime that the management group was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public global::System.DateTime? Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Created = value ?? default(global::System.DateTime); }

        /// <summary>The last datetime that the management group received data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public global::System.DateTime? DataReceived { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).DataReceived; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).DataReceived = value ?? default(global::System.DateTime); }

        /// <summary>The unique ID of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Id = value ?? null; }

        /// <summary>Gets or sets a value indicating whether the management group is a gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public bool? IsGateway { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).IsGateway; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).IsGateway = value ?? default(bool); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties()); set { {_property = value;} } }

        /// <summary>The name of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties _property;

        /// <summary>The properties of the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.ManagementGroupProperties()); set => this._property = value; }

        /// <summary>The number of servers connected to the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public int? ServerCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).ServerCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).ServerCount = value ?? default(int); }

        /// <summary>The SKU of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Sku = value ?? null; }

        /// <summary>The version of System Center that is managing the management group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="ManagementGroup" /> instance.</summary>
        public ManagementGroup()
        {

        }
    }
    /// A management group that is connected to a workspace
    public partial interface IManagementGroup :
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
    /// A management group that is connected to a workspace
    internal partial interface IManagementGroupInternal

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
        /// <summary>The properties of the management group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IManagementGroupProperties Property { get; set; }
        /// <summary>The number of servers connected to the management group.</summary>
        int? ServerCount { get; set; }
        /// <summary>The SKU of System Center that is managing the management group.</summary>
        string Sku { get; set; }
        /// <summary>The version of System Center that is managing the management group.</summary>
        string Version { get; set; }

    }
}