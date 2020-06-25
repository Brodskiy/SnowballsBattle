using System;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects.GameSettingsContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameSettingsContainer")]
    public class GameSettingsContainer : ScriptableObject, IGameSettingsContain
    {
        [SerializeField] private SettingsData _settingsData;

        public SettingsData GetSettingsData => _settingsData;        
    }
}
