﻿using UnityModManagerNet;

namespace BrawlerClassWrath
{
    public class Settings : UnityModManager.ModSettings
    {

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            UnityModManager.ModSettings.Save<Settings>(this, modEntry);
        }

       public bool NoRequirement;
        
    }

}
