using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Sripts.PoolObject.GameSettingsContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameSettingsContainer")]
    class GameSettingsContainer : ScriptableObject
    {
        [SerializeField] private List<SettingsData> _settingsData;
        public List<SettingsData> GetSettingsData => _settingsData;

        public EnemyData GetEnemyLevelInfo(EEnemyLevel enemyLevel)
        {
            var targetEnemy = _settingsData.Find(item => item.PointsForHit.EEnemyLevel == enemyLevel);
        }

    }
}
