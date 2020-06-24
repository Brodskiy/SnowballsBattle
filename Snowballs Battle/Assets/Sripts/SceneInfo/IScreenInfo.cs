﻿using Assets.Sripts;
using UnityEngine;

namespace Assets.Srripts.SceneInfo
{
    public interface IScreenInfo : IInitialize
    {
        Vector3 MaxPosition { get; }
        Vector3 MinPosition { get; }
        Vector3 ScreenSize { get; }
    }
}
