// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>Create or update a reference data set in the specified environment.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TimeSeriesInsights/environments/{environmentName}/referenceDataSets/{referenceDataSetName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzTimeSeriesInsightsReferenceDataSet_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Description(@"Create or update a reference data set in the specified environment.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Generated]
    public partial class NewAzTimeSeriesInsightsReferenceDataSet_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener
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
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.TimeSeriesInsightsClient Client => Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Module.Instance.ClientAPI;

        /// <summary>
        /// The reference data set key comparison behavior can be set using this property. By default, the value is 'Ordinal' - which
        /// means case sensitive key comparison will be performed while joining reference data with events or while adding new reference
        /// data. When 'OrdinalIgnoreCase' is set, case insensitive comparison will be used.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The reference data set key comparison behavior can be set using this property. By default, the value is 'Ordinal' - which means case sensitive key comparison will be performed while joining reference data with events or while adding new reference data. When 'OrdinalIgnoreCase' is set, case insensitive comparison will be used.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference data set key comparison behavior can be set using this property. By default, the value is 'Ordinal' - which means case sensitive key comparison will be performed while joining reference data with events or while adding new reference data. When 'OrdinalIgnoreCase' is set, case insensitive comparison will be used.",
        SerializedName = @"dataStringComparisonBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.DataStringComparisonBehavior) })]
        [global::System.Management.Automation.ArgumentCompleter(typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.DataStringComparisonBehavior))]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.DataStringComparisonBehavior DataStringComparisonBehavior { get => ParametersBody.DataStringComparisonBehavior ?? ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.DataStringComparisonBehavior)""); set => ParametersBody.DataStringComparisonBehavior = value; }

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="EnvironmentName" /> property.</summary>
        private string _environmentName;

        /// <summary>
        /// The name of the Time Series Insights environment associated with the specified resource group.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the Time Series Insights environment associated with the specified resource group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the Time Series Insights environment associated with the specified resource group.",
        SerializedName = @"environmentName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Path)]
        public string EnvironmentName { get => this._environmentName; set => this._environmentName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The list of key properties for the reference data set.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The list of key properties for the reference data set.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of key properties for the reference data set.",
        SerializedName = @"keyProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetKeyProperty) })]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetKeyProperty[] KeyProperty { get => ParametersBody.KeyProperty ?? null /* arrayOf */; set => ParametersBody.KeyProperty = value; }

        /// <summary>The location of the resource.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The location of the resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => ParametersBody.Location ?? null; set => ParametersBody.Location = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the reference data set.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the reference data set.")]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the reference data set.",
        SerializedName = @"referenceDataSetName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("ReferenceDataSetName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ParametersBody" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetCreateOrUpdateParameters _parametersBody= new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ReferenceDataSetCreateOrUpdateParameters();

        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetCreateOrUpdateParameters ParametersBody { get => this._parametersBody; set => this._parametersBody = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>Name of an Azure Resource group.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of an Azure Resource group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of an Azure Resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Path)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Azure Subscription ID.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Azure Subscription ID.")]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Azure Subscription ID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Key-value pairs of additional properties for the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ExportAs(typeof(global::System.Collections.Hashtable))]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Key-value pairs of additional properties for the resource.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Category(global::Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key-value pairs of additional properties for the resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesTags) })]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesTags Tag { get => ParametersBody.Tag ?? null /* object */; set => ParametersBody.Tag = value; }

        /// <summary>
        /// <c>overrideOnCreated</c> will be called before the regular onCreated has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onCreated method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICloudError"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICloudError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewAzTimeSeriesInsightsReferenceDataSet_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzTimeSeriesInsightsReferenceDataSet_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ReferenceDataSetsCreateOrUpdate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ReferenceDataSetsCreateOrUpdate(SubscriptionId, ResourceGroupName, EnvironmentName, Name, ParametersBody, onOk, onCreated, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  SubscriptionId=SubscriptionId,ResourceGroupName=ResourceGroupName,EnvironmentName=EnvironmentName,Name=Name,body=ParametersBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 201 (Created).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onCreated(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnCreated(responseMessage, response, ref _returnNow);
                // if overrideOnCreated has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onCreated - response for 201 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource
                WriteObject((await response));
            }
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICloudError"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICloudError> response)
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
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICloudError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, EnvironmentName=EnvironmentName, Name=Name, body=ParametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, ResourceGroupName=ResourceGroupName, EnvironmentName=EnvironmentName, Name=Name, body=ParametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource> response)
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
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IReferenceDataSetResource
                WriteObject((await response));
            }
        }
    }
}