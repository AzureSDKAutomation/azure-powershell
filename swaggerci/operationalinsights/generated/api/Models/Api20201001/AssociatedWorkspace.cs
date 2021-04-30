namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>The list of Log Analytics workspaces associated with the cluster.</summary>
    public partial class AssociatedWorkspace :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspace,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal
    {

        /// <summary>Backing field for <see cref="AssociateDate" /> property.</summary>
        private string _associateDate;

        /// <summary>The time of workspace association.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string AssociateDate { get => this._associateDate; }

        /// <summary>Internal Acessors for AssociateDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal.AssociateDate { get => this._associateDate; set { {_associateDate = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for WorkspaceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal.WorkspaceId { get => this._workspaceId; set { {_workspaceId = value;} } }

        /// <summary>Internal Acessors for WorkspaceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20201001.IAssociatedWorkspaceInternal.WorkspaceName { get => this._workspaceName; set { {_workspaceName = value;} } }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The ResourceId id the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="WorkspaceId" /> property.</summary>
        private string _workspaceId;

        /// <summary>The id of the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string WorkspaceId { get => this._workspaceId; }

        /// <summary>Backing field for <see cref="WorkspaceName" /> property.</summary>
        private string _workspaceName;

        /// <summary>The name id the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string WorkspaceName { get => this._workspaceName; }

        /// <summary>Creates an new <see cref="AssociatedWorkspace" /> instance.</summary>
        public AssociatedWorkspace()
        {

        }
    }
    /// The list of Log Analytics workspaces associated with the cluster.
    public partial interface IAssociatedWorkspace :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The time of workspace association.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of workspace association.",
        SerializedName = @"associateDate",
        PossibleTypes = new [] { typeof(string) })]
        string AssociateDate { get;  }
        /// <summary>The ResourceId id the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ResourceId id the assigned workspace.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>The id of the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of the assigned workspace.",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceId { get;  }
        /// <summary>The name id the assigned workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name id the assigned workspace.",
        SerializedName = @"workspaceName",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceName { get;  }

    }
    /// The list of Log Analytics workspaces associated with the cluster.
    internal partial interface IAssociatedWorkspaceInternal

    {
        /// <summary>The time of workspace association.</summary>
        string AssociateDate { get; set; }
        /// <summary>The ResourceId id the assigned workspace.</summary>
        string ResourceId { get; set; }
        /// <summary>The id of the assigned workspace.</summary>
        string WorkspaceId { get; set; }
        /// <summary>The name id the assigned workspace.</summary>
        string WorkspaceName { get; set; }

    }
}