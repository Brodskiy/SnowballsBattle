using UnityEngine;

namespace Assets.Srripts.SceneInfo
{
    public interface IScreenInfo
    {
        Vector3 MaxPosition { get; }
        Vector3 MinPosition { get; }
        Vector3 ScreenSize { get; }
    }
}
