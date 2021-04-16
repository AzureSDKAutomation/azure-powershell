namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Extensions;

    /// <summary>The resource model definition for a ARM tracked top level resource.</summary>
    public partial class TrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.Resource();

        /// <summary>Fully qualified resource Id for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The GEO location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags _tag;

        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.TrackedResourceTags()); set => this._tag = value; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="TrackedResource" /> instance.</summary>
        public TrackedResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The resource model definition for a ARM tracked top level resource.
    public partial interface ITrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResource
    {
        /// <summary>The GEO location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GEO location of the resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tags of the service which is a list of key value pairs that describe the resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags Tag { get; set; }

    }
    /// The resource model definition for a ARM tracked top level resource.
    internal partial interface ITrackedResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.IResourceInternal
    {
        /// <summary>The GEO location of the resource.</summary>
        string Location { get; set; }
        /// <summary>
        /// Tags of the service which is a list of key value pairs that describe the resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Models.Api202103Preview.ITrackedResourceTags Tag { get; set; }

    }
}