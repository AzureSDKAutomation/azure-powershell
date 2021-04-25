namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Specifies the operating system settings for the hybrid machine.</summary>
    public partial class OSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IOSProfileInternal
    {

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; }

        /// <summary>Internal Acessors for ComputerName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210325Preview.IOSProfileInternal.ComputerName { get => this._computerName; set { {_computerName = value;} } }

        /// <summary>Creates an new <see cref="OSProfile" /> instance.</summary>
        public OSProfile()
        {

        }
    }
    /// Specifies the operating system settings for the hybrid machine.
    public partial interface IOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifies the host OS name of the hybrid machine.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get;  }

    }
    /// Specifies the operating system settings for the hybrid machine.
    internal partial interface IOSProfileInternal

    {
        /// <summary>Specifies the host OS name of the hybrid machine.</summary>
        string ComputerName { get; set; }

    }
}