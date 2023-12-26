using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using LethalCompanyLightSwitchAlwaysOn.Patches;
using UnityEngine;

namespace LethalCompanyLightSwitchAlwaysOn
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "Juny.LightSwitchAlwaysOn";
        private const string modName = "Light switch always on";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static Plugin Instance;

        private void Awake() {
            if (Instance == null)
            {
                Instance = this;
            }

            Debug.Log("LOADING MOD");

            harmony.PatchAll(typeof(Plugin));
            harmony.PatchAll(typeof(ShipLightsPatch));
        }
    }
}
