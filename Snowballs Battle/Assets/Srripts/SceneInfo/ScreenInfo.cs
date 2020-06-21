using UnityEngine;

namespace Assets.Srripts.SceneInfo
{
    public class ScreenInfo : IScreenInfo
    {
        public Vector3 MaxPosition { get; }
        public Vector3 MinPosition { get; }
        public Vector3 ScreenSize { get; }

        private readonly Camera _camera;

        public ScreenInfo(Camera cam)
        {
            _camera = cam;

            MaxPosition = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            MinPosition = _camera.ScreenToWorldPoint(new Vector3(0, 0));

            ScreenSize = MaxPosition - MinPosition;
        }
    }
}
