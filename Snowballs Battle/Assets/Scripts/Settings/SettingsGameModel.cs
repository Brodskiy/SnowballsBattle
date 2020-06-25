using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.ScriptableObjects.GameSettingsContainer;
using UnityEngine;

namespace Assets.Scripts.Settings
{
    public class SettingsGameModel : MonoBehaviour, IGameSettings
    {
        [SerializeField] private GameSettingsContainer _settingsData;

        public IGameSettingsContain GameSettings => _settingsData;

        public EnemyData GetEnemyInfo(EEnemyLevel enemyLevel)
        {
            foreach (var points in GameSettings.GetSettingsData.PointsForHit)
            {
                var targetEnemy = GameSettings.GetSettingsData.PointsForHit.Find(item => item.EnemyLevel == enemyLevel);
                return targetEnemy;
            }
            return null;
        }      
    }    
}