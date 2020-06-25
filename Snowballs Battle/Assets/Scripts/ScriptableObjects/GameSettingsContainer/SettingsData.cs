﻿using System;
using System.Collections.Generic;

namespace Assets.Scripts.ScriptableObjects.GameSettingsContainer
{
    [Serializable]
    public class SettingsData
    {
        public float SpeedEnemy;
        public float SpeedPlayer;
        public int PointsToWin;
        public List<EnemyData> PointsForHit;
        public float CoolDownPlayer;
        public float CoolDownEnemy;
    }
}
