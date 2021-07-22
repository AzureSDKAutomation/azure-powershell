namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Connect information from the Workspace to a single endpoint.</summary>
    public partial class EndpointDetail :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDetail,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEndpointDetailInternal
    {

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>An IP Address that Domain Name currently resolves to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="IsAccessable" /> property.</summary>
        private bool? _isAccessable;

        /// <summary>
        /// Whether it is possible to create a connection from the Workspace to this IpAddress at this Port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public bool? IsAccessable { get => this._isAccessable; set => this._isAccessable = value; }

        /// <summary>Backing field for <see cref="Latency" /> property.</summary>
        private double? _latency;

        /// <summary>
        /// The time in milliseconds it takes for the connection to be created from the Workspace to this IpAddress at this Port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public double? Latency { get => this._latency; set => this._latency = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>The port an endpoint is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public int? Port { get => this._port; set => this._port = value; }

        /// <summary>Creates an new <see cref="EndpointDetail" /> instance.</summary>
        public EndpointDetail()
        {

        }
    }
    /// Connect information from the Workspace to a single endpoint.
    public partial interface IEndpointDetail :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>An IP Address that Domain Name currently resolves to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An IP Address that Domain Name currently resolves to.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>
        /// Whether it is possible to create a connection from the Workspace to this IpAddress at this Port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether it is possible to create a connection from the Workspace to this IpAddress at this Port.",
        SerializedName = @"isAccessable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAccessable { get; set; }
        /// <summary>
        /// The time in milliseconds it takes for the connection to be created from the Workspace to this IpAddress at this Port.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time in milliseconds it takes for the connection to be created from the Workspace to this IpAddress at this Port.",
        SerializedName = @"latency",
        PossibleTypes = new [] { typeof(double) })]
        double? Latency { get; set; }
        /// <summary>The port an endpoint is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port an endpoint is connected to.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get; set; }

    }
    /// Connect information from the Workspace to a single endpoint.
    internal partial interface IEndpointDetailInternal

    {
        /// <summary>An IP Address that Domain Name currently resolves to.</summary>
        string IPAddress { get; set; }
        /// <summary>
        /// Whether it is possible to create a connection from the Workspace to this IpAddress at this Port.
        /// </summary>
        bool? IsAccessable { get; set; }
        /// <summary>
        /// The time in milliseconds it takes for the connection to be created from the Workspace to this IpAddress at this Port.
        /// </summary>
        double? Latency { get; set; }
        /// <summary>The port an endpoint is connected to.</summary>
        int? Port { get; set; }

    }
}