using System;
using UnityEngine;

namespace Assets.Sripts.PoolObject.GameElementContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameElementContainer")]
    class GameElementContainer : ScriptableObject
    {
        public GameElementData[] GameElementInfo; 
    }
}
