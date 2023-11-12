using BepInEx;
using HarmonyLib;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace SaveSpoof
{
    [BepInPlugin("SaveSpoof", "SaveSpoof", "1.0.0")]
    [BepInProcess("Lethal Company.exe")]
    class Plugin : BaseUnityPlugin
    {
        private Harmony _harmony;
        private void Awake()
        {
            _harmony = new Harmony("SaveSpoof");
            _harmony.PatchAll();
            Logger.LogInfo($"Modded Saves loaded");
        }
    }


}
