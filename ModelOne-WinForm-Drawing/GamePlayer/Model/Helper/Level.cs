namespace Model
{
    public class Level
    {
        public static Actor[][] NewActors()
        {
            return new Actor[7][]
            {
            new Actor[5]{Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Goal,Actor.Tile,Actor.Tile,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Tile,Actor.Tile,Actor.Tile,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Goal,Actor.Box,Actor.Tile,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Tile,Actor.Box,Actor.Player,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Tile,Actor.Tile,Actor.Tile,Actor.Wall},
            new Actor[5]{Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall}
            };
        }

        public static Actor[][] LevelOne()
        {
            return new Actor[8][]
            {
            new Actor[8]{Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Tile,Actor.Tile,Actor.Wall,Actor.Tile,Actor.Tile,Actor.Tile,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Tile, Actor.Tile, Actor.Tile, Actor.Box,Actor.Tile, Actor.Tile, Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Tile, Actor.Tile, Actor.Wall,Actor.Box,Actor.Box,Actor.Tile,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Wall,Actor.Tile, Actor.Wall,Actor.Tile, Actor.Tile, Actor.Tile, Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Goal, Actor.Goal, Actor.Tile,Actor.Box,Actor.Wall,Actor.Tile,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Goal,Actor.Goal, Actor.Tile, Actor.Tile, Actor.Tile,Actor.Player,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Wall, Actor.Wall, Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall},
            };
        }

        public static Actor[][] LevelTwo()
        {
            return new Actor[6][]
            {
            new Actor[8]{Actor.None,Actor.Wall,Actor.Wall,Actor.Wall,Actor.Wall,Actor.None, Actor.None, Actor.None},
            new Actor[8]{Actor.None,Actor.Wall, Actor.Tile,Actor.Tile, Actor.Wall, Actor.Wall, Actor.Wall, Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Wall, Actor.Tile, Actor.Tile, Actor.Box,Actor.Tile, Actor.Tile, Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Tile, Actor.PlayerGoal, Actor.BoxGoal,Actor.Goal,Actor.Box,Actor.Tile,Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Tile, Actor.Box, Actor.Tile,Actor.Goal, Actor.Tile, Actor.Tile, Actor.Wall},
            new Actor[8]{Actor.Wall,Actor.Wall, Actor.Wall, Actor.Wall,Actor.Wall, Actor.Wall,Actor.Wall, Actor.Wall }
            };
        }
    }
}
