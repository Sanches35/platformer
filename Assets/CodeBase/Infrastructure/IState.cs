using System;

namespace CodeBase.Infrastructure
{
    public interface IState : IExitableState
    {
        void Enter();
    }
    
    public interface IPayloadedState<TPayLoad> : IExitableState
    {
        void Enter(TPayLoad payLoad);
    }

    public interface IExitableState
    {
        void Exit();
    }
}
    