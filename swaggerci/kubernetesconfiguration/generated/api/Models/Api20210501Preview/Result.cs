namespace Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Extensions;

    /// <summary>Sample result definition</summary>
    public partial class Result :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IResult,
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Models.Api20210501Preview.IResultInternal
    {

        /// <summary>Backing field for <see cref="SampleProperty" /> property.</summary>
        private string _sampleProperty;

        /// <summary>Sample property of type string</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.PropertyOrigin.Owned)]
        public string SampleProperty { get => this._sampleProperty; set => this._sampleProperty = value; }

        /// <summary>Creates an new <see cref="Result" /> instance.</summary>
        public Result()
        {

        }
    }
    /// Sample result definition
    public partial interface IResult :
        Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Sample property of type string</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SourceControlConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sample property of type string",
        SerializedName = @"sampleProperty",
        PossibleTypes = new [] { typeof(string) })]
        string SampleProperty { get; set; }

    }
    /// Sample result definition
    internal partial interface IResultInternal

    {
        /// <summary>Sample property of type string</summary>
        string SampleProperty { get; set; }

    }
}