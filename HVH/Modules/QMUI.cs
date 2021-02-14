using UnityEngine;
using HVH.API;
using PlagueButtonAPI;

namespace HVH.Modules
{
    public class QMUI : HVHSystem
    {
        public override string ModName => "QuickMenu Utils";

        private bool isUIInit = false;

        // ▲▼
        public override void OnStart()
        {
            //Change QM collider size [for more buttons]
            GameObject.Find("UserInterface/QuickMenu").GetComponent<BoxCollider>().size = new Vector3(5034.68f, 3342.426f, 1f);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "HVH\nMod", "HVH menu",
                ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.ShortcutMenuTransform, delegate (bool a)
                {
                    ButtonAPI.EnterSubMenu(ButtonAPI.MakeEmptyPage("HVH"));
                }, Color.red, Color.magenta, null, true, false, false, false, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Player List", "Player list menu",
                ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("HVH").transform, delegate (bool a)
                {
                    ButtonAPI.EnterSubMenu(ButtonAPI.MakeEmptyPage("PlayerList"));
                }, Color.red, Color.magenta, null, false, true, false, false, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "User\nUtils", "User utils menu [HVH]",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.BelowBottomButton, ButtonAPI.UserInteractMenuTransform, delegate (bool a)
                {
                    ButtonAPI.EnterSubMenu(ButtonAPI.MakeEmptyPage("UserUtils"));
                }, Color.red, Color.magenta, null, true);

            isUIInit = true;
        }

        public override void OnUpdate()
        {
            if (isUIInit)
                ButtonAPI.SubMenuHandler();
        }
    }
}
