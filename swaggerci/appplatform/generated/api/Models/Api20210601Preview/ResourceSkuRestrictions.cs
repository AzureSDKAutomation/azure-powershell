namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Restrictions where the SKU cannot be used</summary>
    public partial class ResourceSkuRestrictions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictions,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionsInternal
    {

        /// <summary>Internal Acessors for RestrictionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfo Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionsInternal.RestrictionInfo { get => (this._restrictionInfo = this._restrictionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceSkuRestrictionInfo()); set { {_restrictionInfo = value;} } }

        /// <summary>Backing field for <see cref="ReasonCode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsReasonCode? _reasonCode;

        /// <summary>
        /// Gets the reason for restriction. Possible values include: 'QuotaId', 'NotAvailableForSubscription'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsReasonCode? ReasonCode { get => this._reasonCode; set => this._reasonCode = value; }

        /// <summary>Backing field for <see cref="RestrictionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfo _restrictionInfo;

        /// <summary>Gets the information about the restriction where the SKU cannot be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfo RestrictionInfo { get => (this._restrictionInfo = this._restrictionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceSkuRestrictionInfo()); set => this._restrictionInfo = value; }

        /// <summary>Gets locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] RestrictionInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Location = value ?? null /* arrayOf */; }

        /// <summary>Gets list of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string[] RestrictionInfoZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Zone = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsType? _type;

        /// <summary>Gets the type of restrictions. Possible values include: 'Location', 'Zone'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string[] _value;

        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is restricted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceSkuRestrictions" /> instance.</summary>
        public ResourceSkuRestrictions()
        {

        }
    }
    /// Restrictions where the SKU cannot be used
    public partial interface IResourceSkuRestrictions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets the reason for restriction. Possible values include: 'QuotaId', 'NotAvailableForSubscription'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the reason for restriction. Possible values include: 'QuotaId', 'NotAvailableForSubscription'",
        SerializedName = @"reasonCode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsReasonCode) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsReasonCode? ReasonCode { get; set; }
        /// <summary>Gets locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets locations where the SKU is restricted",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(string) })]
        string[] RestrictionInfoLocation { get; set; }
        /// <summary>Gets list of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets list of availability zones where the SKU is restricted.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        string[] RestrictionInfoZone { get; set; }
        /// <summary>Gets the type of restrictions. Possible values include: 'Location', 'Zone'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the type of restrictions. Possible values include: 'Location', 'Zone'",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsType? Type { get; set; }
        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is restricted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets the value of restrictions. If the restriction type is set to
        location. This would be different locations where the SKU is restricted.",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(string) })]
        string[] Value { get; set; }

    }
    /// Restrictions where the SKU cannot be used
    internal partial interface IResourceSkuRestrictionsInternal

    {
        /// <summary>
        /// Gets the reason for restriction. Possible values include: 'QuotaId', 'NotAvailableForSubscription'
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsReasonCode? ReasonCode { get; set; }
        /// <summary>Gets the information about the restriction where the SKU cannot be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceSkuRestrictionInfo RestrictionInfo { get; set; }
        /// <summary>Gets locations where the SKU is restricted</summary>
        string[] RestrictionInfoLocation { get; set; }
        /// <summary>Gets list of availability zones where the SKU is restricted.</summary>
        string[] RestrictionInfoZone { get; set; }
        /// <summary>Gets the type of restrictions. Possible values include: 'Location', 'Zone'</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ResourceSkuRestrictionsType? Type { get; set; }
        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is restricted.
        /// </summary>
        string[] Value { get; set; }

    }
}