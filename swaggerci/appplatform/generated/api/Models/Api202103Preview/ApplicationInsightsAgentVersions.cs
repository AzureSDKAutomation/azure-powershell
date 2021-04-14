namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>Application Insights agent versions properties payload</summary>
    public partial class ApplicationInsightsAgentVersions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IApplicationInsightsAgentVersions,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IApplicationInsightsAgentVersionsInternal
    {

        /// <summary>Backing field for <see cref="Java" /> property.</summary>
        private string _java;

        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Java { get => this._java; }

        /// <summary>Internal Acessors for Java</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IApplicationInsightsAgentVersionsInternal.Java { get => this._java; set { {_java = value;} } }

        /// <summary>Creates an new <see cref="ApplicationInsightsAgentVersions" /> instance.</summary>
        public ApplicationInsightsAgentVersions()
        {

        }
    }
    /// Application Insights agent versions properties payload
    public partial interface IApplicationInsightsAgentVersions :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the version of application insight java agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the version of application insight java agent",
        SerializedName = @"java",
        PossibleTypes = new [] { typeof(string) })]
        string Java { get;  }

    }
    /// Application Insights agent versions properties payload
    internal partial interface IApplicationInsightsAgentVersionsInternal

    {
        /// <summary>Indicates the version of application insight java agent</summary>
        string Java { get; set; }

    }
}