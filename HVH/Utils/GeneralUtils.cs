
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using HVH.API;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using VRC.SDKBase;
using System

namespace HVH.Utils
{
    internal static class GeneralUtils
	{

		public static Color hexToColor(string hex)
		{
			hex = hex.Replace("0x", "");
			hex = hex.Replace("#", "");
			byte b = byte.MaxValue;
			byte b2 = byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
			byte b3 = byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
			byte b4 = byte.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);
			bool flag = hex.Length == 8;
			if (flag)
			{
				b = byte.Parse(hex.Substring(6, 2), NumberStyles.HexNumber);
			}
			return new Color32(b2, b3, b4, b);
		}

		public static void setColor(Button button, Color color)
		{
			ColorBlock colors = default(ColorBlock);
			colors.colorMultiplier = 1f;
			colors.disabledColor = Color.grey;
			colors.highlightedColor = color * 1.5f;
			colors.normalColor = color;
			colors.pressedColor = Color.grey * 1.5f;
			button.colors = colors;
		}

		public static string TimeDone
		{
			get
			{
				return "[" + DateTime.UtcNow.ToString("dd/MM/yyyy hh:mm:ss", DateTimeFormatInfo.InvariantInfo) + "]";
			}
		}

		public static void rainbow()
		{
			bool flag = RainbowColorsInts.r <= 1f && RainbowColorsInts.g == 0f && RainbowColorsInts.b == 0f;
			bool flag2 = flag;
			if (flag2)
			{
				RainbowColorsInts.r += 0.01f * RainbowColorsInts.speed;
			}
			bool flag3 = RainbowColorsInts.r >= 1f && RainbowColorsInts.g >= 0f && RainbowColorsInts.b == 0f;
			bool flag4 = flag3;
			if (flag4)
			{
				RainbowColorsInts.g += 0.01f * RainbowColorsInts.speed;
			}
			bool flag5 = RainbowColorsInts.r >= 0f && RainbowColorsInts.g >= 1f && RainbowColorsInts.b == 0f;
			bool flag6 = flag5;
			if (flag6)
			{
				RainbowColorsInts.r -= 0.01f * RainbowColorsInts.speed;
			}
			bool flag7 = RainbowColorsInts.r <= 0f && RainbowColorsInts.g >= 1f && RainbowColorsInts.b >= 0f;
			bool flag8 = flag7;
			if (flag8)
			{
				RainbowColorsInts.b += 0.01f * RainbowColorsInts.speed;
			}
			bool flag9 = RainbowColorsInts.r <= 0f && RainbowColorsInts.g >= 0f && RainbowColorsInts.b >= 1f;
			bool flag10 = flag9;
			if (flag10)
			{
				RainbowColorsInts.g -= 0.01f * RainbowColorsInts.speed;
			}
			bool flag11 = RainbowColorsInts.r <= 1f && RainbowColorsInts.g <= 0f && RainbowColorsInts.b >= 1f;
			bool flag12 = flag11;
			if (flag12)
			{
				RainbowColorsInts.r += 0.01f * RainbowColorsInts.speed;
			}
			bool flag13 = RainbowColorsInts.r >= 1f && RainbowColorsInts.g <= 0f && RainbowColorsInts.b >= 0f;
			bool flag14 = flag13;
			if (flag14)
			{
				RainbowColorsInts.b -= 0.01f * RainbowColorsInts.speed;
			}
			bool flag15 = RainbowColorsInts.r >= 1f && RainbowColorsInts.g <= 0f && RainbowColorsInts.b <= 0f;
			bool flag16 = flag15;
			if (flag16)
			{
				RainbowColorsInts.r = 1f;
				RainbowColorsInts.g = 0f;
				RainbowColorsInts.b = 0f;
			}
		}


		public static IEnumerator CooldownTimer()
		{
			yield return new WaitForSecondsRealtime((float)GeneralUtils.UserListCooldown);
			GeneralUtils.UserListCooldown = 0;
			yield break;
		}

		


		public static void FetchMirrors()
		{
			GeneralUtils.originalMirrors = new List<MirrorInfo>();
			foreach (VRC_MirrorReflection vrc_MirrorReflection in Resources.FindObjectsOfTypeAll<VRC_MirrorReflection>())
			{
				GeneralUtils.originalMirrors.Add(new MirrorInfo
				{
					MirrorParent = vrc_MirrorReflection,
					OriginalLayers = vrc_MirrorReflection.m_ReflectLayers
				});
			}
		}
		public static void OptimizeMirrors()
		{
			bool flag = GeneralUtils.originalMirrors.Count != 0;
			if (flag)
			{
				foreach (MirrorInfo mirrorInfo in GeneralUtils.originalMirrors)
				{
					mirrorInfo.MirrorParent.m_ReflectLayers = GeneralUtils.optimizeMask;
				}
			}
		}

		public static void BeautifyMirrors()
		{
			bool flag = GeneralUtils.originalMirrors.Count != 0;
			if (flag)
			{
				foreach (MirrorInfo mirrorInfo in GeneralUtils.originalMirrors)
				{
					mirrorInfo.MirrorParent.m_ReflectLayers = GeneralUtils.beautifyMask;
				}
			}
		}
		public static void RevertMirrors()
		{
			bool flag = GeneralUtils.originalMirrors.Count != 0;
			if (flag)
			{
				foreach (MirrorInfo mirrorInfo in GeneralUtils.originalMirrors)
				{
					mirrorInfo.MirrorParent.m_ReflectLayers = mirrorInfo.OriginalLayers;
				}
			}
		}

		public static void UpdateFriendList()
		{
			GeneralUtils.friend_list.Clear();
			for (int i = 0; i < APIUser.CurrentUser.friendIDs.Count; i++)
			{
				string item = APIUser.CurrentUser.friendIDs[i];
				GeneralUtils.friend_list.Add(item);
			}
		}

		public static void InformHudText(Color color, string text)
		{
			var NormalColor = VRCUiManager.prop_VRCUiManager_0.hudMessageText.color;
			VRCUiManager.prop_VRCUiManager_0.hudMessageText.color = color;
			VRCUiManager.prop_VRCUiManager_0.Method_Public_Void_String_0($"[HVH] {text}");
			VRCUiManager.prop_VRCUiManager_0.hudMessageText.color = NormalColor;
		}

		//private static AssetBundle myAssetBundle;

		//public static Sprite logoSprite;

		public static List<Button> uiButtons = new List<Button>();

		public static List<Graphic> uiGraphics = new List<Graphic>();

		public static int UserListCooldown;

		private static LayerMask optimizeMask;

		private static LayerMask beautifyMask;

		public static List<MirrorInfo> originalMirrors = new List<MirrorInfo>();

		public static List<string> friend_list = new List<string>();
	}
}


