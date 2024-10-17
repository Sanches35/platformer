using CodeBase.Infrastructure;
using CodeBase.Services.Input;
using Data.Configs.Player;
using UnityEngine;

namespace CodeBase.Player
{
    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody2D;
        [SerializeField] private PlayerConfig _playerConfig;
        private IInputService _inputService;

        private void Awake()
        {
            _inputService = Game.InputService;
        }
        
        private void FixedUpdate()
        {
            rigidbody2D.velocity = new Vector2(_playerConfig.MovementSpeed * _inputService.Axis.x, rigidbody2D.velocity.y) * Time.fixedDeltaTime;
        }
        
    }
}