using UnityEngine;

namespace Assets.Scripts.GameElements.Shells.Snowboll
{
    public class SnowbollEnemy : ShellModel
    {
        public override void Initialization()
        {
            base.Initialization();
            _rigidbody2D.bodyType = RigidbodyType2D.Static;
        }
    }
}