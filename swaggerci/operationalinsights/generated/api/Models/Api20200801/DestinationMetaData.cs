namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Destination meta data.</summary>
    public partial class DestinationMetaData :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaData,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IDestinationMetaDataInternal
    {

        /// <summary>Backing field for <see cref="EventHubName" /> property.</summary>
        private string _eventHubName;

        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string EventHubName { get => this._eventHubName; set => this._eventHubName = value; }

        /// <summary>Creates an new <see cref="DestinationMetaData" /> instance.</summary>
        public DestinationMetaData()
        {

        }
    }
    /// Destination meta data.
    public partial interface IDestinationMetaData :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubName { get; set; }

    }
    /// Destination meta data.
    internal partial interface IDestinationMetaDataInternal

    {
        /// <summary>
        /// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
        /// </summary>
        string EventHubName { get; set; }

    }
}