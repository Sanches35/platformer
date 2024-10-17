using CodeBase.Logic;
using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine StateMachine;
        public static IInputService InputService;

        public Game(ICoroutineRunner coroutineRunner, LoadingScreen screen)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), screen);
            InputService = new StandaloneInputService();
        }
    }
}