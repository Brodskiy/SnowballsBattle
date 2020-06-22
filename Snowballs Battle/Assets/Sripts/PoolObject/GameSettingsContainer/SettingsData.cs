using System;

namespace Assets.Sripts.PoolObject.GameSettingsContainer
{
    [Serializable]
    class SettingsData
    {
        public float SpeedEnemy;
        public float SpeedPlayer;
        public int PointsToWin;
        public EnemyData[] PointsForHit;
        public float CoolDownPlayer;
        public float CoolDownEnemy;
    }
}
