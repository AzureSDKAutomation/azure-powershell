namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Deployment settings payload</summary>
    public partial class DeploymentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettings,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal
    {

        /// <summary>Backing field for <see cref="AddonConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig _addonConfig;

        /// <summary>Collection of addons</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig AddonConfig { get => (this._addonConfig = this._addonConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsAddonConfig()); set => this._addonConfig = value; }

        /// <summary>Backing field for <see cref="Cpu" /> property.</summary>
        private int? _cpu;

        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2021-06-01-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? Cpu { get => this._cpu; set => this._cpu = value; }

        /// <summary>Backing field for <see cref="EnvironmentVariable" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables _environmentVariable;

        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get => (this._environmentVariable = this._environmentVariable ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.DeploymentSettingsEnvironmentVariables()); set => this._environmentVariable = value; }

        /// <summary>Backing field for <see cref="MemoryInGb" /> property.</summary>
        private int? _memoryInGb;

        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public int? MemoryInGb { get => this._memoryInGb; set => this._memoryInGb = value; }

        /// <summary>Internal Acessors for ResourceRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsInternal.ResourceRequest { get => (this._resourceRequest = this._resourceRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceRequests()); set { {_resourceRequest = value;} } }

        /// <summary>Backing field for <see cref="ResourceRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests _resourceRequest;

        /// <summary>
        /// The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the
        /// required CPU and Memory, the old field cpu and memoryInGB will be deprecated later.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests ResourceRequest { get => (this._resourceRequest = this._resourceRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.ResourceRequests()); set => this._resourceRequest = value; }

        /// <summary>
        /// Required CPU. 1 core can be represented by 1 or 1000m. This should be 500m or 1 for Basic tier, and {500m, 1, 2, 3, 4}
        /// for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ResourceRequestCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequestsInternal)ResourceRequest).Cpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequestsInternal)ResourceRequest).Cpu = value ?? null; }

        /// <summary>
        /// Required memory. 1 GB can be represented by 1Gi or 1024Mi. This should be {512Mi, 1Gi, 2Gi} for Basic tier, and {512Mi,
        /// 1Gi, 2Gi, ..., 8Gi} for Standard tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inlined)]
        public string ResourceRequestMemory { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequestsInternal)ResourceRequest).Memory; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequestsInternal)ResourceRequest).Memory = value ?? null; }

        /// <summary>Creates an new <see cref="DeploymentSettings" /> instance.</summary>
        public DeploymentSettings()
        {

        }
    }
    /// Deployment settings payload
    public partial interface IDeploymentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Collection of addons</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of addons",
        SerializedName = @"addonConfig",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig AddonConfig { get; set; }
        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2021-06-01-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the CPU size.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? Cpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of environment variables",
        SerializedName = @"environmentVariables",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get; set; }
        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the the memory size.",
        SerializedName = @"memoryInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? MemoryInGb { get; set; }
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

    }
    /// Deployment settings payload
    internal partial interface IDeploymentSettingsInternal

    {
        /// <summary>Collection of addons</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsAddonConfig AddonConfig { get; set; }
        /// <summary>
        /// Required CPU. This should be 1 for Basic tier, and in range [1, 4] for Standard tier. This is deprecated starting from
        /// API version 2021-06-01-preview. Please use the resourceRequests field to set the CPU size.
        /// </summary>
        int? Cpu { get; set; }
        /// <summary>Collection of environment variables</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IDeploymentSettingsEnvironmentVariables EnvironmentVariable { get; set; }
        /// <summary>
        /// Required Memory size in GB. This should be in range [1, 2] for Basic tier, and in range [1, 8] for Standard tier. This
        /// is deprecated starting from API version 2021-06-01-preview. Please use the resourceRequests field to set the the memory
        /// size.
        /// </summary>
        int? MemoryInGb { get; set; }
        /// <summary>
        /// The requested resource quantity for required CPU and Memory. It is recommended that using this field to represent the
        /// required CPU and Memory, the old field cpu and memoryInGB will be deprecated later.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api20210601Preview.IResourceRequests ResourceRequest { get; set; }
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

    }
}