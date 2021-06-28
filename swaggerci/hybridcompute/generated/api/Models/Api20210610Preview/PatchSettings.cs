namespace Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Extensions;

    /// <summary>Specifies the patch settings.</summary>
    public partial class PatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettings,
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Models.Api20210610Preview.IPatchSettingsInternal
    {

        /// <summary>Backing field for <see cref="AssessmentMode" /> property.</summary>
        private string _assessmentMode;

        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Origin(Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.PropertyOrigin.Owned)]
        public string AssessmentMode { get => this._assessmentMode; set => this._assessmentMode = value; }

        /// <summary>Creates an new <see cref="PatchSettings" /> instance.</summary>
        public PatchSettings()
        {

        }
    }
    /// Specifies the patch settings.
    public partial interface IPatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the assessment mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HybridCompute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the assessment mode.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        string AssessmentMode { get; set; }

    }
    /// Specifies the patch settings.
    internal partial interface IPatchSettingsInternal

    {
        /// <summary>Specifies the assessment mode.</summary>
        string AssessmentMode { get; set; }

    }
}