using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewValley.GameData.Crops;
using StardewValley;

namespace StopFlowerHarvests
{
    internal class Patch
    {
        public static HarvestMethod Postfix_GetHarvestMethod(HarvestMethod __result, Crop __instance)
        {
            try
            {
                if (__instance.GetData().HarvestItemId.Equals("595"))
                {
                    return HarvestMethod.Scythe;
                }
                return __result;
            }
            catch (Exception)
            {
                return __result;
            }
        }
    }
}
