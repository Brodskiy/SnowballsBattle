using Assets.Srripts.GameElements;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Sripts.PoolObject
{
    public class PoolObject : MonoBehaviour, IPoolable
    {
        [SerializeField] private GameElement _gameElement;
        [SerializeField] private int _numberToPool;

        public List<GameElement> AllGameElement { get; private set; }

        public void Initialization()
        {
            AllGameElement = new List<GameElement>();

            for (int i = 0; i < _numberToPool; i++)
            {
                var gameElement = GameObject.Instantiate(_gameElement) as GameElement;
                AllGameElement.Add(gameElement);
            }
        }

        public GameElement GetGameElement()
        {
            foreach (var element in AllGameElement)
            {
                if(element.IsActive == false)
                {
                    return element;
                }
            }
            return null;
        }        
    }
}
