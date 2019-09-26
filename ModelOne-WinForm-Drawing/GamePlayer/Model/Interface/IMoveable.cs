namespace Model
{
    public interface IMoveable
    {
        void MovePos(Coordinate direction);
        Coordinate NextPos(Coordinate direction);
        string ToString();
        void UpdatePrevPos();
    }
}