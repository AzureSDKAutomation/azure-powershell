namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    public partial class ConnectionDetail :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetail,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The private endpoint connection group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="LinkIdentifier" /> property.</summary>
        private string _linkIdentifier;

        /// <summary>The private endpoint connection link identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string LinkIdentifier { get => this._linkIdentifier; }

        /// <summary>Backing field for <see cref="MemberName" /> property.</summary>
        private string _memberName;

        /// <summary>The private endpoint connection member name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string MemberName { get => this._memberName; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LinkIdentifier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal.LinkIdentifier { get => this._linkIdentifier; set { {_linkIdentifier = value;} } }

        /// <summary>Internal Acessors for MemberName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal.MemberName { get => this._memberName; set { {_memberName = value;} } }

        /// <summary>Internal Acessors for PrivateIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210518.IConnectionDetailInternal.PrivateIPAddress { get => this._privateIPAddress; set { {_privateIPAddress = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>The private endpoint connection private ip address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; }

        /// <summary>Creates an new <see cref="ConnectionDetail" /> instance.</summary>
        public ConnectionDetail()
        {

        }
    }
    public partial interface IConnectionDetail :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>The private endpoint connection group id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private endpoint connection group id",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The private endpoint connection link identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private endpoint connection link identifier",
        SerializedName = @"linkIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string LinkIdentifier { get;  }
        /// <summary>The private endpoint connection member name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private endpoint connection member name",
        SerializedName = @"memberName",
        PossibleTypes = new [] { typeof(string) })]
        string MemberName { get;  }
        /// <summary>The private endpoint connection private ip address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private endpoint connection private ip address",
        SerializedName = @"privateIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get;  }

    }
    internal partial interface IConnectionDetailInternal

    {
        /// <summary>The private endpoint connection group id</summary>
        string GroupId { get; set; }
        /// <summary>Azure resource Id</summary>
        string Id { get; set; }
        /// <summary>The private endpoint connection link identifier</summary>
        string LinkIdentifier { get; set; }
        /// <summary>The private endpoint connection member name</summary>
        string MemberName { get; set; }
        /// <summary>The private endpoint connection private ip address</summary>
        string PrivateIPAddress { get; set; }

    }
}