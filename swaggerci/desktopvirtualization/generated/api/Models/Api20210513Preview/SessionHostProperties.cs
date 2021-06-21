namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Schema for SessionHost properties.</summary>
    public partial class SessionHostProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AgentVersion" /> property.</summary>
        private string _agentVersion;

        /// <summary>Version of agent on SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string AgentVersion { get => this._agentVersion; set => this._agentVersion = value; }

        /// <summary>Backing field for <see cref="AllowNewSession" /> property.</summary>
        private bool? _allowNewSession;

        /// <summary>Allow a new session.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public bool? AllowNewSession { get => this._allowNewSession; set => this._allowNewSession = value; }

        /// <summary>Backing field for <see cref="AssignedUser" /> property.</summary>
        private string _assignedUser;

        /// <summary>User assigned to SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string AssignedUser { get => this._assignedUser; set => this._assignedUser = value; }

        /// <summary>Backing field for <see cref="ImageResourceId" /> property.</summary>
        private string _imageResourceId;

        /// <summary>The resourceId of the image of session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string ImageResourceId { get => this._imageResourceId; }

        /// <summary>Backing field for <see cref="ImageType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? _imageType;

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageType { get => this._imageType; }

        /// <summary>Backing field for <see cref="LastHeartBeat" /> property.</summary>
        private global::System.DateTime? _lastHeartBeat;

        /// <summary>Last heart beat from SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? LastHeartBeat { get => this._lastHeartBeat; set => this._lastHeartBeat = value; }

        /// <summary>Backing field for <see cref="LastSessionHostUpdateTime" /> property.</summary>
        private global::System.DateTime? _lastSessionHostUpdateTime;

        /// <summary>The last time update was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? LastSessionHostUpdateTime { get => this._lastSessionHostUpdateTime; }

        /// <summary>Backing field for <see cref="LastUpdateTime" /> property.</summary>
        private global::System.DateTime? _lastUpdateTime;

        /// <summary>The timestamp of the last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdateTime { get => this._lastUpdateTime; }

        /// <summary>Internal Acessors for ImageResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.ImageResourceId { get => this._imageResourceId; set { {_imageResourceId = value;} } }

        /// <summary>Internal Acessors for ImageType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.ImageType { get => this._imageType; set { {_imageType = value;} } }

        /// <summary>Internal Acessors for LastSessionHostUpdateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.LastSessionHostUpdateTime { get => this._lastSessionHostUpdateTime; set { {_lastSessionHostUpdateTime = value;} } }

        /// <summary>Internal Acessors for LastUpdateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.LastUpdateTime { get => this._lastUpdateTime; set { {_lastUpdateTime = value;} } }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.ObjectId { get => this._objectId; set { {_objectId = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for SessionHostConfigurationLastUpdateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.SessionHostConfigurationLastUpdateTime { get => this._sessionHostConfigurationLastUpdateTime; set { {_sessionHostConfigurationLastUpdateTime = value;} } }

        /// <summary>Internal Acessors for SessionHostHealthCheckResult</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport[] Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.SessionHostHealthCheckResult { get => this._sessionHostHealthCheckResult; set { {_sessionHostHealthCheckResult = value;} } }

        /// <summary>Internal Acessors for StatusTimestamp</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.StatusTimestamp { get => this._statusTimestamp; set { {_statusTimestamp = value;} } }

        /// <summary>Internal Acessors for UpdateStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.UpdateStatus { get => this._updateStatus; set { {_updateStatus = value;} } }

        /// <summary>Internal Acessors for VirtualMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostPropertiesInternal.VirtualMachineId { get => this._virtualMachineId; set { {_virtualMachineId = value;} } }

        /// <summary>Backing field for <see cref="OSVersion" /> property.</summary>
        private string _oSVersion;

        /// <summary>The version of the OS on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string OSVersion { get => this._oSVersion; set => this._oSVersion = value; }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>ObjectId of SessionHost. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Resource Id of SessionHost's underlying virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="Session" /> property.</summary>
        private int? _session;

        /// <summary>Number of sessions on SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public int? Session { get => this._session; set => this._session = value; }

        /// <summary>
        /// Backing field for <see cref="SessionHostConfigurationLastUpdateTime" /> property.
        /// </summary>
        private global::System.DateTime? _sessionHostConfigurationLastUpdateTime;

        /// <summary>
        /// This time will match the time in the session host configuration for when the update was initiated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? SessionHostConfigurationLastUpdateTime { get => this._sessionHostConfigurationLastUpdateTime; }

        /// <summary>Backing field for <see cref="SessionHostHealthCheckResult" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport[] _sessionHostHealthCheckResult;

        /// <summary>List of SessionHostHealthCheckReports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport[] SessionHostHealthCheckResult { get => this._sessionHostHealthCheckResult; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Status? _status;

        /// <summary>Status for a SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Status? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StatusTimestamp" /> property.</summary>
        private global::System.DateTime? _statusTimestamp;

        /// <summary>The timestamp of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public global::System.DateTime? StatusTimestamp { get => this._statusTimestamp; }

        /// <summary>Backing field for <see cref="SxSStackVersion" /> property.</summary>
        private string _sxSStackVersion;

        /// <summary>The version of the side by side stack on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string SxSStackVersion { get => this._sxSStackVersion; set => this._sxSStackVersion = value; }

        /// <summary>Backing field for <see cref="UpdateErrorMessage" /> property.</summary>
        private string _updateErrorMessage;

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string UpdateErrorMessage { get => this._updateErrorMessage; set => this._updateErrorMessage = value; }

        /// <summary>Backing field for <see cref="UpdateState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.UpdateState? _updateState;

        /// <summary>Update state of a SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.UpdateState? UpdateState { get => this._updateState; set => this._updateState = value; }

        /// <summary>Backing field for <see cref="UpdateStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus? _updateStatus;

        /// <summary>Updating state of the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus? UpdateStatus { get => this._updateStatus; }

        /// <summary>Backing field for <see cref="VirtualMachineId" /> property.</summary>
        private string _virtualMachineId;

        /// <summary>Virtual Machine Id of SessionHost's underlying virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.PropertyOrigin.Owned)]
        public string VirtualMachineId { get => this._virtualMachineId; }

        /// <summary>Creates an new <see cref="SessionHostProperties" /> instance.</summary>
        public SessionHostProperties()
        {

        }
    }
    /// Schema for SessionHost properties.
    public partial interface ISessionHostProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IJsonSerializable
    {
        /// <summary>Version of agent on SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of agent on SessionHost.",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentVersion { get; set; }
        /// <summary>Allow a new session.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allow a new session.",
        SerializedName = @"allowNewSession",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowNewSession { get; set; }
        /// <summary>User assigned to SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User assigned to SessionHost.",
        SerializedName = @"assignedUser",
        PossibleTypes = new [] { typeof(string) })]
        string AssignedUser { get; set; }
        /// <summary>The resourceId of the image of session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resourceId of the image of session host.",
        SerializedName = @"imageResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageResourceId { get;  }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of image session hosts use in the hostpool.",
        SerializedName = @"imageType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageType { get;  }
        /// <summary>Last heart beat from SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last heart beat from SessionHost.",
        SerializedName = @"lastHeartBeat",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastHeartBeat { get; set; }
        /// <summary>The last time update was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time update was completed.",
        SerializedName = @"lastSessionHostUpdateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastSessionHostUpdateTime { get;  }
        /// <summary>The timestamp of the last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp of the last update.",
        SerializedName = @"lastUpdateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdateTime { get;  }
        /// <summary>The version of the OS on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the OS on the session host.",
        SerializedName = @"osVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OSVersion { get; set; }
        /// <summary>ObjectId of SessionHost. (internal use)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ObjectId of SessionHost. (internal use)",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get;  }
        /// <summary>Resource Id of SessionHost's underlying virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource Id of SessionHost's underlying virtual machine.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>Number of sessions on SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of sessions on SessionHost.",
        SerializedName = @"sessions",
        PossibleTypes = new [] { typeof(int) })]
        int? Session { get; set; }
        /// <summary>
        /// This time will match the time in the session host configuration for when the update was initiated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This time will match the time in the session host configuration for when the update was initiated.",
        SerializedName = @"sessionHostConfigurationLastUpdateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SessionHostConfigurationLastUpdateTime { get;  }
        /// <summary>List of SessionHostHealthCheckReports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of SessionHostHealthCheckReports",
        SerializedName = @"sessionHostHealthCheckResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport[] SessionHostHealthCheckResult { get;  }
        /// <summary>Status for a SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status for a SessionHost.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Status? Status { get; set; }
        /// <summary>The timestamp of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp of the status.",
        SerializedName = @"statusTimestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusTimestamp { get;  }
        /// <summary>The version of the side by side stack on the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the side by side stack on the session host.",
        SerializedName = @"sxSStackVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SxSStackVersion { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error message.",
        SerializedName = @"updateErrorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateErrorMessage { get; set; }
        /// <summary>Update state of a SessionHost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Update state of a SessionHost.",
        SerializedName = @"updateState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.UpdateState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.UpdateState? UpdateState { get; set; }
        /// <summary>Updating state of the session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Updating state of the session host.",
        SerializedName = @"updateStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus? UpdateStatus { get;  }
        /// <summary>Virtual Machine Id of SessionHost's underlying virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Virtual Machine Id of SessionHost's underlying virtual machine.",
        SerializedName = @"virtualMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineId { get;  }

    }
    /// Schema for SessionHost properties.
    internal partial interface ISessionHostPropertiesInternal

    {
        /// <summary>Version of agent on SessionHost.</summary>
        string AgentVersion { get; set; }
        /// <summary>Allow a new session.</summary>
        bool? AllowNewSession { get; set; }
        /// <summary>User assigned to SessionHost.</summary>
        string AssignedUser { get; set; }
        /// <summary>The resourceId of the image of session host.</summary>
        string ImageResourceId { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.ImageType? ImageType { get; set; }
        /// <summary>Last heart beat from SessionHost.</summary>
        global::System.DateTime? LastHeartBeat { get; set; }
        /// <summary>The last time update was completed.</summary>
        global::System.DateTime? LastSessionHostUpdateTime { get; set; }
        /// <summary>The timestamp of the last update.</summary>
        global::System.DateTime? LastUpdateTime { get; set; }
        /// <summary>The version of the OS on the session host.</summary>
        string OSVersion { get; set; }
        /// <summary>ObjectId of SessionHost. (internal use)</summary>
        string ObjectId { get; set; }
        /// <summary>Resource Id of SessionHost's underlying virtual machine.</summary>
        string ResourceId { get; set; }
        /// <summary>Number of sessions on SessionHost.</summary>
        int? Session { get; set; }
        /// <summary>
        /// This time will match the time in the session host configuration for when the update was initiated.
        /// </summary>
        global::System.DateTime? SessionHostConfigurationLastUpdateTime { get; set; }
        /// <summary>List of SessionHostHealthCheckReports</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210513Preview.ISessionHostHealthCheckReport[] SessionHostHealthCheckResult { get; set; }
        /// <summary>Status for a SessionHost.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.Status? Status { get; set; }
        /// <summary>The timestamp of the status.</summary>
        global::System.DateTime? StatusTimestamp { get; set; }
        /// <summary>The version of the side by side stack on the session host.</summary>
        string SxSStackVersion { get; set; }
        /// <summary>The error message.</summary>
        string UpdateErrorMessage { get; set; }
        /// <summary>Update state of a SessionHost.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.UpdateState? UpdateState { get; set; }
        /// <summary>Updating state of the session host.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Support.SessionHostUpdateStatus? UpdateStatus { get; set; }
        /// <summary>Virtual Machine Id of SessionHost's underlying virtual machine.</summary>
        string VirtualMachineId { get; set; }

    }
}