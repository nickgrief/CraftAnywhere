using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CraftAnywhere
{
    public class CraftAnywhere : Mod
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];
                for (int j = 0; j < Recipe.maxRequirements; j++)
                {
                    recipe.requiredTile[j] = -1;
                    recipe.needWater = false;
                    recipe.needHoney = false;
                    recipe.needLava = false;
                }
            }
        }
    }
}