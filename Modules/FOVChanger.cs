﻿using System;
using UnityEngine;
using HVH.API;
using PlagueButtonAPI;
using UnityEngine.UI;
using VRC.Core;

namespace HVH.Modules
{
    public class FOVChanger : HVHSystem
    {
        public override string ModName => "Field of view changer";

        private float defaultFOV;
        public float FOV = 66;

        private Camera playerCamera;

        public static GameObject resetFOVButton = null;

        public override void OnStart()
        {
            playerCamera = Wrapper.GetLocalPlayerCamera().GetComponent<Camera>();

            defaultFOV = playerCamera.fieldOfView;
            playerCamera.fieldOfView = FOV;

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "FOV Menu", "Field of view menu",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("PureCheat").transform, delegate (bool a)
                {
                    ButtonAPI.EnterSubMenu(ButtonAPI.MakeEmptyPage("FOVMenu"));
                }, Color.white, Color.white, null, false, false);

            resetFOVButton = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, $"FOV [{FOV}]", $"Set field of view to {defaultFOV}",
                ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("FOVMenu").transform, delegate (bool a)
                {
                    FOV = defaultFOV;
                    playerCamera.fieldOfView = FOV;
                    resetFOVButton.transform.GetComponentInChildren<Text>().text = $"FOV [{FOV}]";
                }, Color.white, Color.white, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "▲", "Set field of view up",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("FOVMenu").transform, delegate (bool a)
                {
                    FOV += 1;
                    playerCamera.fieldOfView = FOV;
                    resetFOVButton.transform.GetComponentInChildren<Text>().text = $"FOV [{FOV}]";
                }, Color.white, Color.white, null, false, false);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "▼", "Set field of view down",
                ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, ButtonAPI.MakeEmptyPage("FOVMenu").transform, delegate (bool a)
                {
                    FOV -= 1;

                    if (FOV <= 0)
                        FOV = 1;

                    playerCamera.fieldOfView = FOV;
                    resetFOVButton.transform.GetComponentInChildren<Text>().text = $"FOV [{FOV}]";
                }, Color.white, Color.white, null, false);
        }
    }
}
