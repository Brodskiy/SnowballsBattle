using UnityEngine;

namespace Assets.Scripts.GameElements.Shells
{
    public abstract class ShellModel : GameElement
    {
        [SerializeField] protected Rigidbody2D _rigidbody2D;

        public int Damage { get; protected set; }
        public float CoolDown { get; protected set; }
    }
}
