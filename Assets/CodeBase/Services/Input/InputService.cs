using UnityEngine;

namespace CodeBase.Services.Input
{
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Invincible = "Invincible";
        protected const string Vertical = "Vertical";

        public abstract Vector2 Axis { get; }

        public bool IsInvincibleButtonUp() =>
            UnityEngine.Input.GetButtonUp(Invincible);
    }

    public class StandaloneInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));

                return axis;
            }
        }
    }
}