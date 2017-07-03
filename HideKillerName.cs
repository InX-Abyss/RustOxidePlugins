using Oxide.Core;
using Oxide.Game.Rust;
using System;
using System.Collections.Generic;

namespace Oxide.Plugins
{
    [Info("HideKillerName", "AtroposOrbis", "1.0.0", ResourceId = 0000)]
    [Description("Hides name of killers")]

	public class HideKillerName : RustPlugin
    {
        #region Initialization
        StoredData storedData;

        /// <summary>
        /// New Killer Name
        /// </summary>
        string hiddenKillerName = "Hidden";

        /// Permission
        string perm = "";
        #endregion

	}
}
