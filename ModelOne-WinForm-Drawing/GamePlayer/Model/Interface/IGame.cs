namespace Model
{
    public interface IGame
    {
        bool CanMove(Moveable whichActor, Coordinate direction);
        void IsGameComplete();
        void Move(Coordinate direction);
        void MoveBox(Box whichBox, Coordinate direction);
        void MovePlayer(Coordinate direction);
        void UpdateBoard(Moveable whichActor);
        Actor WhatIsAt(Coordinate location);
        Box WhichBox(Coordinate loaction);
    }
}