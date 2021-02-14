using VRC;
using UnityEngine;
using HVH.API;
using PlagueButtonAPI;

namespace HVH.Modules
{
    public class ForceAllowClone : HVHSystem
    {
        public override string ModName => "Force clone avatar";

        public override void OnStart()
        {
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Allow Clone", "Allow to clone all avatars",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, ButtonAPI.MakeEmptyPage("PureCheat").transform, delegate (bool a)
                {
                    foreach (Player player in Wrapper.GetPlayer())
                        player.prop_APIUser_0.allowAvatarCopying = true;
                }, Color.white, Color.white, null, false, false);
        }
    }
}
