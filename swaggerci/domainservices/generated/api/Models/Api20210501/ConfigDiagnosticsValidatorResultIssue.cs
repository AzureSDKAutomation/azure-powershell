namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Specific issue for a particular config diagnostics validator</summary>
    public partial class ConfigDiagnosticsValidatorResultIssue :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssueInternal
    {

        /// <summary>Backing field for <see cref="DescriptionParam" /> property.</summary>
        private string[] _descriptionParam;

        /// <summary>
        /// List of domain resource property name or values used to compose a rich description.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string[] DescriptionParam { get => this._descriptionParam; set => this._descriptionParam = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Validation issue identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ConfigDiagnosticsValidatorResultIssue" /> instance.</summary>
        public ConfigDiagnosticsValidatorResultIssue()
        {

        }
    }
    /// Specific issue for a particular config diagnostics validator
    public partial interface IConfigDiagnosticsValidatorResultIssue :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of domain resource property name or values used to compose a rich description.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of domain resource property name or values used to compose a rich description.",
        SerializedName = @"descriptionParams",
        PossibleTypes = new [] { typeof(string) })]
        string[] DescriptionParam { get; set; }
        /// <summary>Validation issue identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validation issue identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Specific issue for a particular config diagnostics validator
    internal partial interface IConfigDiagnosticsValidatorResultIssueInternal

    {
        /// <summary>
        /// List of domain resource property name or values used to compose a rich description.
        /// </summary>
        string[] DescriptionParam { get; set; }
        /// <summary>Validation issue identifier.</summary>
        string Id { get; set; }

    }
}