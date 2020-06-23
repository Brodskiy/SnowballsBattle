using UnityEngine;

namespace Assets.Sripts.GameElements.Shells.Snowboll
{
    class SnowbollEnemy : ShellModel
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
