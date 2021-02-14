using UnityEngine;
using HVH.API;
using PlagueButtonAPI;

namespace HVH.Modules

{
    public class Jump : HVHSystem
    {
        public override string ModName => "Jump";

        public override void OnStart()
        {
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Add Jump", "Add jump component to player",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("PureCheat").transform, delegate (bool a)
            {
                if (PureUtils.GetLocalPlayer().GetComponent<PlayerModComponentJump>())
                    return;
                else
                    PureUtils.GetLocalPlayer().AddComponent<PlayerModComponentJump>();

                PureUtils.GetLocalPlayer().GetComponent<PlayerModComponentJump>().field_Private_Single_0 = 3.0f;
                //PureUtils.GetLocalPlayer().GetComponent<PlayerModComponentJump>().field_Private_Single_1 = 3.0f;
            }, Color.white, Color.white, null);
        }
    }
}
