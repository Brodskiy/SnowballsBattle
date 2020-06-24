using UnityEngine;

namespace Assets.Scripts.IocContainer
{
    public class IocContainer : MonoBehaviour
    {
        public static IocContainer Instance { get; private set; }
        private IocContainer()
        {
        }

        private void Start()
        {
            Instance = this;
        }
    }
}
