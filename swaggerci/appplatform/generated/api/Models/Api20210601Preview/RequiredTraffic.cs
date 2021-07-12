namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Required inbound or outbound traffic for Azure Spring Cloud instance.</summary>
    public partial class RequiredTraffic :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTraffic,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal
    {

        /// <summary>Backing field for <see cref="Direction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection? _direction;

        /// <summary>The direction of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection? Direction { get => this._direction; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string[] _fqdn;

        /// <summary>The FQDN list of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="IP" /> property.</summary>
        private string[] _iP;

        /// <summary>The ip list of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string[] IP { get => this._iP; }

        /// <summary>Internal Acessors for Direction</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal.Direction { get => this._direction; set { {_direction = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for IP</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal.IP { get => this._iP; set { {_iP = value;} } }

        /// <summary>Internal Acessors for Port</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal.Port { get => this._port; set { {_port = value;} } }

        /// <summary>Internal Acessors for Protocol</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IRequiredTrafficInternal.Protocol { get => this._protocol; set { {_protocol = value;} } }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>The port of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? Port { get => this._port; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>The protocol of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; }

        /// <summary>Creates an new <see cref="RequiredTraffic" /> instance.</summary>
        public RequiredTraffic()
        {

        }
    }
    /// Required inbound or outbound traffic for Azure Spring Cloud instance.
    public partial interface IRequiredTraffic :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>The direction of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The direction of required traffic",
        SerializedName = @"direction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection? Direction { get;  }
        /// <summary>The FQDN list of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The FQDN list of required traffic",
        SerializedName = @"fqdns",
        PossibleTypes = new [] { typeof(string) })]
        string[] Fqdn { get;  }
        /// <summary>The ip list of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ip list of required traffic",
        SerializedName = @"ips",
        PossibleTypes = new [] { typeof(string) })]
        string[] IP { get;  }
        /// <summary>The port of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The port of required traffic",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get;  }
        /// <summary>The protocol of required traffic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The protocol of required traffic",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        string Protocol { get;  }

    }
    /// Required inbound or outbound traffic for Azure Spring Cloud instance.
    internal partial interface IRequiredTrafficInternal

    {
        /// <summary>The direction of required traffic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.TrafficDirection? Direction { get; set; }
        /// <summary>The FQDN list of required traffic</summary>
        string[] Fqdn { get; set; }
        /// <summary>The ip list of required traffic</summary>
        string[] IP { get; set; }
        /// <summary>The port of required traffic</summary>
        int? Port { get; set; }
        /// <summary>The protocol of required traffic</summary>
        string Protocol { get; set; }

    }
}