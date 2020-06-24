using UnityEngine;

namespace Assets.Scripts.GameElements.Shells.Snowboll
{
    public class SnowbollPlayer : ShellModel
    {
        public override void Initialization()
        {
            _rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        }

        public override void DestroyElement()
        {
            gameObject.SetActive(false);
        }
    }
}