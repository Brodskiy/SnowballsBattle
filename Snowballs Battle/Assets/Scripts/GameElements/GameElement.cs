using UnityEngine;

namespace Assets.Scripts.GameElements
{
    public abstract class GameElement : MonoBehaviour
    {
        public float SpeedElement { get; protected set; }
        public bool IsActive { get; protected set; }

        public abstract void Initialization();
        public abstract void DestroyElement();
    }
}