using UnityEngine;

namespace Assets.Scripts.GameElements
{
    public abstract class GameElement : MonoBehaviour
    {
        public float SpeedElement { get; protected set; }
        public bool IsActive { get; protected set; }

        public virtual void Initialization()
        {
            SetState(true);
        }

        public virtual void DestroyElement()
        {
            SetState(false);
        }

        protected void SetState(bool isActive)
        {
            IsActive = isActive;
            gameObject.SetActive(false);
        }
    }
}