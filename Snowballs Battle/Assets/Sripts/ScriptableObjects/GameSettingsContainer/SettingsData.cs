using System;
using System.Collections.Generic;

namespace Assets.Sripts.ScriptableObjects.GameSettingsContainer
{
    [Serializable]
    class SettingsData
    {
        public float SpeedEnemy;
        public float SpeedPlayer;
        public int PointsToWin;
        public List<EnemyData> PointsForHit;
        public float CoolDownPlayer;
        public float CoolDownEnemy;
    }
}
