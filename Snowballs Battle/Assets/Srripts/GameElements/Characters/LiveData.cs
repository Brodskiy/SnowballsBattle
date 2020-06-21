namespace Assets.Srripts.GameElements.Characters
{
    public class LiveData
    {
        public int Lives { get; protected set; }

        public void AddLives(int value)
        {
            Lives += value;
        }

        public void RemuveLives(int value)
        {
            Lives -= value;
        }
    }
}
