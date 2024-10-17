using UnityEngine;

namespace CodeBase.Infrastructure
{
    public interface IGameFactory
    {
        GameObject CreatePlayer(Vector3 at);
        void CreateHud();
        GameObject CreateCamera(Vector3 at);
    }
}