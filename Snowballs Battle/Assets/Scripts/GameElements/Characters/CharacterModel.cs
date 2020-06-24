namespace Assets.Scripts.GameElements.Characters
{
    public abstract class CharacterModel : GameElement
    {
        public LiveData Lives { get; protected set; }

        public abstract void Attack();
    }
}
