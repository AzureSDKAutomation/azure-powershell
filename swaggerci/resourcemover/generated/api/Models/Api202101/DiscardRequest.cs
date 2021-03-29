namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Extensions;

    /// <summary>Defines the request body for discard operation.</summary>
    public partial class DiscardRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IDiscardRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Models.Api202101.IDiscardRequestInternal
    {

        /// <summary>Backing field for <see cref="MoveResource" /> property.</summary>
        private string[] _moveResource;

        /// <summary>
        /// Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via
        /// moveResourceInputType property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Owned)]
        public string[] MoveResource { get => this._moveResource; set => this._moveResource = value; }

        /// <summary>Backing field for <see cref="MoveResourceInputType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType? _moveResourceInputType;

        /// <summary>Defines the move resource input type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType? MoveResourceInputType { get => this._moveResourceInputType; set => this._moveResourceInputType = value; }

        /// <summary>Backing field for <see cref="ValidateOnly" /> property.</summary>
        private bool? _validateOnly;

        /// <summary>
        /// Gets or sets a value indicating whether the operation needs to only run pre-requisite.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.PropertyOrigin.Owned)]
        public bool? ValidateOnly { get => this._validateOnly; set => this._validateOnly = value; }

        /// <summary>Creates an new <see cref="DiscardRequest" /> instance.</summary>
        public DiscardRequest()
        {

        }
    }
    /// Defines the request body for discard operation.
    public partial interface IDiscardRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via
        /// moveResourceInputType property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via moveResourceInputType property.",
        SerializedName = @"moveResources",
        PossibleTypes = new [] { typeof(string) })]
        string[] MoveResource { get; set; }
        /// <summary>Defines the move resource input type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines the move resource input type.",
        SerializedName = @"moveResourceInputType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType? MoveResourceInputType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the operation needs to only run pre-requisite.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a value indicating whether the operation needs to only run pre-requisite.",
        SerializedName = @"validateOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidateOnly { get; set; }

    }
    /// Defines the request body for discard operation.
    internal partial interface IDiscardRequestInternal

    {
        /// <summary>
        /// Gets or sets the list of resource Id's, by default it accepts move resource id's unless the input type is switched via
        /// moveResourceInputType property.
        /// </summary>
        string[] MoveResource { get; set; }
        /// <summary>Defines the move resource input type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ResourceMoverServiceApi.Support.MoveResourceInputType? MoveResourceInputType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the operation needs to only run pre-requisite.
        /// </summary>
        bool? ValidateOnly { get; set; }

    }
}