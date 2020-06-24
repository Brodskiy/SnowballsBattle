using UnityEngine;

namespace Assets.Scripts.SceneInfo
{
    public interface IScreenInfo : IInitialize
    {
        Vector3 MaxPosition { get; }
        Vector3 MinPosition { get; }
        Vector3 ScreenSize { get; }
    }
}
