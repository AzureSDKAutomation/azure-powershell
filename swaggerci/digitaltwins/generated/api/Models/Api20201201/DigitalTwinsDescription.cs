namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The description of the DigitalTwins service.</summary>
    public partial class DigitalTwinsDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResource __digitalTwinsResource = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsResource();

        /// <summary>Time when DigitalTwinsInstance was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).CreatedTime; }

        /// <summary>Api endpoint to work with DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).HostName; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Id; }

        /// <summary>The managed identity for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsIdentity Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Identity = value ?? null /* model class */; }

        /// <summary>
        /// The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-identity-principal-id
        /// header in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityPrincipalId; }

        /// <summary>
        /// The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the x-ms-client-tenant-id header
        /// in the PUT request if the resource has a systemAssigned(implicit) identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityTenantId; }

        /// <summary>
        /// The type of Managed Identity used by the DigitalTwinsInstance. Only SystemAssigned is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.DigitalTwinsIdentityType)""); }

        /// <summary>Time when DigitalTwinsInstance was updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastUpdatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).LastUpdatedTime; }

        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Location = value ; }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal.CreatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).CreatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).CreatedTime = value; }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal.HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).HostName = value; }

        /// <summary>Internal Acessors for LastUpdatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal.LastUpdatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).LastUpdatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).LastUpdatedTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsProperties Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsDescriptionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Id = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).IdentityTenantId = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Type = value; }

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Name; }

        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsProperties _property;

        /// <summary>DigitalTwins instance properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.DigitalTwinsProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsPropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess)""); }

        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Tag = value ?? null /* model class */; }

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal)__digitalTwinsResource).Type; }

        /// <summary>Creates an new <see cref="DigitalTwinsDescription" /> instance.</summary>
        public DigitalTwinsDescription()
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
            await eventListener.AssertNotNull(nameof(__digitalTwinsResource), __digitalTwinsResource);
            await eventListener.AssertObjectIsValid(nameof(__digitalTwinsResource), __digitalTwinsResource);
        }
    }
    /// The description of the DigitalTwins service.
    public partial interface IDigitalTwinsDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResource
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
    /// The description of the DigitalTwins service.
    internal partial interface IDigitalTwinsDescriptionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsResourceInternal
    {
        /// <summary>Time when DigitalTwinsInstance was created.</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Api endpoint to work with DigitalTwinsInstance.</summary>
        string HostName { get; set; }
        /// <summary>Time when DigitalTwinsInstance was updated.</summary>
        global::System.DateTime? LastUpdatedTime { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>DigitalTwins instance properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20201201.IDigitalTwinsProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Public network access for the DigitalTwinsInstance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }

    }
}