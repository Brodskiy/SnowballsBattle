using Assets.Srripts.GameElements;

namespace Assets.Sripts.PoolObject
{
    public interface IPoolable : IInitialize
    {
        GameElement GetGameElement();
    }
}
