namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Server version capabilities.</summary>
    public partial class ServerVersionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapability,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapabilityInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapabilityInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapabilityInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for SupportedVcore</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability[] Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerVersionCapabilityInternal.SupportedVcore { get => this._supportedVcore; set { {_supportedVcore = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>server version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="SupportedVcore" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability[] _supportedVcore;

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability[] SupportedVcore { get => this._supportedVcore; }

        /// <summary>Creates an new <see cref="ServerVersionCapability" /> instance.</summary>
        public ServerVersionCapability()
        {

        }
    }
    /// Server version capabilities.
    public partial interface IServerVersionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>server version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"server version",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"supportedVcores",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability[] SupportedVcore { get;  }

    }
    /// Server version capabilities.
    internal partial interface IServerVersionCapabilityInternal

    {
        /// <summary>server version</summary>
        string Name { get; set; }
        /// <summary>The status</summary>
        string Status { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IVcoreCapability[] SupportedVcore { get; set; }

    }
}