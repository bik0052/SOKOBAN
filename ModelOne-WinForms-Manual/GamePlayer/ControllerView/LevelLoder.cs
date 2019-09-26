using Model;
namespace ControllerView
{
    public class LevelLoder
    {
        private GameBoard gameBoard;
        private Actor[][] level;

        public LevelLoder(GameBoard newBoard, Actor[][] newlevel)
        {
            gameBoard = newBoard;
            level = newlevel;
        }

        public void Load(string newLevelName)
        {
            SetLevelName(newLevelName);
            SetBoard();
            SetActors();
        }

        public GameBoard GetBoard()
        {
            return gameBoard;
        }

        private void SetLevelName(string newLevelName)
        {
            gameBoard.boardName = newLevelName;
        }

        public void SetBoard()
        {
            gameBoard.currBoard = level;
        }

        private void SetBox(Coordinate position)
        {
            gameBoard.currBoxes.Add(new Box(position, false));
        }

        private void SetGoal(Coordinate position)
        {
            gameBoard.currGoals.Add(position);
        }

        private void SetPlayer(Coordinate position)
        {
            gameBoard.player = new Player(position);
        }

        public void SetActors()
        {
            for (int i = 0; i < level.Length; i++)
            {
                for (int j = 0; j < level[i].Length; j++)
                {
                    switch (level[i][j])
                    {
                        case Actor.Player:
                            SetPlayer(new Coordinate(j, i));
                            break;
                        case Actor.PlayerGoal:
                            SetPlayer(new Coordinate(j, i));
                            SetGoal(new Coordinate(j, i));
                            break;
                        case Actor.Box:
                            SetBox(new Coordinate(j, i));
                            break;
                        case Actor.BoxGoal:
                            SetBox(new Coordinate(j, i));
                            SetGoal(new Coordinate(j, i));
                            break;
                        case Actor.Goal:
                            SetGoal(new Coordinate(j, i));
                            break;
                    }
                }
            }
        }
    }
}
