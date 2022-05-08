using StardewValley;

namespace MiniBars.Framework
{
    internal class Compatibility
    {
        internal static bool BlackListedMonster(string _monster_name)
        {
            if (Game1.player.currentLocation.Name == "UnderwaterBeach")
            {
                return _monster_name is "Serpent" or "Rock Crab";
            }
            else if (Game1.player.currentLocation.Name == "UnderwaterMountain")
            {
                return _monster_name is "Pepper Rex";
            }
            return false;
        }
    }
}
