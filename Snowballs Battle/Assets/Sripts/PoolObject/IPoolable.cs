using Assets.Sripts.ScriptableObjects;
using Assets.Srripts.GameElements;

namespace Assets.Sripts.PoolObject
{
    public interface IPoolable : IInitialize
    {
        GameElement GetGameElement(EGameElements eGameElements);
    }
}
