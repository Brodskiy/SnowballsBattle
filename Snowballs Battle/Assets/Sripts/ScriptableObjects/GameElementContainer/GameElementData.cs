using Assets.Srripts.GameElements;
using System;

namespace Assets.Sripts.ScriptableObjects.GameElementContainer
{
    [Serializable]
    class GameElementData
    {
        public EGameElements NameGameElement;
        public GameElement[] ElementPrefab;
    }
}
