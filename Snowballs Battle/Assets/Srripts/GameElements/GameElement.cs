namespace Assets.Srripts.GameElements
{
    public abstract class GameElement
    {
        public float Speed { get; protected set; }
        public abstract void Initialization();
        public abstract void DestroyElement();
        public abstract void MoveElement();
    }
}
