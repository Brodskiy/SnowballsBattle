using Assets.Scripts.GameManagers.GamePoints;
using Assets.Scripts.GameManagers.GameStatus;
using Assets.Scripts.Settings;
using UnityEngine;

namespace Assets.Scripts.IocContainer
{
    public class IocContainer : MonoBehaviour
    {
        [SerializeField] private SettingsGameModel _settingsGameModel;
        [SerializeField] private GamePointsData _gamePointsData;
        [SerializeField] private GameStatusData _gameStatusData;
        //[SerializeField] private GameElementsController _gameElementsController;

        public static IocContainer Instance { get; private set; }

        public IGameSettings Settings => _settingsGameModel;
        public IGamePoints Points => _gamePointsData;
        public IGameStatus GameStatus => _gameStatusData;
        //public IGameElemetsControl ElemetsControl => _gameElementsController;

        private IocContainer()
        {
        }

        private void Start()
        {
            Instance = this;
        }
    }
}