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
       // #region Initialization
       // StoredData storedData;
       
	void OnPlayerDie(BasePlayer player, HitInfo info)
	{
    		Puts("OnPlayerDie works!");
		Player = "Anon";
		
	/*	class PlayerInfo
        	{
           		public string UserId;
            		public string Name;

            		public PlayerInfo()
            		{
            		}

            		public PlayerInfo(BasePlayer player)
            		{
               			UserId = player.userID.ToString();
               			Name = player.displayName;
           		}
		
		
		
	}
	*/
        // <summary>
        // New Killer Name
        // </summary>
	
        string hiddenKillerName = "Hidden";

        /// Permission
        string perm = "";
        #endregion

	}
}
