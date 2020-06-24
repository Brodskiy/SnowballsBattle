using Assets.Scripts.GameElements;
using Assets.Scripts.ScriptableObjects;

namespace Assets.Scripts.PoolObject
{
    public interface IPoolable : IInitialize
    {
        GameElement GetGameElement(EGameElements eGameElements);
    }
}
