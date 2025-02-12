namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt disk input for update.</summary>
    public partial class VMwareCbtUpdateDiskInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtUpdateDiskInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtUpdateDiskInputInternal
    {

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="TargetDiskName" /> property.</summary>
        private string _targetDiskName;

        /// <summary>The target disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetDiskName { get => this._targetDiskName; set => this._targetDiskName = value; }

        /// <summary>Creates an new <see cref="VMwareCbtUpdateDiskInput" /> instance.</summary>
        public VMwareCbtUpdateDiskInput()
        {

        }
    }
    /// VMwareCbt disk input for update.
    public partial interface IVMwareCbtUpdateDiskInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The target disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target disk name.",
        SerializedName = @"targetDiskName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDiskName { get; set; }

    }
    /// VMwareCbt disk input for update.
    internal partial interface IVMwareCbtUpdateDiskInputInternal

    {
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The target disk name.</summary>
        string TargetDiskName { get; set; }

    }
}