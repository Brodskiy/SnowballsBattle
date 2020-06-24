using Assets.Sripts.ScriptableObjects;
using Assets.Sripts.ScriptableObjects.GameElementContainer;
using Assets.Srripts.GameElements;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Sripts.PoolObject
{
    public class PoolObject : MonoBehaviour, IPoolable
    {
        [SerializeField] private GameElementContainer _gameElementContainer;

        public Dictionary<EGameElements, GameElement> AllGameElement { get; private set; }

        public void Initialization()
        {
            AllGameElement = new Dictionary<EGameElements, GameElement>();

            SetAllGameElement();
        }
        
        public GameElement GetGameElement(EGameElements eGameElements)
        {
            foreach (var element in AllGameElement)
            {
                if(element.Key == eGameElements)
                {
                    if (element.Value.IsActive == false)
                    {
                        return element.Value;
                    }                    
                }
            }
            return null;
        }

        private void SetAllGameElement()
        {
            foreach (var gameElement in _gameElementContainer.GetGameElementInfo)
            {
                for (int i = 0; i < gameElement.CountElement; i++)
                {
                    AllGameElement.Add(gameElement.NameGameElement, gameElement.ElementPrefab[i]);
                }                
            }
        }
    }
}