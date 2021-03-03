namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Extensions;

    /// <summary>A notification hub that has been linked to the communication service</summary>
    public partial class LinkedNotificationHub :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.ILinkedNotificationHub,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Models.Api20200820Preview.ILinkedNotificationHubInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="LinkedNotificationHub" /> instance.</summary>
        public LinkedNotificationHub()
        {

        }
    }
    /// A notification hub that has been linked to the communication service
    public partial interface ILinkedNotificationHub :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the notification hub",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// A notification hub that has been linked to the communication service
    internal partial interface ILinkedNotificationHubInternal

    {
        /// <summary>The resource ID of the notification hub</summary>
        string ResourceId { get; set; }

    }
}