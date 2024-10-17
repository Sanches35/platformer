using CodeBase.Logic;
using Data.Configs.Player;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class LoadLevelState: IPayloadedState<string>
    {
        
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadingScreen _screen;
        private readonly IGameFactory _gameFactory;
        private readonly PlayerConfig _playerConfig;
        

        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingScreen screen)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _screen = screen;
        }
        

        public void Enter(string sceneName)
        {
            _screen.Show();
            _sceneLoader.Load(sceneName, OnLoaded);
        }

        public void Exit() => 
            _screen.Hide();

        private void OnLoaded()
        {
            GameObject player = _gameFactory.CreatePlayer(_playerConfig.GetInitialPoint());
            GameObject camera = _gameFactory.CreateCamera(_playerConfig.GetInitialPoint());

            _gameFactory.CreateHud();
            
            _stateMachine.Enter<GameLoopState>();
        }
        
    }
}