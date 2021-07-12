namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Config Diagnostics validator result data</summary>
    public partial class ConfigDiagnosticsValidatorResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResult,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultInternal
    {

        /// <summary>Backing field for <see cref="Issue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue[] _issue;

        /// <summary>List of resource config validation issues.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue[] Issue { get => this._issue; set => this._issue = value; }

        /// <summary>Backing field for <see cref="ReplicaSetSubnetDisplayName" /> property.</summary>
        private string _replicaSetSubnetDisplayName;

        /// <summary>Replica set location and subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string ReplicaSetSubnetDisplayName { get => this._replicaSetSubnetDisplayName; set => this._replicaSetSubnetDisplayName = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Status? _status;

        /// <summary>Status for individual validator after running diagnostics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Status? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="ValidatorId" /> property.</summary>
        private string _validatorId;

        /// <summary>Validator identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string ValidatorId { get => this._validatorId; set => this._validatorId = value; }

        /// <summary>Creates an new <see cref="ConfigDiagnosticsValidatorResult" /> instance.</summary>
        public ConfigDiagnosticsValidatorResult()
        {

        }
    }
    /// Config Diagnostics validator result data
    public partial interface IConfigDiagnosticsValidatorResult :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>List of resource config validation issues.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of resource config validation issues.",
        SerializedName = @"issues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue[] Issue { get; set; }
        /// <summary>Replica set location and subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replica set location and subnet name",
        SerializedName = @"replicaSetSubnetDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaSetSubnetDisplayName { get; set; }
        /// <summary>Status for individual validator after running diagnostics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status for individual validator after running diagnostics.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Status? Status { get; set; }
        /// <summary>Validator identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validator identifier",
        SerializedName = @"validatorId",
        PossibleTypes = new [] { typeof(string) })]
        string ValidatorId { get; set; }

    }
    /// Config Diagnostics validator result data
    internal partial interface IConfigDiagnosticsValidatorResultInternal

    {
        /// <summary>List of resource config validation issues.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.IConfigDiagnosticsValidatorResultIssue[] Issue { get; set; }
        /// <summary>Replica set location and subnet name</summary>
        string ReplicaSetSubnetDisplayName { get; set; }
        /// <summary>Status for individual validator after running diagnostics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.Status? Status { get; set; }
        /// <summary>Validator identifier</summary>
        string ValidatorId { get; set; }

    }
}