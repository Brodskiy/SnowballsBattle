using Assets.Scripts.GameElements.Shells;
using UnityEngine;

namespace Assets.Scripts.GameElements.Characters
{
    public class CharacterModel : GameElement
    {
        [SerializeField] protected ShellModel _shellModel;

        public LiveData Lives { get; protected set; }

        public void Attack()
        {
            _shellModel.Initialization();
        }
    }
}