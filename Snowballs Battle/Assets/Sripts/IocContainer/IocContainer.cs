using UnityEngine;

namespace Assets.Sripts.IocContainer
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
