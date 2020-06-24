using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects.GameElementContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameElementContainer")]
    class GameElementContainer : ScriptableObject
    {
        [SerializeField] private List<GameElementData> _gameElementData;
        public List<GameElementData> GetGameElementInfo => _gameElementData;
    }
}
