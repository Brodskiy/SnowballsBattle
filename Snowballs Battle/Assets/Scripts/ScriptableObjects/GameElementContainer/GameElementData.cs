using Assets.Scripts.GameElements;
using System;

namespace Assets.Scripts.ScriptableObjects.GameElementContainer
{
    [Serializable]
    public class GameElementData
    {
        public EGameElements NameGameElement;
        public GameElement ElementPrefab;
        public int CountElement;
    }
}
