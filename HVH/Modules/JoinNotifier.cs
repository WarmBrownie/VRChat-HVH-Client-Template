using VRC;
using HVH.API;

namespace HVH.Modules
{
    public class JoinNotifier : HVHSystem
    {
        public override string ModName => "Join notifier";

        public override void OnPlayerJoin(Player player)
        {
            string playerName = player.gameObject.GetComponent<VRCPlayer>().ToString();
            HVHLogger.Log($"{playerName} joined room!");
        }

        public override void OnPlayerLeave(Player player)
        {
            string playerName = player.gameObject.GetComponent<VRCPlayer>().ToString();
            HVHLogger.Log($"{playerName} leaved room!");
        }
    }
}
