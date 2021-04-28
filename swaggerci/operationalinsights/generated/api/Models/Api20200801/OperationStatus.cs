namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The status of operation.</summary>
    public partial class OperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private string _endTime;

        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponse _error;

        /// <summary>The error detail of the operation if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponse Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ErrorResponse()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponse Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.ErrorResponse()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ErrorDetailError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.ErrorDetailError { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Error = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IOperationStatusInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Target = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponseInternal)Error).Target; }

        /// <summary>Creates an new <see cref="OperationStatus" /> instance.</summary>
        public OperationStatus()
        {

        }
    }
    /// The status of operation.
    public partial interface IOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail[] Detail { get;  }
        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end time of the operation.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(string) })]
        string EndTime { get; set; }
        /// <summary>The operation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operation Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operation name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time of the operation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get; set; }
        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The status of operation.
    internal partial interface IOperationStatusInternal

    {
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail[] Detail { get; set; }
        /// <summary>The end time of the operation.</summary>
        string EndTime { get; set; }
        /// <summary>The error detail of the operation if any.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorResponse Error { get; set; }
        /// <summary>The error object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20.IErrorDetail ErrorDetailError { get; set; }
        /// <summary>The operation Id.</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The operation name.</summary>
        string Name { get; set; }
        /// <summary>The start time of the operation.</summary>
        string StartTime { get; set; }
        /// <summary>The status of the operation.</summary>
        string Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}