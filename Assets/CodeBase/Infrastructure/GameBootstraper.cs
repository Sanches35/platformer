using CodeBase.Logic;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstraper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;
        public LoadingScreen screen;

        private void Awake()
        {
            _game = new Game(this, screen);
            _game.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}