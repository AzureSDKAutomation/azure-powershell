namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>All key-value properties.</summary>
    public partial class KeyValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValueProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>An ETag indicating the state of a key-value within a configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Key { get => this._key; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Label { get => this._label; }

        /// <summary>Backing field for <see cref="LastModified" /> property.</summary>
        private global::System.DateTime? _lastModified;

        /// <summary>The last time a modifying operation was performed on the given key-value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModified { get => this._lastModified; }

        /// <summary>Backing field for <see cref="Locked" /> property.</summary>
        private bool? _locked;

        /// <summary>
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public bool? Locked { get => this._locked; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for Key</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal.Key { get => this._key; set { {_key = value;} } }

        /// <summary>Internal Acessors for Label</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal.Label { get => this._label; set { {_label = value;} } }

        /// <summary>Internal Acessors for LastModified</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal.LastModified { get => this._lastModified; set { {_lastModified = value;} } }

        /// <summary>Internal Acessors for Locked</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesInternal.Locked { get => this._locked; set { {_locked = value;} } }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesTags _tag;

        /// <summary>
        /// A dictionary of tags that can help identify what a key-value may be applicable for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.KeyValuePropertiesTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the key-value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="KeyValueProperties" /> instance.</summary>
        public KeyValueProperties()
        {

        }
    }
    /// All key-value properties.
    public partial interface IKeyValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content type of the key-value's value.
        Providing a proper content-type can enable transformations of values when they are retrieved by applications.",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }
        /// <summary>An ETag indicating the state of a key-value within a configuration store.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An ETag indicating the state of a key-value within a configuration store.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get;  }
        /// <summary>
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The primary identifier of a key-value.
        The key is used in unison with the label to uniquely identify a key-value.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get;  }
        /// <summary>
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value used to group key-values.
        The label is used in unison with the key to uniquely identify a key-value.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get;  }
        /// <summary>The last time a modifying operation was performed on the given key-value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last time a modifying operation was performed on the given key-value.",
        SerializedName = @"lastModified",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModified { get;  }
        /// <summary>
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the key-value is locked.
        A locked key-value may not be modified until it is unlocked.",
        SerializedName = @"locked",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Locked { get;  }
        /// <summary>
        /// A dictionary of tags that can help identify what a key-value may be applicable for.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A dictionary of tags that can help identify what a key-value may be applicable for.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesTags Tag { get; set; }
        /// <summary>The value of the key-value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the key-value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// All key-value properties.
    internal partial interface IKeyValuePropertiesInternal

    {
        /// <summary>
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </summary>
        string ContentType { get; set; }
        /// <summary>An ETag indicating the state of a key-value within a configuration store.</summary>
        string ETag { get; set; }
        /// <summary>
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </summary>
        string Key { get; set; }
        /// <summary>
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </summary>
        string Label { get; set; }
        /// <summary>The last time a modifying operation was performed on the given key-value.</summary>
        global::System.DateTime? LastModified { get; set; }
        /// <summary>
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        bool? Locked { get; set; }
        /// <summary>
        /// A dictionary of tags that can help identify what a key-value may be applicable for.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20210301Preview.IKeyValuePropertiesTags Tag { get; set; }
        /// <summary>The value of the key-value.</summary>
        string Value { get; set; }

    }
}