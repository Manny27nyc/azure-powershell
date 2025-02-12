namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Agent details.</summary>
    public partial class AgentDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal
    {

        /// <summary>Backing field for <see cref="AgentId" /> property.</summary>
        private string _agentId;

        /// <summary>The Id of the agent running on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AgentId { get => this._agentId; }

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The machine BIOS Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; }

        /// <summary>Backing field for <see cref="Disk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails[] _disk;

        /// <summary>The disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails[] Disk { get => this._disk; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>The machine FQDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="MachineId" /> property.</summary>
        private string _machineId;

        /// <summary>The Id of the machine to which the agent is registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MachineId { get => this._machineId; }

        /// <summary>Internal Acessors for AgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal.AgentId { get => this._agentId; set { {_agentId = value;} } }

        /// <summary>Internal Acessors for BiosId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal.BiosId { get => this._biosId; set { {_biosId = value;} } }

        /// <summary>Internal Acessors for Disk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal.Disk { get => this._disk; set { {_disk = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for MachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDetailsInternal.MachineId { get => this._machineId; set { {_machineId = value;} } }

        /// <summary>Creates an new <see cref="AgentDetails" /> instance.</summary>
        public AgentDetails()
        {

        }
    }
    /// Agent details.
    public partial interface IAgentDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The Id of the agent running on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Id of the agent running on the server.",
        SerializedName = @"agentId",
        PossibleTypes = new [] { typeof(string) })]
        string AgentId { get;  }
        /// <summary>The machine BIOS Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The machine BIOS Id.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get;  }
        /// <summary>The disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disks.",
        SerializedName = @"disks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails[] Disk { get;  }
        /// <summary>The machine FQDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The machine FQDN.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>The Id of the machine to which the agent is registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Id of the machine to which the agent is registered.",
        SerializedName = @"machineId",
        PossibleTypes = new [] { typeof(string) })]
        string MachineId { get;  }

    }
    /// Agent details.
    internal partial interface IAgentDetailsInternal

    {
        /// <summary>The Id of the agent running on the server.</summary>
        string AgentId { get; set; }
        /// <summary>The machine BIOS Id.</summary>
        string BiosId { get; set; }
        /// <summary>The disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAgentDiskDetails[] Disk { get; set; }
        /// <summary>The machine FQDN.</summary>
        string Fqdn { get; set; }
        /// <summary>The Id of the machine to which the agent is registered.</summary>
        string MachineId { get; set; }

    }
}