
using HVH.Utils;
using System;
using System.IO;
using System.Net;
using System.Text;
using VRC.Core;
using HVH.API;

namespace BlazesClient.Modules
{
    public class Webhook : HVHSystem
    {
        public static string vrcaURL = "https://discord.com/api/webhooks/783505641351151646/fd-YPpQ102_SwhRQfyYMeJYJ-phqq0sZJxcefvuNGVA0X-_6CUDTfWrysNq_CwdbK886";

        public static void ReportVRCA()
        {
            try
            {
                string stringToEscape = "```" + GeneralUtils.TimeDone + "\nSent By: " + "HVH-Public" + " [" + APIUser.get_CurrentUser().get_state() + "] -=VRCA Grabbed=-\nAvatar ID: " + ((ApiModel)GeneralWrappers.GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar()).get_id() + "\nAvatar Status: " + GeneralWrappers.GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar().get_releaseStatus() + "\nAvatar Name: " + GeneralWrappers.GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar().get_name() + "\nAvatar Author: " + GeneralWrappers.GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar().get_authorName() + "\nAsset URL: " + .GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar().get_assetUrl() + "\nAvatar Image: " + GeneralWrappers.GetQuickMenu().GetSelectedPlayer().GetVRCPlayer().GetAPIAvatar().get_imageUrl() + "```";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Webhook.vrcaURL);
                byte[] bytes = Encoding.ASCII.GetBytes("content=" + Uri.EscapeDataString(stringToEscape) + "&username=" + Uri.EscapeDataString("Blaze's Client") + "&avatar_url=" + Uri.EscapeDataString("https://i.imgur.com/Bxl0Gq0.png"));
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.ContentLength = (long)bytes.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                    requestStream.Write(bytes, 0, bytes.Length);
                new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
            }
            catch
            {
            }
        }
    }
}
