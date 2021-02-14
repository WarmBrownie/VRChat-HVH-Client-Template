using UnityEngine;
using HVH.API;
using PlagueButtonAPI;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using Il2CppSystem;
using MelonLoader;
using RubyButtonAPI;
using UnhollowerRuntimeLib;
using VRC.Core;
using VRC.SDKBase;
using HVH.Utils;

namespace HVH.Modules
{
    public class FuckPlus : HVHSystem
    {
        public override string ModName => "VRC Minus";

        public override void OnStart()
		{
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/EmojiButton").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/EmoteButton").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Stats Button").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Avatar Worlds (Random)").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Public Avatar List").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Legacy Avatar List").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Avatar Worlds (What's Hot)/ViewPort").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Avatar Worlds (What's Hot)/Button").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/UserIconButton").SetActive(false);
			GameObject.Destroy(GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/ReportWorldButton"));
			GameObject.Destroy(GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/ReportAbuseButton"));
			GameObject.DestroyImmediate(GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Favorite Avatar List/GetMoreFavorites"));
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/VRCPlusMiniBanner/Image").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/HeaderContainer/VRCPlusBanner/Panel").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/QuickMenu_NewElements/_CONTEXT/QM_Context_ToolTip/_ToolTipPanel/Text").GetComponent<Text>().supportRichText = true;
			GameObject.Find("UserInterface/QuickMenu/QuickMenu_NewElements/_CONTEXT/QM_Context_User_Hover/_ToolTipPanel/Text").GetComponent<Text>().supportRichText = true;
			GameObject.Find("UserInterface/QuickMenu/QuickMenu_NewElements/_CONTEXT/QM_Context_User_Selected/_UserBio/Text").GetComponent<Text>().supportRichText = true;
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/EarlyAccessText").GetComponent<Text>().text = "<b><color=#FFA500>HVH-Mod</color><color=white>Fuck You:</color><color=#FFA500>1</color><color=white>.</color><color=#FFA500>0</color><color=white>.</color></b>";
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/EarlyAccessText").GetComponent<Text>().supportRichText = true;
			GameObject gameObject = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/EarlyAccessText");
			gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, 290f, gameObject.transform.localPosition.z);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/NameText").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/WorldText").SetActive(false);
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/BuildNumText").SetActive(false);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText").GetComponent<Text>().text = "<b><color=#FFA500>HVH-Mod</color><color=white>Fuck You:</color><color=#FFA500>1</color><color=white>.</color><color=#FFA500>0</color><color=white>.</color></b>";
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText").GetComponent<Text>().supportRichText = true;
			GameObject gameObject2 = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText");
			Vector2 sizeDelta = gameObject2.GetComponent<RectTransform>().sizeDelta;
			Vector3 localPosition = gameObject2.transform.localPosition;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(589.5f, sizeDelta.y);
			gameObject2.transform.localPosition = new Vector3(50f, localPosition.y, localPosition.z);
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Personal Avatar List/Button/TitleText").GetComponent<Text>().text = "<b><color=#FFA500>My Avatars</color></b>";
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Personal Avatar List/Button/TitleText").GetComponent<Text>().supportRichText = true;
			GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Favorite Avatar List/Button/TitleText").GetComponent<Text>().color = Color.white;
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/FPSText").GetComponent<Text>().color = GeneralUtils.hexToColor("#FFA500");
			//GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/FPSText").GetComponent<Text>().fontStyle = (FontStyle)1;
			GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/PingText").GetComponent<Text>().color = GeneralUtils.hexToColor("#FFA500");
			//GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/PingText").GetComponent<Text>().fontStyle = (FontStyle)1;
			GameObject gameObject3 = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/UIElementsButton");
			Vector2 sizeDelta2 = gameObject3.GetComponent<RectTransform>().sizeDelta;
			Vector3 localPosition2 = gameObject3.transform.localPosition;
			gameObject3.GetComponent<RectTransform>().sizeDelta = new Vector2(sizeDelta2.x, sizeDelta2.y * 0.5f);
			gameObject3.transform.localPosition = new Vector3(localPosition2.x, 740f, localPosition2.z);
			GameObject gameObject4 = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/CameraButton");
			Vector2 sizeDelta3 = gameObject4.GetComponent<RectTransform>().sizeDelta;
			Vector3 localPosition3 = gameObject4.transform.localPosition;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(sizeDelta3.x, sizeDelta3.y * 0.5f);
			gameObject4.transform.localPosition = new Vector3(-630f, 535f, localPosition3.z);
			GameObject gameObject5 = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/DetailsButton");
			Vector2 sizeDelta4 = gameObject5.GetComponent<RectTransform>().sizeDelta;
			Vector3 localPosition4 = gameObject5.transform.localPosition;
			gameObject5.GetComponent<RectTransform>().sizeDelta = new Vector2(sizeDelta4.x * 0.5f, sizeDelta4.y);
			gameObject5.transform.localPosition = new Vector3(-220f, localPosition4.y, localPosition4.z);
			GameObject gameObject6 = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu/Toggle_States_ShowTrustRank_Colors");
			Vector3 localPosition5 = gameObject6.transform.localPosition;
			gameObject6.transform.localPosition = new Vector3(630f, 630f, localPosition5.z);
			GameObject gameObject7 = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/FriendButton");
			Vector2 sizeDelta5 = gameObject7.GetComponent<RectTransform>().sizeDelta;
			Vector3 localPosition6 = gameObject7.transform.localPosition;
			gameObject7.GetComponent<RectTransform>().sizeDelta = new Vector2(sizeDelta5.x * 0.5f, sizeDelta5.y);
			gameObject7.transform.localPosition = new Vector3(-630f, localPosition6.y, localPosition6.z);
		}
	}
}
