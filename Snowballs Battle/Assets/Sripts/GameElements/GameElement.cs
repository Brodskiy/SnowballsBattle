using UnityEngine;
using Assets.Sripts;

namespace Assets.Srripts.GameElements
{
    public abstract class GameElement : MonoBehaviour, IInitialization
    {
        public float SpeedElement { get; protected set; }

        public abstract void Initialization();
        public abstract void DestroyElement();    
    }
}