using Assets.Sripts;

namespace Assets.Srripts.GameElements
{
    public abstract class GameElement : IInitialization
    {
        public float SpeedElement { get; protected set; }

        public abstract void Initialization();
        public abstract void DestroyElement();
        public abstract void MoveElement();        
    }
}