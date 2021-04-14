namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Deployment resource properties payload</summary>
    public partial class DeploymentResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private bool? _active;

        /// <summary>Indicates whether the Deployment is active</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public bool? Active { get => this._active; }

        /// <summary>Backing field for <see cref="AppName" /> property.</summary>
        private string _appName;

        /// <summary>App name of the deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string AppName { get => this._appName; }

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private global::System.DateTime? _createdTime;

        /// <summary>Date time when the resource is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedTime { get => this._createdTime; }

        /// <summary>Backing field for <see cref="DeploymentSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings _deploymentSetting;

        /// <summary>Deployment settings of the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings DeploymentSetting { get => (this._deploymentSetting = this._deploymentSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettings()); set => this._deploymentSetting = value; }

        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2020-03-03-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? DeploymentSettingCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).Cpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).Cpu = value ?? default(int); }

        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables DeploymentSettingEnvironmentVariable { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).EnvironmentVariable; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).EnvironmentVariable = value ?? null /* model class */; }

        /// <summary>JVM parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string DeploymentSettingJvmOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).JvmOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).JvmOption = value ?? null; }

        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2020-03-03-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public int? DeploymentSettingMemoryInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).MemoryInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).MemoryInGb = value ?? default(int); }

        /// <summary>The path to the .NET executable relative to zip root</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string DeploymentSettingNetCoreMainEntryPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).NetCoreMainEntryPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).NetCoreMainEntryPath = value ?? null; }

        /// <summary>Runtime version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? DeploymentSettingRuntimeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).RuntimeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).RuntimeVersion = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion)""); }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[] _instance;

        /// <summary>Collection of instances belong to the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[] Instance { get => this._instance; }

        /// <summary>Internal Acessors for Active</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.Active { get => this._active; set { {_active = value;} } }

        /// <summary>Internal Acessors for AppName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.AppName { get => this._appName; set { {_appName = value;} } }

        /// <summary>Internal Acessors for CreatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.CreatedTime { get => this._createdTime; set { {_createdTime = value;} } }

        /// <summary>Internal Acessors for DeploymentSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.DeploymentSetting { get => (this._deploymentSetting = this._deploymentSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.DeploymentSettings()); set { {_deploymentSetting = value;} } }

        /// <summary>Internal Acessors for DeploymentSettingResourceRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceRequests Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.DeploymentSettingResourceRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequest = value; }

        /// <summary>Internal Acessors for Instance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[] Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.Instance { get => this._instance; set { {_instance = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Source</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.Source { get => (this._source = this._source ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.UserSourceInfo()); set { {_source = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus? Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentResourcePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4}
        /// for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ResourceRequestCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequestCpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequestCpu = value ?? null; }

        /// <summary>
        /// Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi,
        /// 1Gi, 2Gi, ..., 8Gi} for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ResourceRequestMemory { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequestMemory; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsInternal)DeploymentSetting).ResourceRequestMemory = value ?? null; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo _source;

        /// <summary>Uploaded source information of the deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo Source { get => (this._source = this._source ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.UserSourceInfo()); set => this._source = value; }

        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string SourceArtifactSelector { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).ArtifactSelector; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).ArtifactSelector = value ?? null; }

        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string SourceRelativePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).RelativePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).RelativePath = value ?? null; }

        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? SourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType)""); }

        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string SourceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfoInternal)Source).Version = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus? _status;

        /// <summary>Status of the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="DeploymentResourceProperties" /> instance.</summary>
        public DeploymentResourceProperties()
        {

        }
    }
    /// Deployment resource properties payload
    public partial interface IDeploymentResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether the Deployment is active</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates whether the Deployment is active",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Active { get;  }
        /// <summary>App name of the deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"App name of the deployment",
        SerializedName = @"appName",
        PossibleTypes = new [] { typeof(string) })]
        string AppName { get;  }
        /// <summary>Date time when the resource is created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Date time when the resource is created",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedTime { get;  }
        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2020-03-03-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from API version 2020-03-03-preview. Please use the resourceRequests field to set the CPU size.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? DeploymentSettingCpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of environment variables",
        SerializedName = @"environmentVariables",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables DeploymentSettingEnvironmentVariable { get; set; }
        /// <summary>JVM parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"JVM parameter",
        SerializedName = @"jvmOptions",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentSettingJvmOption { get; set; }
        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2020-03-03-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This is deprecated starting from API version 2020-03-03-preview. Please use the resourceRequests field to set the the memory size.",
        SerializedName = @"memoryInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? DeploymentSettingMemoryInGb { get; set; }
        /// <summary>The path to the .NET executable relative to zip root</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the .NET executable relative to zip root",
        SerializedName = @"netCoreMainEntryPath",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentSettingNetCoreMainEntryPath { get; set; }
        /// <summary>Runtime version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Runtime version",
        SerializedName = @"runtimeVersion",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? DeploymentSettingRuntimeVersion { get; set; }
        /// <summary>Collection of instances belong to the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Collection of instances belong to the Deployment",
        SerializedName = @"instances",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[] Instance { get;  }
        /// <summary>Provisioning state of the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Deployment",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4}
        /// for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4} for Standard tier.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceRequestCpu { get; set; }
        /// <summary>
        /// Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi,
        /// 1Gi, 2Gi, ..., 8Gi} for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi, 1Gi, 2Gi, ..., 8Gi} for Standard tier.",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceRequestMemory { get; set; }
        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selector for the artifact to be used for the deployment for multi-module projects. This should be
        the relative path to the target module/project.",
        SerializedName = @"artifactSelector",
        PossibleTypes = new [] { typeof(string) })]
        string SourceArtifactSelector { get; set; }
        /// <summary>Relative path of the storage which stores the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Relative path of the storage which stores the source",
        SerializedName = @"relativePath",
        PossibleTypes = new [] { typeof(string) })]
        string SourceRelativePath { get; set; }
        /// <summary>Type of the source uploaded</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the source uploaded",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? SourceType { get; set; }
        /// <summary>Version of the source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the source",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVersion { get; set; }
        /// <summary>Status of the Deployment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of the Deployment",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus? Status { get;  }

    }
    /// Deployment resource properties payload
    internal partial interface IDeploymentResourcePropertiesInternal

    {
        /// <summary>Indicates whether the Deployment is active</summary>
        bool? Active { get; set; }
        /// <summary>App name of the deployment</summary>
        string AppName { get; set; }
        /// <summary>Date time when the resource is created</summary>
        global::System.DateTime? CreatedTime { get; set; }
        /// <summary>Deployment settings of the Deployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettings DeploymentSetting { get; set; }
        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2020-03-03-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        int? DeploymentSettingCpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentSettingsEnvironmentVariables DeploymentSettingEnvironmentVariable { get; set; }
        /// <summary>JVM parameter</summary>
        string DeploymentSettingJvmOption { get; set; }
        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2020-03-03-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        int? DeploymentSettingMemoryInGb { get; set; }
        /// <summary>The path to the .NET executable relative to zip root</summary>
        string DeploymentSettingNetCoreMainEntryPath { get; set; }
        /// <summary>
        /// The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the
        /// required CPU and Memory, the old field cpu and memoryInGB will be deprecated later.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceRequests DeploymentSettingResourceRequest { get; set; }
        /// <summary>Runtime version</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.RuntimeVersion? DeploymentSettingRuntimeVersion { get; set; }
        /// <summary>Collection of instances belong to the Deployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IDeploymentInstance[] Instance { get; set; }
        /// <summary>Provisioning state of the Deployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4}
        /// for Standard tier.
        /// </summary>
        string ResourceRequestCpu { get; set; }
        /// <summary>
        /// Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi,
        /// 1Gi, 2Gi, ..., 8Gi} for Standard tier.
        /// </summary>
        string ResourceRequestMemory { get; set; }
        /// <summary>Uploaded source information of the deployment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IUserSourceInfo Source { get; set; }
        /// <summary>
        /// Selector for the artifact to be used for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        string SourceArtifactSelector { get; set; }
        /// <summary>Relative path of the storage which stores the source</summary>
        string SourceRelativePath { get; set; }
        /// <summary>Type of the source uploaded</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.UserSourceType? SourceType { get; set; }
        /// <summary>Version of the source</summary>
        string SourceVersion { get; set; }
        /// <summary>Status of the Deployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.DeploymentResourceStatus? Status { get; set; }

    }
}