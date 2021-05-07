namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class DataSourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDataSourceTagsInternal
    {

        /// <summary>Creates an new <see cref="DataSourceTags" /> instance.</summary>
        public DataSourceTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IDataSourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IDataSourceTagsInternal

    {

    }
}