// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Extensions;

    /// <summary>
    /// Updates the metadata of a Windows IoT Device Service. The usual pattern to modify a property is to retrieve the Windows
    /// IoT Device Service metadata and security metadata, and then combine them with the modified values in a new body to update
    /// the Windows IoT Device Service.
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Update=>PATCH:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.WindowsIoT/deviceServices/{deviceName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzDeviceServicesService_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Description(@"Updates the metadata of a Windows IoT Device Service. The usual pattern to modify a property is to retrieve the Windows IoT Device Service metadata and security metadata, and then combine them with the modified values in a new body to update the Windows IoT Device Service.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Generated]
    public partial class UpdateAzDeviceServicesService_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Windows IoT Device Service OEM AAD domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Windows IoT Device Service OEM AAD domain")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Windows IoT Device Service OEM AAD domain",
        SerializedName = @"adminDomainName",
        PossibleTypes = new [] { typeof(string) })]
        public string AdminDomainName { get => DeviceServiceBody.AdminDomainName ?? null; set => DeviceServiceBody.AdminDomainName = value; }

        /// <summary>Windows IoT Device Service ODM AAD domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Windows IoT Device Service ODM AAD domain")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Windows IoT Device Service ODM AAD domain",
        SerializedName = @"billingDomainName",
        PossibleTypes = new [] { typeof(string) })]
        public string BillingDomainName { get => DeviceServiceBody.BillingDomainName ?? null; set => DeviceServiceBody.BillingDomainName = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.DeviceServices Client => Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="DeviceName" /> property.</summary>
        private string _deviceName;

        /// <summary>The name of the Windows IoT Device Service.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the Windows IoT Device Service.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the Windows IoT Device Service.",
        SerializedName = @"deviceName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Path)]
        public string DeviceName { get => this._deviceName; set => this._deviceName = value; }

        /// <summary>Backing field for <see cref="DeviceServiceBody" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService _deviceServiceBody= new Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.DeviceService();

        /// <summary>The description of the Windows IoT Device Service.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService DeviceServiceBody { get => this._deviceServiceBody; set => this._deviceServiceBody = value; }

        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        public string Etag { get => DeviceServiceBody.Etag ?? null; set => DeviceServiceBody.Etag = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="IfMatch" /> property.</summary>
        private string _ifMatch;

        /// <summary>
        /// ETag of the Windows IoT Device Service. Do not specify for creating a brand new Windows IoT Device Service. Required to
        /// update an existing Windows IoT Device Service.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "ETag of the Windows IoT Device Service. Do not specify for creating a brand new Windows IoT Device Service. Required to update an existing Windows IoT Device Service.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ETag of the Windows IoT Device Service. Do not specify for creating a brand new Windows IoT Device Service. Required to update an existing Windows IoT Device Service.",
        SerializedName = @"If-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Header)]
        public string IfMatch { get => this._ifMatch; set => this._ifMatch = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The Azure Region where the resource lives</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Azure Region where the resource lives")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Region where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => DeviceServiceBody.Location ?? null; set => DeviceServiceBody.Location = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Windows IoT Device Service notes.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Windows IoT Device Service notes.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Windows IoT Device Service notes.",
        SerializedName = @"notes",
        PossibleTypes = new [] { typeof(string) })]
        public string Note { get => DeviceServiceBody.Note ?? null; set => DeviceServiceBody.Note = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Windows IoT Device Service device allocation.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Windows IoT Device Service device allocation.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Windows IoT Device Service device allocation.",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(long) })]
        public long Quantity { get => DeviceServiceBody.Quantity ?? default(long); set => DeviceServiceBody.Quantity = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group that contains the Windows IoT Device Service.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group that contains the Windows IoT Device Service.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the resource group that contains the Windows IoT Device Service.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription identifier.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The subscription identifier.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The subscription identifier.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Resource tags.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Resource tags.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ITrackedResourceTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.ITrackedResourceTags Tag { get => DeviceServiceBody.Tag ?? null /* object */; set => DeviceServiceBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ServicesUpdate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ServicesUpdate(SubscriptionId, ResourceGroupName, DeviceName, this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, DeviceServiceBody, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,DeviceName=DeviceName,IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null,body=DeviceServiceBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="UpdateAzDeviceServicesService_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public UpdateAzDeviceServicesService_UpdateExpanded()
        {

        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IErrorDetails>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, DeviceName=DeviceName, IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, body=DeviceServiceBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, DeviceName=DeviceName, IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, body=DeviceServiceBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.DeviceServices.Models.Api20190601.IDeviceService
                WriteObject((await response));
            }
        }
    }
}