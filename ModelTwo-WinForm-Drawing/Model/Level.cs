using System.Collections.Generic;

namespace Model
{
    public class Level
    {
        public List<Component[][]> levels = new List<Component[][]>();
        public Level()
        {
            levels.Add(LevelOne());
            levels.Add(LevelTwo());
        }
        public static Component[][] LevelOne()
        {
            return new Component[8][]
            {
            new Component[8]{Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.Wall},
            new Component[8]{Component.Wall,Component.Tile,Component.Tile,Component.Wall,Component.Tile,Component.Tile,Component.Tile,Component.Wall},
            new Component[8]{Component.Wall,Component.Tile, Component.Tile, Component.Tile, Component.Box,Component.Tile, Component.Tile, Component.Wall},
            new Component[8]{Component.Wall,Component.Tile, Component.Tile, Component.Wall,Component.Box,Component.Box,Component.Tile,Component.Wall},
            new Component[8]{Component.Wall,Component.Wall,Component.Tile, Component.Wall,Component.Tile, Component.Tile, Component.Tile, Component.Wall},
            new Component[8]{Component.Wall,Component.Goal, Component.Goal, Component.Tile,Component.Box,Component.Wall,Component.Tile,Component.Wall},
            new Component[8]{Component.Wall,Component.Goal,Component.Goal, Component.Tile, Component.Tile, Component.Tile,Component.Player,Component.Wall},
            new Component[8]{Component.Wall,Component.Wall, Component.Wall, Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.Wall},
            };
        }

        public static Component[][] LevelTwo()
        {
            return new Component[6][]
            {
            new Component[8]{Component.None,Component.Wall,Component.Wall,Component.Wall,Component.Wall,Component.None, Component.None, Component.None},
            new Component[8]{Component.None,Component.Wall, Component.Tile,Component.Tile, Component.Wall, Component.Wall, Component.Wall, Component.Wall},
            new Component[8]{Component.Wall,Component.Wall, Component.Tile, Component.Tile, Component.Box,Component.Tile, Component.Tile, Component.Wall},
            new Component[8]{Component.Wall,Component.Tile, Component.PlayerGoal, Component.BoxGoal,Component.Goal,Component.Box,Component.Tile,Component.Wall},
            new Component[8]{Component.Wall,Component.Tile, Component.Box, Component.Tile,Component.Goal, Component.Tile, Component.Tile, Component.Wall},
            new Component[8]{Component.Wall,Component.Wall, Component.Wall, Component.Wall,Component.Wall, Component.Wall,Component.Wall, Component.Wall }
            };
        }
    }
}
