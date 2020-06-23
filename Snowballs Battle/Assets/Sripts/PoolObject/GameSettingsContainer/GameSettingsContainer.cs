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

        public EnemyData GetEnemyInfo(EEnemyLevel enemyLevel)
        {
            for (int i = 0; i < _settingsData.Count; i++)
            {
                for (int c = 0; c < _settingsData[i].PointsForHit.Count; c++)
                {
                    var targetEnemy = _settingsData[i].PointsForHit.Find(item => item.EnemyLevel == enemyLevel);
                    return targetEnemy;
                } 
            }
            return null;            
        }

    }
}
