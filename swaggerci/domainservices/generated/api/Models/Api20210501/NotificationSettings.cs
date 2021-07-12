namespace Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Extensions;

    /// <summary>Settings for notification</summary>
    public partial class NotificationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.INotificationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Models.Api20210501.INotificationSettingsInternal
    {

        /// <summary>Backing field for <see cref="AdditionalRecipient" /> property.</summary>
        private string[] _additionalRecipient;

        /// <summary>The list of additional recipients</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public string[] AdditionalRecipient { get => this._additionalRecipient; set => this._additionalRecipient = value; }

        /// <summary>Backing field for <see cref="NotifyDcAdmin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins? _notifyDcAdmin;

        /// <summary>Should domain controller admins be notified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins? NotifyDcAdmin { get => this._notifyDcAdmin; set => this._notifyDcAdmin = value; }

        /// <summary>Backing field for <see cref="NotifyGlobalAdmin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins? _notifyGlobalAdmin;

        /// <summary>Should global admins be notified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins? NotifyGlobalAdmin { get => this._notifyGlobalAdmin; set => this._notifyGlobalAdmin = value; }

        /// <summary>Creates an new <see cref="NotificationSettings" /> instance.</summary>
        public NotificationSettings()
        {

        }
    }
    /// Settings for notification
    public partial interface INotificationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.IJsonSerializable
    {
        /// <summary>The list of additional recipients</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of additional recipients",
        SerializedName = @"additionalRecipients",
        PossibleTypes = new [] { typeof(string) })]
        string[] AdditionalRecipient { get; set; }
        /// <summary>Should domain controller admins be notified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Should domain controller admins be notified",
        SerializedName = @"notifyDcAdmins",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins? NotifyDcAdmin { get; set; }
        /// <summary>Should global admins be notified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Should global admins be notified",
        SerializedName = @"notifyGlobalAdmins",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins) })]
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins? NotifyGlobalAdmin { get; set; }

    }
    /// Settings for notification
    internal partial interface INotificationSettingsInternal

    {
        /// <summary>The list of additional recipients</summary>
        string[] AdditionalRecipient { get; set; }
        /// <summary>Should domain controller admins be notified</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyDcAdmins? NotifyDcAdmin { get; set; }
        /// <summary>Should global admins be notified</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DomainServices.Support.NotifyGlobalAdmins? NotifyGlobalAdmin { get; set; }

    }
}