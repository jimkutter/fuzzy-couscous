using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TimeStopHello.Items
{

    public class StandArrow : ModItem
    {
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodenArrow);
        }

        public override void AddRecipes()
        {
            CreateRecipe(999)
                .AddIngredient(ItemID.WoodenArrow, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}