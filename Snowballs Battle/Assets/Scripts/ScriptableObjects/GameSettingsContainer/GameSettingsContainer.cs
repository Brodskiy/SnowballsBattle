using System;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects.GameSettingsContainer
{
    [Serializable, CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/GameSettingsContainer")]
    class GameSettingsContainer : ScriptableObject
    {
        [SerializeField] private SettingsData _settingsData;

        public SettingsData GetSettingsData => _settingsData;

        public EnemyData GetEnemyInfo(EEnemyLevel enemyLevel)
        {
            foreach (var points in _settingsData.PointsForHit)
            {
                var targetEnemy = _settingsData.PointsForHit.Find(item => item.EnemyLevel == enemyLevel);
                return targetEnemy;
            }
            return null;
        }
    }
}
