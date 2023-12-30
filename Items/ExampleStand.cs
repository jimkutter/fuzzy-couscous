using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TimeStopHello.Items
{
    public class ExampleStand : ModItem
    {
        // Names and descriptions of all ExamplePetX classes are defined using .hjson files in the Localization folder
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.GolemPetItem);
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600);
            }
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient<StandArrow>(10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}