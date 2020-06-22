using System;
using UnityEngine;

namespace Assets.Sripts.PoolObject.GameSettingsContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameSettingsContainer")]
    class GameSettingsContainer : ScriptableObject
    {
        public SettingsData Settings;
    }
}
