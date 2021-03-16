namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Represents a scaling plan definition.</summary>
    public partial class ScalingPlan :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlan,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySet"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySet __resourceModelWithAllowedPropertySet = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ResourceModelWithAllowedPropertySet();

        /// <summary>Description of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>
        /// The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the
        /// normal etag convention. Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section
        /// 14.27) header fields.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Etag; }

        /// <summary>Exclusion tag for scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ExclusionTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).ExclusionTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).ExclusionTag = value ?? null; }

        /// <summary>User friendly name of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).FriendlyName = value ?? null; }

        /// <summary>List of ScalingHostPoolReference definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingHostPoolReference[] HostPoolReference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).HostPoolReference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).HostPoolReference = value ?? null /* arrayOf */; }

        /// <summary>HostPool type for desktop.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType? HostPoolType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).HostPoolType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).HostPoolType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType)""); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Id; }

        /// <summary>Identity for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IIdentity Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Identity = value ?? null /* model class */; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityPrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityTenantId; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ResourceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ResourceIdentityType)""); }

        /// <summary>
        /// Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are
        /// a kind of Microsoft.Web/sites type. If supported, the resource provider must validate and persist this value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Kind = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Location = value ?? null; }

        /// <summary>
        /// The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another
        /// Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template
        /// since it is managed by another resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string ManagedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).ManagedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).ManagedBy = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Etag = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Id = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).IdentityTenantId = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Type = value; }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanInternal.ObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).ObjectId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ScalingPlanProperties()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Name; }

        /// <summary>ObjectId of scaling plan. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string ObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).ObjectId; }

        /// <summary>Plan for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IPlan Plan { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Plan; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Plan = value ?? null /* model class */; }

        /// <summary>A user defined name of the 3rd Party Artifact that is being procured.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string PlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanName = value ?? null; }

        /// <summary>
        /// The 3rd Party artifact that is being procured. E.g. NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string PlanProduct { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanProduct; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanProduct = value ?? null; }

        /// <summary>
        /// A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string PlanPromotionCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanPromotionCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanPromotionCode = value ?? null; }

        /// <summary>The publisher of the 3rd Party Artifact that is being bought. E.g. NewRelic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string PlanPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanPublisher = value ?? null; }

        /// <summary>The version of the desired product/artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string PlanVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).PlanVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanProperties _property;

        /// <summary>Detailed properties for scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.ScalingPlanProperties()); set => this._property = value; }

        /// <summary>The ring number of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public int? Ring { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Ring; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Ring = value ?? default(int); }

        /// <summary>List of ScalingSchedule definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingSchedule[] Schedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Schedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).Schedule = value ?? null /* arrayOf */; }

        /// <summary>The resource model definition representing SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.ISku Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Sku = value ?? null /* model class */; }

        /// <summary>
        /// If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the
        /// resource this may be omitted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public int? SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuCapacity = value ?? default(int); }

        /// <summary>
        /// If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuFamily; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuFamily = value ?? null; }

        /// <summary>The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuName = value ?? null; }

        /// <summary>
        /// The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string SkuSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuSize = value ?? null; }

        /// <summary>
        /// This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required
        /// on a PUT.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier? SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).SkuTier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SkuTier)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Tag = value ?? null /* model class */; }

        /// <summary>Timezone of the scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inlined)]
        public string TimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanPropertiesInternal)Property).TimeZone = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal)__resourceModelWithAllowedPropertySet).Type; }

        /// <summary>Creates an new <see cref="ScalingPlan" /> instance.</summary>
        public ScalingPlan()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceModelWithAllowedPropertySet), __resourceModelWithAllowedPropertySet);
            await eventListener.AssertObjectIsValid(nameof(__resourceModelWithAllowedPropertySet), __resourceModelWithAllowedPropertySet);
        }
    }
    /// Represents a scaling plan definition.
    public partial interface IScalingPlan :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySet
    {
        /// <summary>Description of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of scaling plan.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Exclusion tag for scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Exclusion tag for scaling plan.",
        SerializedName = @"exclusionTag",
        PossibleTypes = new [] { typeof(string) })]
        string ExclusionTag { get; set; }
        /// <summary>User friendly name of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User friendly name of scaling plan.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>List of ScalingHostPoolReference definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of ScalingHostPoolReference definitions.",
        SerializedName = @"hostPoolReferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingHostPoolReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingHostPoolReference[] HostPoolReference { get; set; }
        /// <summary>HostPool type for desktop.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HostPool type for desktop.",
        SerializedName = @"hostPoolType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType? HostPoolType { get; set; }
        /// <summary>ObjectId of scaling plan. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ObjectId of scaling plan. (internal use)",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get;  }
        /// <summary>The ring number of scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ring number of scaling plan.",
        SerializedName = @"ring",
        PossibleTypes = new [] { typeof(int) })]
        int? Ring { get; set; }
        /// <summary>List of ScalingSchedule definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of ScalingSchedule definitions.",
        SerializedName = @"schedules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingSchedule) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingSchedule[] Schedule { get; set; }
        /// <summary>Timezone of the scaling plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timezone of the scaling plan.",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }

    }
    /// Represents a scaling plan definition.
    internal partial interface IScalingPlanInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api10.IResourceModelWithAllowedPropertySetInternal
    {
        /// <summary>Description of scaling plan.</summary>
        string Description { get; set; }
        /// <summary>Exclusion tag for scaling plan.</summary>
        string ExclusionTag { get; set; }
        /// <summary>User friendly name of scaling plan.</summary>
        string FriendlyName { get; set; }
        /// <summary>List of ScalingHostPoolReference definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingHostPoolReference[] HostPoolReference { get; set; }
        /// <summary>HostPool type for desktop.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.HostPoolType? HostPoolType { get; set; }
        /// <summary>ObjectId of scaling plan. (internal use)</summary>
        string ObjectId { get; set; }
        /// <summary>Detailed properties for scaling plan.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingPlanProperties Property { get; set; }
        /// <summary>The ring number of scaling plan.</summary>
        int? Ring { get; set; }
        /// <summary>List of ScalingSchedule definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210201Preview.IScalingSchedule[] Schedule { get; set; }
        /// <summary>Timezone of the scaling plan.</summary>
        string TimeZone { get; set; }

    }
}