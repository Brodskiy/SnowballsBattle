using System;

namespace Assets.Srripts.GameElements.Characters
{
    public abstract class CharacterModel : GameElement
    {
        public  LiveData Lives { get; set; }

        public abstract void Attack();
    }
}
