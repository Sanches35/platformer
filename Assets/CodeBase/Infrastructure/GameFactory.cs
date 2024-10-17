using CodeBase.Infrastructure.AssetManagement;
using Data.Configs.Path;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameFactory : IGameFactory
    {

        private readonly IAssetProvider _assets;

        public GameFactory(IAssetProvider assets)
        {
            _assets = assets;
        }
        
        public GameObject CreatePlayer(Vector3 at)
        {
            return _assets.Instantiate(PathConfig.PlayerPath, pos: at);
        }

        public void CreateHud()
        {
            _assets.Instantiate(PathConfig.HudPath);
        }

        public GameObject CreateCamera(Vector3 at)
        {
            return _assets.Instantiate(PathConfig.CameraPath, pos: at);
        }
    }
}