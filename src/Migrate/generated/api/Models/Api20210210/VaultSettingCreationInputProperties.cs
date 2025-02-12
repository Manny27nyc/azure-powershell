namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input to create vault setting.</summary>
    public partial class VaultSettingCreationInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="MigrationSolutionId" /> property.</summary>
        private string _migrationSolutionId;

        /// <summary>The migration solution Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MigrationSolutionId { get => this._migrationSolutionId; set => this._migrationSolutionId = value; }

        /// <summary>Creates an new <see cref="VaultSettingCreationInputProperties" /> instance.</summary>
        public VaultSettingCreationInputProperties()
        {

        }
    }
    /// Input to create vault setting.
    public partial interface IVaultSettingCreationInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The migration solution Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The migration solution Id.",
        SerializedName = @"migrationSolutionId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationSolutionId { get; set; }

    }
    /// Input to create vault setting.
    internal partial interface IVaultSettingCreationInputPropertiesInternal

    {
        /// <summary>The migration solution Id.</summary>
        string MigrationSolutionId { get; set; }

    }
}