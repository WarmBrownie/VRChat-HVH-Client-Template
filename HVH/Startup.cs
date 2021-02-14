using MelonLoader;
using HVH.API;
using System.Collections.Generic;
using System.IO;

namespace HVH
{
    public class Core : MelonMod
    {
        public static List<HVHSystem> Mods = new List<HVHSystem>();

        public override void OnApplicationStart()
        {
            HVHLogger.Init();

                Mods.Add(new Modules.QMUI());
          
                Mods.Add(new Modules.FuckPlus());

                Mods.Add(new Modules.HWID());

               

            foreach (HVHSystem mod in Mods)
            {
                HVHLogger.Log($"{mod.ModName} loaded!");
                mod.OnEarlierStart();
            }

            NetworkManagerHooks.OnJoin += NetworkManagerHooks_OnJoin;
            NetworkManagerHooks.OnLeave += NetworkManagerHooks_OnLeave;
        }

        private void NetworkManagerHooks_OnJoin(VRC.Player player)
        {
            foreach (HVHSystem mod in Mods)
                mod.OnPlayerJoin(player);
        }

        private void NetworkManagerHooks_OnLeave(VRC.Player player)
        {
            foreach (HVHSystem mod in Mods)
                mod.OnPlayerLeave(player);
        }

        public override void VRChat_OnUiManagerInit()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnStart();
        }

        public override void OnUpdate()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnUpdate();
        }

        public override void OnLateUpdate()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnLateUpdate();
        }

        public override void OnFixedUpdate()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnFixedUpdate();
        }

        public override void OnGUI()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnGUI();
        }

        public override void OnApplicationQuit()
        {
            foreach (HVHSystem mod in Mods)
                mod.OnQuit();
        }

      
        }
    }
}
