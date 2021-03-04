﻿using HarmonyLib;
using NebulaClient.MonoBehaviours;
using NebulaHost.MonoBehaviours;
using UnityEngine;

namespace NebulaPatcher.Patches.Dynamic
{
    [HarmonyPatch(typeof(UIEscMenu), "OnButton5Click")]
    [HarmonyPatch(typeof(UIEscMenu), "OnButton6Click")]
    class UIEscMenu_Patch
    {
        public static void Postfix()
        {
            Object.FindObjectOfType<MultiplayerClientSession>()?.Disconnect();
            Object.FindObjectOfType<MultiplayerHostSession>()?.StopServer();
        }
    }
}
