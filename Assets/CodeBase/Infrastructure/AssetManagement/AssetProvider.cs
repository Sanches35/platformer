using UnityEngine;

namespace CodeBase.Infrastructure.AssetManagement
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject Instantiate(string path)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab);
        }

        public GameObject Instantiate(string path, Vector3 pos)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab, pos, prefab.transform.rotation);
        }
    }
}