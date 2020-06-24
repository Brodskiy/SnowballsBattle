using UnityEngine;

namespace Assets.Scripts.GameElements.Shells.Snowboll
{
    public class SnowbollEnemy : ShellModel
    {
        public override void Initialization()
        {
            _rigidbody2D.bodyType = RigidbodyType2D.Static;
        }

        public override void DestroyElement()
        {
            gameObject.SetActive(false);
        }
    }
}