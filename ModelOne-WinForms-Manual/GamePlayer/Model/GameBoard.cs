using System.Collections.Generic;
using System;

namespace Model
{
    [Serializable]
    public class GameBoard : IGame
    {
        public string boardName;
        public Actor[][] currBoard;
        public Player player;
        public List<Box> currBoxes;
        public List<Coordinate> currGoals;
        public bool boardComplete = false;
        public int moveCounts = 0;

        public GameBoard()
        {
            currBoxes = new List<Box>();
            currGoals = new List<Coordinate>();
        }

        public void Move(Coordinate direction)
        {
            if (CanMove(player, direction) == true)
            {
                MovePlayer(direction);
            }
            else if (WhatIsAt(player.NextPos(direction)) == Actor.Box || WhatIsAt(player.NextPos(direction)) == Actor.BoxGoal)
            {
                Box box = WhichBox(player.NextPos(direction));
                if (CanMove(box, direction) == true)
                {
                    MoveBox(box, direction);
                    UpdateBoard(box);
                    MovePlayer(direction);
                }
            }
        }

        public Box WhichBox(Coordinate loaction)
        {
            Box result = currBoxes[0];
            foreach (Box box in currBoxes)
            {
                if (box.currPos.posX == loaction.posX && box.currPos.posY == loaction.posY)
                {
                    result = box;
                    break;
                }
            }
            return result;
        }

        public void MovePlayer(Coordinate direction)
        {
            player.UpdatePrevPos();
            player.MovePos(direction);
            moveCounts++;
            UpdateBoard(player);
        }

        public void MoveBox(Box whichBox, Coordinate direction)
        {
            whichBox.UpdatePrevPos();
            whichBox.MovePos(direction);
        }

        public Actor WhatIsAt(Coordinate location)
        {
            return currBoard[location.posY][location.posX];
        }

        public bool CanMove(Moveable whichActor, Coordinate direction)
        {
            bool result = false;
            Coordinate newDirection = whichActor.NextPos(direction);
            Actor actor = WhatIsAt(newDirection);
            if (actor == Actor.Tile || actor == Actor.Goal)
            {
                result = true;
            }
            return result;
        }

        public void UpdateBoard(Moveable whichActor)
        {
            Actor actorAtCurrPos = WhatIsAt(whichActor.currPos);
            Actor actorAtPrePos = WhatIsAt(whichActor.prevPos);
            if (whichActor.type == "player")
            {
                if (actorAtCurrPos == Actor.Goal)
                {
                    currBoard[whichActor.currPos.posY][whichActor.currPos.posX] = Actor.PlayerGoal;
                }
                else
                {
                    currBoard[whichActor.currPos.posY][whichActor.currPos.posX] = Actor.Player;
                }

                if (actorAtPrePos == Actor.PlayerGoal)
                {
                    currBoard[whichActor.prevPos.posY][whichActor.prevPos.posX] = Actor.Goal;
                }
                else
                {
                    currBoard[whichActor.prevPos.posY][whichActor.prevPos.posX] = Actor.Tile;
                }
            }

            if (whichActor.type == "box")
            {
                if (actorAtCurrPos == Actor.Goal)
                {
                    currBoard[whichActor.currPos.posY][whichActor.currPos.posX] = Actor.BoxGoal;
                }
                else
                {
                    currBoard[whichActor.currPos.posY][whichActor.currPos.posX] = Actor.Box;
                }

                if (actorAtPrePos == Actor.BoxGoal)
                {
                    currBoard[whichActor.prevPos.posY][whichActor.prevPos.posX] = Actor.Goal;
                }
                else
                {
                    currBoard[whichActor.prevPos.posY][whichActor.prevPos.posX] = Actor.Player;
                }
            }
        }

        public void IsGameComplete()
        {
            int noOfGoals = currGoals.Count;
            int noOfBoxOnGoal = 0;

            foreach (Box aBox in currBoxes)
            {
                foreach (Coordinate aGoal in currGoals)
                {
                    if (aBox.currPos.posX == aGoal.posX && aBox.currPos.posY == aGoal.posY)
                    {
                        noOfBoxOnGoal++;
                        aBox.isOnGoal = true;
                    }
                    else
                    {
                        aBox.isOnGoal = false;
                    }
                }
            }

            if (noOfGoals == noOfBoxOnGoal)
            {
                boardComplete = true;
            }
        }
    }
}
