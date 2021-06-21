namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>State of the private endpoint connection.</summary>
    public partial class PrivateLinkServiceConnectionStateProperty :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateLinkServiceConnectionStateProperty,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateLinkServiceConnectionStatePropertyInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private string _actionsRequired;

        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ActionsRequired { get => this._actionsRequired; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ActionsRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210621.IPrivateLinkServiceConnectionStatePropertyInternal.ActionsRequired { get => this._actionsRequired; set { {_actionsRequired = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>
        /// Creates an new <see cref="PrivateLinkServiceConnectionStateProperty" /> instance.
        /// </summary>
        public PrivateLinkServiceConnectionStateProperty()
        {

        }
    }
    /// State of the private endpoint connection.
    public partial interface IPrivateLinkServiceConnectionStateProperty :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>The actions required for private link service connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The actions required for private link service connection.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ActionsRequired { get;  }
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// State of the private endpoint connection.
    internal partial interface IPrivateLinkServiceConnectionStatePropertyInternal

    {
        /// <summary>The actions required for private link service connection.</summary>
        string ActionsRequired { get; set; }
        /// <summary>The private link service connection description.</summary>
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        string Status { get; set; }

    }
}