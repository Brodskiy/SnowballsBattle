using System;

namespace Assets.Scripts.GameElements.Characters
{
    public class LiveData
    {
        const int ZERO = 0;
        public event Action LiveIsOver;

        public int Lives { get; protected set; }

        public void SetLives(int value)
        {
            if (value > ZERO)
            {
                Lives = value;
            }            
        }

        public void AddLives(int value)
        {
            Lives += value;
        }

        public void RemoveLives(int value)
        {
            if (Lives - value <= ZERO)
            {
                LiveIsOver?.Invoke();
            }
            else
            {
                Lives -= value;
            }            
        }
    }
}