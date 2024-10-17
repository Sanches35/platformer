using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Data.Configs.Player
{
    [CreateAssetMenu(menuName = "Data/Configs/Player", fileName = "PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] public Vector3 InitialPoint;
        [SerializeField] private float _movementSpeed = 500;
        
    public float MovementSpeed => _movementSpeed;
    public Vector3 GetInitialPoint() => InitialPoint;
    }
}