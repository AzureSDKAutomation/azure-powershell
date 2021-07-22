// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Extensions;

    /// <summary>Remove a host pool.</summary>
    /// <remarks>
    /// [OpenAPI] Delete=>DELETE:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Remove, @"AzDesktopVirtualizationApiHostPool_DeleteViaIdentity", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(bool))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Description(@"Remove a host pool.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Generated]
    public partial class RemoveAzDesktopVirtualizationApiHostPool_DeleteViaIdentity : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener
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

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.DesktopVirtualizationApiClient Client => Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="Force" /> property.</summary>
        private global::System.Management.Automation.SwitchParameter _force;

        /// <summary>Force flag to delete sessionHost.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Force flag to delete sessionHost.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Force flag to delete sessionHost.",
        SerializedName = @"force",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Query)]
        public global::System.Management.Automation.SwitchParameter Force { get => this._force; set => this._force = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.IDesktopVirtualizationApiIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.IDesktopVirtualizationApiIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Category(global::Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.ICloudError"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.ICloudError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNoContent</c> will be called before the regular onNoContent has been processed, allowing customization of
        /// what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onNoContent method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNoContent(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
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
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'HostPoolsDelete' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (InputObject?.Id != null)
                    {
                        await this.Client.HostPoolsDeleteViaIdentity(InputObject.Id, this.InvocationInformation.BoundParameters.ContainsKey("Force") ? Force : default(global::System.Management.Automation.SwitchParameter?), onOk, onNoContent, onDefault, this, Pipeline);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == InputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        if (null == InputObject.HostPoolName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.HostPoolName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                        }
                        await this.Client.HostPoolsDelete(InputObject.SubscriptionId ?? null, InputObject.ResourceGroupName ?? null, InputObject.HostPoolName ?? null, this.InvocationInformation.BoundParameters.ContainsKey("Force") ? Force : default(global::System.Management.Automation.SwitchParameter?), onOk, onNoContent, onDefault, this, Pipeline);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  Force=this.InvocationInformation.BoundParameters.ContainsKey("Force") ? Force : default(global::System.Management.Automation.SwitchParameter?)})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="RemoveAzDesktopVirtualizationApiHostPool_DeleteViaIdentity" /> cmdlet class.
        /// </summary>
        public RemoveAzDesktopVirtualizationApiHostPool_DeleteViaIdentity()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.ICloudError"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.ICloudError> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualizationApi.Models.Api20210712.ICloudError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { Force=this.InvocationInformation.BoundParameters.ContainsKey("Force") ? Force : default(global::System.Management.Automation.SwitchParameter?) })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { Force=this.InvocationInformation.BoundParameters.ContainsKey("Force") ? Force : default(global::System.Management.Automation.SwitchParameter?) })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 204 (NoContent).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNoContent(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnNoContent(responseMessage, ref _returnNow);
                // if overrideOnNoContent has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onNoContent - response for 204 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}