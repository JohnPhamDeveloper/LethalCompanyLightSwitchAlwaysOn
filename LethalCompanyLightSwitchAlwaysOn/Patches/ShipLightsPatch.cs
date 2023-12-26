using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace LethalCompanyLightSwitchAlwaysOn.Patches
{
    [HarmonyPatch]
    internal class ShipLightsPatch
    {
        [HarmonyPatch(typeof(ShipLights), "SetShipLightsClientRpc")]
        [HarmonyPrefix]
        public static void SetShipLightsClientRpcPatch(ref bool setLightsOn)
        {
            // The first arg sets the light switch value for all clients
            setLightsOn = true;
        }
    }
}
