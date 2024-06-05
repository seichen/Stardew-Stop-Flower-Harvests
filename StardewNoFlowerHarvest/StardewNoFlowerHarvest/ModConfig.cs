using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI.Utilities;

namespace StopFlowerHarvests
{
    public sealed class ModConfig
    {
        public KeybindList OpenMenu { get; set; } = KeybindList.Parse("o");
        public bool FairyRose { get; set; } = true;
    }
}
