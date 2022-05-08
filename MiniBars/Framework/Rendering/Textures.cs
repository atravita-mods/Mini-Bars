using StardewModdingAPI;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MiniBars.Framework.Rendering
{
    internal class Textures
    {
        internal static Lazy<Texture2D> hp_sprite { get; private set; }
        internal static Lazy<Texture2D> default_theme { get; private set; }

        // Monster themes.
        internal static Lazy<Texture2D> greenslime_theme { get; private set; }
        internal static Lazy<Texture2D> blueslime_theme { get; private set; }
        internal static Lazy<Texture2D> bat_theme { get; private set; }
        internal static Lazy<Texture2D> frostbat_theme { get; private set; }
        internal static Lazy<Texture2D> lavabat_theme { get; private set; }
        internal static Lazy<Texture2D> bug_theme { get; private set; }
        internal static Lazy<Texture2D> cavefly_theme { get; private set; }
        internal static Lazy<Texture2D> duggy_theme { get; private set; }
        internal static Lazy<Texture2D> grub_theme { get; private set; }
        internal static Lazy<Texture2D> rockcrab_theme { get; private set; }
        internal static Lazy<Texture2D> lavacrab_theme { get; private set; }
        internal static Lazy<Texture2D> stonegolem_theme { get; private set; }
        internal static Lazy<Texture2D> dust_theme { get; private set; }
        internal static Lazy<Texture2D> ghost_theme { get; private set; }
        internal static Lazy<Texture2D> skeleton_theme { get; private set; }
        internal static Lazy<Texture2D> metalhead_theme { get; private set; }
        internal static Lazy<Texture2D> shadowbrute_theme { get; private set; }
        internal static Lazy<Texture2D> shadowshaman_theme { get; private set; }
        internal static Lazy<Texture2D> squidkid_theme { get; private set; }

        // Skull Cavern monsters.
        internal static Lazy<Texture2D> armoredbug_theme { get; private set; }
        internal static Lazy<Texture2D> carbonghost_theme { get; private set; }
        internal static Lazy<Texture2D> iridiumbat_theme { get; private set; }
        internal static Lazy<Texture2D> iridiumcrab_theme { get; private set; }
        internal static Lazy<Texture2D> mummy_theme { get; private set; }
        internal static Lazy<Texture2D> pepperrex_theme { get; private set; }
        internal static Lazy<Texture2D> serpent_theme { get; private set; }

        // Special monsters
        internal static Lazy<Texture2D> hauntedskull_theme { get; private set; }
        internal static Lazy<Texture2D> mutantfly_theme { get; private set; }
        internal static Lazy<Texture2D> mutantgrub_theme { get; private set; }

        // Volcano monsters
        internal static Lazy<Texture2D> wildernessgolem_theme { get; private set; }
        internal static Lazy<Texture2D> dwarvishsentry_theme { get; private set; }
        internal static Lazy<Texture2D> falsemagmacap_theme { get; private set; }
        internal static Lazy<Texture2D> hothead_theme { get; private set; }
        internal static Lazy<Texture2D> lavalurk_theme { get; private set; }
        internal static Lazy<Texture2D> magmaduggy_theme { get; private set; }
        internal static Lazy<Texture2D> magmasparker_theme { get; private set; }
        internal static Lazy<Texture2D> magmasprite_theme { get; private set; }
        internal static Lazy<Texture2D> tigerslime_theme { get; private set; }

        // Hardmode monsters.
        internal static Lazy<Texture2D> hardmode_bug { get; private set; }

        internal static Lazy<Texture2D> hardmode_crab { get; private set; }
        internal static Lazy<Texture2D> hardmode_duggy { get; private set; }
        internal static Lazy<Texture2D> hardmode_dust { get; private set; }
        internal static Lazy<Texture2D> hardmode_frostbat { get; private set; }
        internal static Lazy<Texture2D> hardmode_squid { get; private set; }
        internal static Lazy<Texture2D> hardmode_putridghost { get; private set; }
        internal static Lazy<Texture2D> hardmode_skeleton { get; private set; }
        internal static Lazy<Texture2D> hardmode_spider { get; private set; }
        internal static Lazy<Texture2D> hardmode_lavacrab { get; private set; }
        internal static Lazy<Texture2D> hardmode_metalhead { get; private set; }
        internal static Lazy<Texture2D> hardmode_squidkid { get; private set; }
        internal static Lazy<Texture2D> hardmode_shadowshaman { get; private set; }
        internal static Lazy<Texture2D> hardmode_stickbug { get; private set; }

        private static Lazy<Texture2D> pixelLazy = new(() =>
        {
            Texture2D _pixel = new(Game1.graphics.GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });
            return _pixel;
        });

        internal static Texture2D Pixel => pixelLazy.Value;

        internal static void LoadTextures()
        {
            IModHelper helper = ModEntry.instance.Helper;

            Database.SetThemeForConfig();

            hp_sprite = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Others/hp_sprite.png"));
            default_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Others/default_theme.png"));

            //NORMAL MINES
            greenslime_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/greenslime_theme.png"));
            blueslime_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/blueslime_theme.png"));
            bat_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/bat_theme.png"));
            frostbat_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/frostbat_theme.png"));
            lavabat_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/lavabat_theme.png"));
            bug_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/bug_theme.png"));
            cavefly_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/cavefly_theme.png"));
            duggy_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/duggy_theme.png"));
            grub_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/grub_theme.png"));
            rockcrab_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/rockcrab_theme.png"));
            lavacrab_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/lavacrab_theme.png"));
            stonegolem_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/stonegolem_theme.png"));
            dust_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/dust_theme.png"));
            ghost_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/ghost_theme.png"));
            skeleton_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/skeleton_theme.png"));
            metalhead_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/metalhead_theme.png"));
            shadowbrute_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/shadowbrute_theme.png"));
            shadowshaman_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/shadowshaman_theme.png"));
            squidkid_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/squidkid_theme.png"));

            //SKULL CAVERN
            armoredbug_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/armoredbug_theme.png"));
            carbonghost_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/carbonghost_theme.png"));
            iridiumbat_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/iridiumbat_theme.png"));
            iridiumcrab_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/iridiumcrab_theme.png"));
            mummy_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/mummy_theme.png"));
            pepperrex_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/pepperrex_theme.png"));
            serpent_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/serpent_theme.png"));

            //QUARRY MINE
            hauntedskull_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Quarry_Mine/hauntedskull_theme.png"));

            //MUTANT BUG LAIR
            mutantfly_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Mutant_Bug_Lair/mutantfly_theme.png"));
            mutantgrub_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Mutant_Bug_Lair/mutantgrub_theme.png"));

            //WILDERNESS
            wildernessgolem_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Wilderness/wildernessgolem_theme.png"));

            //VOLCANO DUNGEON
            dwarvishsentry_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/dwarvishsentry_theme.png"));
            falsemagmacap_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/falsemagmacap_theme.png"));
            hothead_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/hothead_theme.png"));
            lavalurk_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/lavalurk_theme.png"));
            magmaduggy_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmaduggy_theme.png"));
            magmasparker_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmasparker_theme.png"));
            magmasprite_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmasprite_theme.png"));
            tigerslime_theme = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/tigerslime_theme.png"));

            //HARDMODE
            hardmode_bug = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_bug.png"));
            hardmode_crab = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_crab.png"));
            hardmode_duggy = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_duggy.png"));
            hardmode_dust = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_dust.png"));
            hardmode_frostbat = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_frostbat.png"));
            hardmode_squid = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_squid.png"));
            hardmode_putridghost = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_putridghost.png"));
            hardmode_skeleton = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_skeleton.png"));
            hardmode_spider = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_spider.png"));
            hardmode_lavacrab = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_lavacrab.png"));
            hardmode_metalhead = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_metalhead.png"));
            hardmode_squidkid = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_squidkid.png"));
            hardmode_shadowshaman = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_shadowshaman.png"));
            hardmode_stickbug = new(() => helper.ModContent.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_stickbug.png"));
        }
    }
}
