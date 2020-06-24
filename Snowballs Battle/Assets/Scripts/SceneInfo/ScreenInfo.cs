using UnityEngine;

namespace Assets.Scripts.SceneInfo
{
    public class ScreenInfo : MonoBehaviour, IScreenInfo
    {
        [SerializeField] private Camera _mainCamera;

        public Vector3 MaxPosition { get; protected set; }
        public Vector3 MinPosition { get; protected set; }
        public Vector3 ScreenSize { get; protected set; }

        public void Initialization()
        {
            MaxPosition = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            MinPosition = _mainCamera.ScreenToWorldPoint(new Vector3(0, 0));

            ScreenSize = MaxPosition - MinPosition;
        }
    }
}