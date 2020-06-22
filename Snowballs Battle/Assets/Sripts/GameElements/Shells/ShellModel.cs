using Assets.Srripts.GameElements;

namespace Assets.Sripts.GameElements.Shells
{
    public abstract class ShellModel : GameElement
    {
        public int Damage { get; protected set; }
        public float CoolDown { get; protected set; }
    }
}
