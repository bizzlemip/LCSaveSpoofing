using System;
using System.Collections.Generic;
using System.Text;
using Mono.Cecil;
using BepInEx;
using UnityEngine;
using Unity;
using Unity.Netcode;
using Netcode.Transports.Facepunch;
using HarmonyLib;
using System.Reflection.Emit;
using System.Linq;

namespace BCompany.Patches
{
	[HarmonyPatch]
	public class SaveDataTranspilers {
		private static IEnumerable<CodeInstruction> SpoofSaveData(IEnumerable<CodeInstruction> instructions)
        {
			var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {
                CodeInstruction code = codes[i];
                if (code.opcode == OpCodes.Ldstr)
                {
                    if (code.operand.ToString() == "LCGeneralSaveData" || code.operand.ToString().Contains("LCSaveFile"))
                    {
                        code.operand = "ModSaves/" + code.operand.ToString().Replace("LC", "MC");
                    }
                }
            }
            return codes.AsEnumerable();
        }
        [HarmonyPatch(typeof(GameNetworkManager), "Start")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save2(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(EntranceTeleport), "TeleportPlayer")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save3(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(EntranceTeleport), "playMusicOnDelay")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save4(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(GameNetworkManager), "SaveLocalPlayerValues")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save5(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(GameNetworkManager), "OnApplicationQuit")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save6(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(HUDManager), "SetPlayerLevelSmoothly")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save7(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(HUDManager), "SetSavedValues")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save8(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(HUDManager), "TipsPanelTimer")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save9(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(HUDManager), "SetSavedValues")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save10(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(HUDManager), "CanTipDisplay")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save11(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "ResetSettingsToDefault")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save12(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "RefreshAndDisplayCurrentMicrophone")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save13(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "SetPlayerFinishedLaunchOptions")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save14(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "SetLaunchInOnlineMode")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save15(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "LoadSettingsFromPrefs")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save16(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "SaveSettingsToPrefs")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save17(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(IngamePlayerSettings), "RefreshAndDisplayCurrentMicrophone")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save18(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(MenuManager), "ConfirmHostButton")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save19(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(MenuManager), "Start")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save20(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(PreInitSceneScript), "restartGameDueToCorruptedFile")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save21(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(PreInitSceneScript), "restartGameDueToCorruptedFile")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save22(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(StartOfRound), "OnShipLandedMiscEvents")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save23(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(Terminal), "RunTerminalEvents")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save24(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(Terminal), "BeginUsingTerminal")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save25(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(TimeOfDay), "playSoundDelayed")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save26(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(DeleteFileButton), "DeleteFile")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save27(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }
        [HarmonyPatch(typeof(SaveFileUISlot), "Awake")]
        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> Save28(IEnumerable<CodeInstruction> instructions)
        {
            return (SpoofSaveData(instructions));
        }

    }
}