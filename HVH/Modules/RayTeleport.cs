﻿using UnityEngine;
using PureCheat.API;

namespace PureCheat.Addons
{
    public class RayTeleport : PureModSystem
    {
        public override string ModName => "RayTeleport";
        public override void OnUpdate()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButtonDown(0))
            {
                GameObject playerCamera = PureUtils.GetLocalPlayerCamera();

                Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
                RaycastHit[] hits = Physics.RaycastAll(ray);
                if (hits.Length > 0)
                {
                    RaycastHit raycastHit = hits[0];
                    PureUtils.GetLocalPlayer().transform.position = raycastHit.point;
                }
            }
        }
    }
}
