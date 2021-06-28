namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Custom Parameters used for Cluster Creation.</summary>
    public partial class WorkspaceCustomParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal
    {

        /// <summary>Backing field for <see cref="AmlWorkspaceId" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _amlWorkspaceId;

        /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter AmlWorkspaceId { get => (this._amlWorkspaceId = this._amlWorkspaceId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._amlWorkspaceId = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? AmlWorkspaceIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)AmlWorkspaceId).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string AmlWorkspaceIdValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)AmlWorkspaceId).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)AmlWorkspaceId).Value = value ?? null; }

        /// <summary>Backing field for <see cref="CustomPrivateSubnetName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _customPrivateSubnetName;

        /// <summary>The name of the Private Subnet within the Virtual Network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomPrivateSubnetName { get => (this._customPrivateSubnetName = this._customPrivateSubnetName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._customPrivateSubnetName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPrivateSubnetNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPrivateSubnetName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CustomPrivateSubnetNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPrivateSubnetName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPrivateSubnetName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="CustomPublicSubnetName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _customPublicSubnetName;

        /// <summary>The name of a Public Subnet within the Virtual Network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomPublicSubnetName { get => (this._customPublicSubnetName = this._customPublicSubnetName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._customPublicSubnetName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPublicSubnetNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPublicSubnetName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CustomPublicSubnetNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPublicSubnetName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPublicSubnetName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="CustomVirtualNetworkId" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _customVirtualNetworkId;

        /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomVirtualNetworkId { get => (this._customVirtualNetworkId = this._customVirtualNetworkId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._customVirtualNetworkId = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomVirtualNetworkIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomVirtualNetworkId).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string CustomVirtualNetworkIdValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomVirtualNetworkId).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomVirtualNetworkId).Value = value ?? null; }

        /// <summary>Backing field for <see cref="EnableNoPublicIP" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter _enableNoPublicIP;

        /// <summary>Should the Public IP be Disabled?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter EnableNoPublicIP { get => (this._enableNoPublicIP = this._enableNoPublicIP ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set => this._enableNoPublicIP = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EnableNoPublicIPType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)EnableNoPublicIP).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public bool? EnableNoPublicIPValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)EnableNoPublicIP).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)EnableNoPublicIP).Value = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter _encryption;

        /// <summary>
        /// Contains the encryption details for Customer-Managed Key (CMK) enabled workspace.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter()); set => this._encryption = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).Type; }

        /// <summary>Backing field for <see cref="LoadBalancerBackendPoolName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _loadBalancerBackendPoolName;

        /// <summary>
        /// Name of the outbound Load Balancer Backend Pool for Secure Cluster Connectivity (No Public IP).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter LoadBalancerBackendPoolName { get => (this._loadBalancerBackendPoolName = this._loadBalancerBackendPoolName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._loadBalancerBackendPoolName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerBackendPoolNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerBackendPoolName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string LoadBalancerBackendPoolNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerBackendPoolName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerBackendPoolName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="LoadBalancerId" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _loadBalancerId;

        /// <summary>
        /// Resource URI of Outbound Load balancer for Secure Cluster Connectivity (No Public IP) workspace.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter LoadBalancerId { get => (this._loadBalancerId = this._loadBalancerId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._loadBalancerId = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerId).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string LoadBalancerIdValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerId).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerId).Value = value ?? null; }

        /// <summary>Internal Acessors for AmlWorkspaceId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.AmlWorkspaceId { get => (this._amlWorkspaceId = this._amlWorkspaceId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_amlWorkspaceId = value;} } }

        /// <summary>Internal Acessors for AmlWorkspaceIdType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.AmlWorkspaceIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)AmlWorkspaceId).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)AmlWorkspaceId).Type = value; }

        /// <summary>Internal Acessors for CustomPrivateSubnetName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomPrivateSubnetName { get => (this._customPrivateSubnetName = this._customPrivateSubnetName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_customPrivateSubnetName = value;} } }

        /// <summary>Internal Acessors for CustomPrivateSubnetNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomPrivateSubnetNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPrivateSubnetName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPrivateSubnetName).Type = value; }

        /// <summary>Internal Acessors for CustomPublicSubnetName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomPublicSubnetName { get => (this._customPublicSubnetName = this._customPublicSubnetName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_customPublicSubnetName = value;} } }

        /// <summary>Internal Acessors for CustomPublicSubnetNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomPublicSubnetNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPublicSubnetName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomPublicSubnetName).Type = value; }

        /// <summary>Internal Acessors for CustomVirtualNetworkId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomVirtualNetworkId { get => (this._customVirtualNetworkId = this._customVirtualNetworkId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_customVirtualNetworkId = value;} } }

        /// <summary>Internal Acessors for CustomVirtualNetworkIdType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.CustomVirtualNetworkIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomVirtualNetworkId).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)CustomVirtualNetworkId).Type = value; }

        /// <summary>Internal Acessors for EnableNoPublicIP</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.EnableNoPublicIP { get => (this._enableNoPublicIP = this._enableNoPublicIP ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set { {_enableNoPublicIP = value;} } }

        /// <summary>Internal Acessors for EnableNoPublicIPType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.EnableNoPublicIPType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)EnableNoPublicIP).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)EnableNoPublicIP).Type = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceEncryptionParameter()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.EncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).Type = value; }

        /// <summary>Internal Acessors for EncryptionValue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryption Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.EncryptionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).Value = value; }

        /// <summary>Internal Acessors for LoadBalancerBackendPoolName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.LoadBalancerBackendPoolName { get => (this._loadBalancerBackendPoolName = this._loadBalancerBackendPoolName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_loadBalancerBackendPoolName = value;} } }

        /// <summary>Internal Acessors for LoadBalancerBackendPoolNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.LoadBalancerBackendPoolNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerBackendPoolName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerBackendPoolName).Type = value; }

        /// <summary>Internal Acessors for LoadBalancerId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.LoadBalancerId { get => (this._loadBalancerId = this._loadBalancerId ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_loadBalancerId = value;} } }

        /// <summary>Internal Acessors for LoadBalancerIdType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.LoadBalancerIdType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerId).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)LoadBalancerId).Type = value; }

        /// <summary>Internal Acessors for NatGatewayName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.NatGatewayName { get => (this._natGatewayName = this._natGatewayName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_natGatewayName = value;} } }

        /// <summary>Internal Acessors for NatGatewayNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.NatGatewayNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)NatGatewayName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)NatGatewayName).Type = value; }

        /// <summary>Internal Acessors for PrepareEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.PrepareEncryption { get => (this._prepareEncryption = this._prepareEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set { {_prepareEncryption = value;} } }

        /// <summary>Internal Acessors for PrepareEncryptionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.PrepareEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)PrepareEncryption).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)PrepareEncryption).Type = value; }

        /// <summary>Internal Acessors for PublicIPName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.PublicIPName { get => (this._publicIPName = this._publicIPName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_publicIPName = value;} } }

        /// <summary>Internal Acessors for PublicIPNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.PublicIPNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)PublicIPName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)PublicIPName).Type = value; }

        /// <summary>Internal Acessors for RequireInfrastructureEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.RequireInfrastructureEncryption { get => (this._requireInfrastructureEncryption = this._requireInfrastructureEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set { {_requireInfrastructureEncryption = value;} } }

        /// <summary>Internal Acessors for RequireInfrastructureEncryptionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.RequireInfrastructureEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)RequireInfrastructureEncryption).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)RequireInfrastructureEncryption).Type = value; }

        /// <summary>Internal Acessors for ResourceTag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.ResourceTag { get => (this._resourceTag = this._resourceTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomObjectParameter()); set { {_resourceTag = value;} } }

        /// <summary>Internal Acessors for ResourceTagType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.ResourceTagType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameterInternal)ResourceTag).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameterInternal)ResourceTag).Type = value; }

        /// <summary>Internal Acessors for StorageAccountName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.StorageAccountName { get => (this._storageAccountName = this._storageAccountName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_storageAccountName = value;} } }

        /// <summary>Internal Acessors for StorageAccountNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.StorageAccountNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountName).Type = value; }

        /// <summary>Internal Acessors for StorageAccountSkuName</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.StorageAccountSkuName { get => (this._storageAccountSkuName = this._storageAccountSkuName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_storageAccountSkuName = value;} } }

        /// <summary>Internal Acessors for StorageAccountSkuNameType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.StorageAccountSkuNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountSkuName).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountSkuName).Type = value; }

        /// <summary>Internal Acessors for VnetAddressPrefix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.VnetAddressPrefix { get => (this._vnetAddressPrefix = this._vnetAddressPrefix ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set { {_vnetAddressPrefix = value;} } }

        /// <summary>Internal Acessors for VnetAddressPrefixType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomParametersInternal.VnetAddressPrefixType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)VnetAddressPrefix).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)VnetAddressPrefix).Type = value; }

        /// <summary>Backing field for <see cref="NatGatewayName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _natGatewayName;

        /// <summary>
        /// Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter NatGatewayName { get => (this._natGatewayName = this._natGatewayName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._natGatewayName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? NatGatewayNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)NatGatewayName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string NatGatewayNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)NatGatewayName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)NatGatewayName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="PrepareEncryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter _prepareEncryption;

        /// <summary>
        /// Prepare the workspace for encryption. Enables the Managed Identity for managed storage account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter PrepareEncryption { get => (this._prepareEncryption = this._prepareEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set => this._prepareEncryption = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PrepareEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)PrepareEncryption).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public bool? PrepareEncryptionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)PrepareEncryption).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)PrepareEncryption).Value = value ?? default(bool); }

        /// <summary>Backing field for <see cref="PublicIPName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _publicIPName;

        /// <summary>Name of the Public IP for No Public IP workspace with managed vNet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter PublicIPName { get => (this._publicIPName = this._publicIPName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._publicIPName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PublicIPNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)PublicIPName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PublicIPNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)PublicIPName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)PublicIPName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="RequireInfrastructureEncryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter _requireInfrastructureEncryption;

        /// <summary>
        /// A boolean indicating whether or not the DBFS root file system will be enabled with secondary layer of encryption with
        /// platform managed keys for data at rest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter RequireInfrastructureEncryption { get => (this._requireInfrastructureEncryption = this._requireInfrastructureEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomBooleanParameter()); set => this._requireInfrastructureEncryption = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? RequireInfrastructureEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)RequireInfrastructureEncryption).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public bool? RequireInfrastructureEncryptionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)RequireInfrastructureEncryption).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameterInternal)RequireInfrastructureEncryption).Value = value ?? default(bool); }

        /// <summary>Backing field for <see cref="ResourceTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameter _resourceTag;

        /// <summary>
        /// Tags applied to resources under Managed resource group. These can be updated by updating tags at workspace level.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameter ResourceTag { get => (this._resourceTag = this._resourceTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomObjectParameter()); }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? ResourceTagType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameterInternal)ResourceTag).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IAny ResourceTagValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameterInternal)ResourceTag).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameterInternal)ResourceTag).Value = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="StorageAccountName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _storageAccountName;

        /// <summary>Default DBFS storage account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter StorageAccountName { get => (this._storageAccountName = this._storageAccountName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._storageAccountName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountName).Value = value ?? null; }

        /// <summary>Backing field for <see cref="StorageAccountSkuName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _storageAccountSkuName;

        /// <summary>
        /// Storage account SKU name, ex: Standard_GRS, Standard_LRS. Refer https://aka.ms/storageskus for valid inputs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter StorageAccountSkuName { get => (this._storageAccountSkuName = this._storageAccountSkuName ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._storageAccountSkuName = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountSkuNameType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountSkuName).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string StorageAccountSkuNameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountSkuName).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)StorageAccountSkuName).Value = value ?? null; }

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ValueKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyName = value ?? null; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Default, Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource? ValueKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeySource = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource)""); }

        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ValueKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ValueKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameterInternal)Encryption).ValueKeyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="VnetAddressPrefix" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter _vnetAddressPrefix;

        /// <summary>
        /// Address prefix for Managed virtual network. Default value for this input is 10.139.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter VnetAddressPrefix { get => (this._vnetAddressPrefix = this._vnetAddressPrefix ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.WorkspaceCustomStringParameter()); set => this._vnetAddressPrefix = value; }

        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? VnetAddressPrefixType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)VnetAddressPrefix).Type; }

        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string VnetAddressPrefixValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)VnetAddressPrefix).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameterInternal)VnetAddressPrefix).Value = value ?? null; }

        /// <summary>Creates an new <see cref="WorkspaceCustomParameters" /> instance.</summary>
        public WorkspaceCustomParameters()
        {

        }
    }
    /// Custom Parameters used for Cluster Creation.
    public partial interface IWorkspaceCustomParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? AmlWorkspaceIdType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string AmlWorkspaceIdValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPrivateSubnetNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPrivateSubnetNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPublicSubnetNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPublicSubnetNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomVirtualNetworkIdType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string CustomVirtualNetworkIdValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EnableNoPublicIPType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableNoPublicIPValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EncryptionType { get;  }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerBackendPoolNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerBackendPoolNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerIdType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerIdValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? NatGatewayNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string NatGatewayNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PrepareEncryptionType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PrepareEncryptionValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PublicIPNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? RequireInfrastructureEncryptionType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequireInfrastructureEncryptionValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? ResourceTagType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IAny ResourceTagValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountNameValue { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountSkuNameType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountSkuNameValue { get; set; }
        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of KeyVault key.",
        SerializedName = @"KeyName",
        PossibleTypes = new [] { typeof(string) })]
        string ValueKeyName { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Default, Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The encryption keySource (provider). Possible values (case-insensitive):  Default, Microsoft.Keyvault",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource? ValueKeySource { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Uri of KeyVault.",
        SerializedName = @"keyvaulturi",
        PossibleTypes = new [] { typeof(string) })]
        string ValueKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of KeyVault key.",
        SerializedName = @"keyversion",
        PossibleTypes = new [] { typeof(string) })]
        string ValueKeyVersion { get; set; }
        /// <summary>The type of variable that this is</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of variable that this is",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? VnetAddressPrefixType { get;  }
        /// <summary>The value which should be used for this field.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value which should be used for this field.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string VnetAddressPrefixValue { get; set; }

    }
    /// Custom Parameters used for Cluster Creation.
    internal partial interface IWorkspaceCustomParametersInternal

    {
        /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter AmlWorkspaceId { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? AmlWorkspaceIdType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string AmlWorkspaceIdValue { get; set; }
        /// <summary>The name of the Private Subnet within the Virtual Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomPrivateSubnetName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPrivateSubnetNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string CustomPrivateSubnetNameValue { get; set; }
        /// <summary>The name of a Public Subnet within the Virtual Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomPublicSubnetName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomPublicSubnetNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string CustomPublicSubnetNameValue { get; set; }
        /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter CustomVirtualNetworkId { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? CustomVirtualNetworkIdType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string CustomVirtualNetworkIdValue { get; set; }
        /// <summary>Should the Public IP be Disabled?</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter EnableNoPublicIP { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EnableNoPublicIPType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        bool? EnableNoPublicIPValue { get; set; }
        /// <summary>
        /// Contains the encryption details for Customer-Managed Key (CMK) enabled workspace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceEncryptionParameter Encryption { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? EncryptionType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IEncryption EncryptionValue { get; set; }
        /// <summary>
        /// Name of the outbound Load Balancer Backend Pool for Secure Cluster Connectivity (No Public IP).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter LoadBalancerBackendPoolName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerBackendPoolNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string LoadBalancerBackendPoolNameValue { get; set; }
        /// <summary>
        /// Resource URI of Outbound Load balancer for Secure Cluster Connectivity (No Public IP) workspace.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter LoadBalancerId { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? LoadBalancerIdType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string LoadBalancerIdValue { get; set; }
        /// <summary>
        /// Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter NatGatewayName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? NatGatewayNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string NatGatewayNameValue { get; set; }
        /// <summary>
        /// Prepare the workspace for encryption. Enables the Managed Identity for managed storage account.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter PrepareEncryption { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PrepareEncryptionType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        bool? PrepareEncryptionValue { get; set; }
        /// <summary>Name of the Public IP for No Public IP workspace with managed vNet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter PublicIPName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? PublicIPNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string PublicIPNameValue { get; set; }
        /// <summary>
        /// A boolean indicating whether or not the DBFS root file system will be enabled with secondary layer of encryption with
        /// platform managed keys for data at rest.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomBooleanParameter RequireInfrastructureEncryption { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? RequireInfrastructureEncryptionType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        bool? RequireInfrastructureEncryptionValue { get; set; }
        /// <summary>
        /// Tags applied to resources under Managed resource group. These can be updated by updating tags at workspace level.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomObjectParameter ResourceTag { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? ResourceTagType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.IAny ResourceTagValue { get; set; }
        /// <summary>Default DBFS storage account name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter StorageAccountName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string StorageAccountNameValue { get; set; }
        /// <summary>
        /// Storage account SKU name, ex: Standard_GRS, Standard_LRS. Refer https://aka.ms/storageskus for valid inputs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter StorageAccountSkuName { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? StorageAccountSkuNameType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string StorageAccountSkuNameValue { get; set; }
        /// <summary>The name of KeyVault key.</summary>
        string ValueKeyName { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Default, Microsoft.Keyvault
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.KeySource? ValueKeySource { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        string ValueKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        string ValueKeyVersion { get; set; }
        /// <summary>
        /// Address prefix for Managed virtual network. Default value for this input is 10.139.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20210401Preview.IWorkspaceCustomStringParameter VnetAddressPrefix { get; set; }
        /// <summary>The type of variable that this is</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.CustomParameterType? VnetAddressPrefixType { get; set; }
        /// <summary>The value which should be used for this field.</summary>
        string VnetAddressPrefixValue { get; set; }

    }
}