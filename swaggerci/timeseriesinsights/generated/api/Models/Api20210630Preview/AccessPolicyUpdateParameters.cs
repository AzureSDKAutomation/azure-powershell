namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    public partial class AccessPolicyUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyUpdateParametersInternal
    {

        /// <summary>An description of the access policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutablePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutablePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutableProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.AccessPolicyMutableProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutableProperties _property;

        /// <summary>An object that represents a set of mutable access policy resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutableProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.AccessPolicyMutableProperties()); set => this._property = value; }

        /// <summary>The list of roles the principal is assigned on the environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.AccessPolicyRole[] Role { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutablePropertiesInternal)Property).Role; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutablePropertiesInternal)Property).Role = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="AccessPolicyUpdateParameters" /> instance.</summary>
        public AccessPolicyUpdateParameters()
        {

        }
    }
    public partial interface IAccessPolicyUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable
    {
        /// <summary>An description of the access policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An description of the access policy.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The list of roles the principal is assigned on the environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of roles the principal is assigned on the environment.",
        SerializedName = @"roles",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.AccessPolicyRole) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.AccessPolicyRole[] Role { get; set; }

    }
    internal partial interface IAccessPolicyUpdateParametersInternal

    {
        /// <summary>An description of the access policy.</summary>
        string Description { get; set; }
        /// <summary>An object that represents a set of mutable access policy resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20210630Preview.IAccessPolicyMutableProperties Property { get; set; }
        /// <summary>The list of roles the principal is assigned on the environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.AccessPolicyRole[] Role { get; set; }

    }
}