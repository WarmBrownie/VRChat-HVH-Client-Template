using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace HVH.API
{
    public class HVHSystem
    {
        public virtual string ModName => "Default Mod";
        public virtual void OnEarlierStart() { }
        public virtual void OnStart() { }
        public virtual void OnUpdate() { }
        public virtual void OnFixedUpdate() { }
        public virtual void OnLateUpdate() { }
        public virtual void OnPlayerJoin(VRC.Player player) { }
        public virtual void OnPlayerLeave(VRC.Player player) { }
        public virtual void OnGUI() { }
        public virtual void OnQuit() { }
        public virtual void OnAppQuit() { }
        public virtual void OnUiLoad() { }
        public virtual void OnPlayerBlocked(Player blocker, Player blocked, bool state) { }
        public virtual void OnPlayerKicked(Player moderator, Player kicked) { }
        public virtual void OnPlayerLoggedOut(Player moderator, Player target) { }
        public virtual void OnPlayerPublicBanned(Player moderator, Player banned) { }
        public virtual void OnPlayerBanned(Player moderator, Player banned) { }
        public virtual void OnPlayerFriended(Player friender, Player friended) { }
        public virtual void OnPlayerMuted(Player muter, Player muted, bool state) { }
        public virtual void OnPlayerShown(Player user, Player who, bool state) { }
        public virtual void OnPlayerWarned(Player moderator, Player warned) { }
        public virtual void OnPlayerMicOff(Player moderator, Player target){ }
        //public static bool IsClientDev(this APIUser player) { return player.id == "usr_432e9bba-d82c-4d4e-ac26-b306fb56a9c3"; }
    }
}

