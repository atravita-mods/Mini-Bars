﻿using StardewModdingAPI;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MiniBars.Framework.Rendering
{
    internal class Textures
    {
        internal static Texture2D hp_sprite;
        internal static Texture2D default_theme;
        internal static Texture2D greenslime_theme,
            blueslime_theme,
            bat_theme,
            frostbat_theme,
            lavabat_theme,
            bug_theme,
            cavefly_theme,
            duggy_theme,
            grub_theme,
            rockcrab_theme,
            lavacrab_theme,
            stonegolem_theme,
            dust_theme,
            ghost_theme,
            skeleton_theme,
            metalhead_theme,
            shadowbrute_theme,
            shadowshaman_theme,
            squidkid_theme;
        internal static Texture2D armoredbug_theme,
            carbonghost_theme,
            iridiumbat_theme,
            iridiumcrab_theme,
            mummy_theme,
            pepperrex_theme,
            serpent_theme;
        internal static Texture2D hauntedskull_theme;
        internal static Texture2D mutantfly_theme,
            mutantgrub_theme;
        internal static Texture2D wildernessgolem_theme;
        internal static Texture2D dwarvishsentry_theme,
            falsemagmacap_theme,
            hothead_theme,
            lavalurk_theme,
            magmaduggy_theme,
            magmasparker_theme,
            magmasprite_theme,
            tigerslime_theme;
        internal static Texture2D hardmode_bug,
            hardmode_crab,
            hardmode_duggy,
            hardmode_dust,
            hardmode_frostbat,
            hardmode_squid,
            hardmode_putridghost,
            hardmode_skeleton,
            hardmode_spider,
            hardmode_lavacrab,
            hardmode_metalhead,
            hardmode_squidkid,
            hardmode_shadowshaman,
            hardmode_stickbug;

        private static Lazy<Texture2D> pixelLazy = new(() =>
        {
            Texture2D _pixel = new(Game1.graphics.GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });
            return _pixel;
        });

        internal static Texture2D Pixel => pixelLazy.Value;

        public static void LoadTextures()
        {
            IModHelper helper = ModEntry.instance.Helper;

            Database.SetThemeForConfig();

            hp_sprite = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Others/hp_sprite.png", ContentSource.ModFolder);
            default_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Others/default_theme.png", ContentSource.ModFolder);

            //NORMAL MINES
            greenslime_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/greenslime_theme.png", ContentSource.ModFolder);
            blueslime_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/blueslime_theme.png", ContentSource.ModFolder);
            bat_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/bat_theme.png", ContentSource.ModFolder);
            frostbat_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/frostbat_theme.png", ContentSource.ModFolder);
            lavabat_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/lavabat_theme.png", ContentSource.ModFolder);
            bug_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/bug_theme.png", ContentSource.ModFolder);
            cavefly_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/cavefly_theme.png", ContentSource.ModFolder);
            duggy_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/duggy_theme.png", ContentSource.ModFolder);
            grub_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/grub_theme.png", ContentSource.ModFolder);
            rockcrab_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/rockcrab_theme.png", ContentSource.ModFolder);
            lavacrab_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/lavacrab_theme.png", ContentSource.ModFolder);
            stonegolem_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/stonegolem_theme.png", ContentSource.ModFolder);
            dust_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/dust_theme.png", ContentSource.ModFolder);
            ghost_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/ghost_theme.png", ContentSource.ModFolder);
            skeleton_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/skeleton_theme.png", ContentSource.ModFolder);
            metalhead_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/metalhead_theme.png", ContentSource.ModFolder);
            shadowbrute_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/shadowbrute_theme.png", ContentSource.ModFolder);
            shadowshaman_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/shadowshaman_theme.png", ContentSource.ModFolder);
            squidkid_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Normal_Mines/squidkid_theme.png", ContentSource.ModFolder);

            //SKULL CAVERN
            armoredbug_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/armoredbug_theme.png", ContentSource.ModFolder);
            carbonghost_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/carbonghost_theme.png", ContentSource.ModFolder);
            iridiumbat_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/iridiumbat_theme.png", ContentSource.ModFolder);
            iridiumcrab_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/iridiumcrab_theme.png", ContentSource.ModFolder);
            mummy_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/mummy_theme.png", ContentSource.ModFolder);
            pepperrex_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/pepperrex_theme.png", ContentSource.ModFolder);
            serpent_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Skull_Cavern/serpent_theme.png", ContentSource.ModFolder);

            //QUARRY MINE
            hauntedskull_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Quarry_Mine/hauntedskull_theme.png", ContentSource.ModFolder);

            //MUTANT BUG LAIR
            mutantfly_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Mutant_Bug_Lair/mutantfly_theme.png", ContentSource.ModFolder);
            mutantgrub_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Mutant_Bug_Lair/mutantgrub_theme.png", ContentSource.ModFolder);

            //WILDERNESS
            wildernessgolem_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Wilderness/wildernessgolem_theme.png", ContentSource.ModFolder);

            //VOLCANO DUNGEON
            dwarvishsentry_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/dwarvishsentry_theme.png", ContentSource.ModFolder);
            falsemagmacap_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/falsemagmacap_theme.png", ContentSource.ModFolder);
            hothead_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/hothead_theme.png", ContentSource.ModFolder);
            lavalurk_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/lavalurk_theme.png", ContentSource.ModFolder);
            magmaduggy_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmaduggy_theme.png", ContentSource.ModFolder);
            magmasparker_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmasparker_theme.png", ContentSource.ModFolder);
            magmasprite_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/magmasprite_theme.png", ContentSource.ModFolder);
            tigerslime_theme = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/Volcano_Dungeon/tigerslime_theme.png", ContentSource.ModFolder);

            //HARDMODE
            hardmode_bug = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_bug.png", ContentSource.ModFolder);
            hardmode_crab = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_crab.png", ContentSource.ModFolder);
            hardmode_duggy = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_duggy.png", ContentSource.ModFolder);
            hardmode_dust = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_dust.png", ContentSource.ModFolder);
            hardmode_frostbat = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_frostbat.png", ContentSource.ModFolder);
            hardmode_squid = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_squid.png", ContentSource.ModFolder);
            hardmode_putridghost = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_putridghost.png", ContentSource.ModFolder);
            hardmode_skeleton = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_skeleton.png", ContentSource.ModFolder);
            hardmode_spider = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_spider.png", ContentSource.ModFolder);
            hardmode_lavacrab = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_lavacrab.png", ContentSource.ModFolder);
            hardmode_metalhead = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_metalhead.png", ContentSource.ModFolder);
            hardmode_squidkid = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_squidkid.png", ContentSource.ModFolder);
            hardmode_shadowshaman = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_shadowshaman.png", ContentSource.ModFolder);
            hardmode_stickbug = helper.Content.Load<Texture2D>($"assets/{Database.BarTheme}/HardMode/hardmode_stickbug.png", ContentSource.ModFolder);
        }
    }
}
