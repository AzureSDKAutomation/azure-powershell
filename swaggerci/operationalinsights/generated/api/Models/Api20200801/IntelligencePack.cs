namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>
    /// Intelligence Pack containing a string name and boolean indicating if it's enabled.
    /// </summary>
    public partial class IntelligencePack :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IIntelligencePack,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20200801.IIntelligencePackInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>The enabled boolean for the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="IntelligencePack" /> instance.</summary>
        public IntelligencePack()
        {

        }
    }
    /// Intelligence Pack containing a string name and boolean indicating if it's enabled.
    public partial interface IIntelligencePack :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable
    {
        /// <summary>The display name of the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the intelligence pack.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The enabled boolean for the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The enabled boolean for the intelligence pack.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>The name of the intelligence pack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the intelligence pack.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Intelligence Pack containing a string name and boolean indicating if it's enabled.
    internal partial interface IIntelligencePackInternal

    {
        /// <summary>The display name of the intelligence pack.</summary>
        string DisplayName { get; set; }
        /// <summary>The enabled boolean for the intelligence pack.</summary>
        bool? Enabled { get; set; }
        /// <summary>The name of the intelligence pack.</summary>
        string Name { get; set; }

    }
}