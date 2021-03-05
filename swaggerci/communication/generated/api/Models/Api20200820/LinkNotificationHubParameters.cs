namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>Description of an Azure Notification Hub to link to the communication service</summary>
    public partial class LinkNotificationHubParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILinkNotificationHubParameters,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820.ILinkNotificationHubParametersInternal
    {

        /// <summary>Backing field for <see cref="ConnectionString" /> property.</summary>
        private string _connectionString;

        /// <summary>Connection string for the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string ConnectionString { get => this._connectionString; set => this._connectionString = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="LinkNotificationHubParameters" /> instance.</summary>
        public LinkNotificationHubParameters()
        {

        }
    }
    /// Description of an Azure Notification Hub to link to the communication service
    public partial interface ILinkNotificationHubParameters :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>Connection string for the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Connection string for the notification hub",
        SerializedName = @"connectionString",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionString { get; set; }
        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID of the notification hub",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// Description of an Azure Notification Hub to link to the communication service
    internal partial interface ILinkNotificationHubParametersInternal

    {
        /// <summary>Connection string for the notification hub</summary>
        string ConnectionString { get; set; }
        /// <summary>The resource ID of the notification hub</summary>
        string ResourceId { get; set; }

    }
}