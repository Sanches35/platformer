using UnityEngine;

namespace Data.Configs.Path
{
    [CreateAssetMenu(menuName = "Data/Configs/Path", fileName = "PathConfig")]
    public class PathConfig: ScriptableObject
    {
        public const string PlayerPath = "Player/Player";
        public const string CameraPath = "Camera/Camera";
        public const string HudPath = "Hud/Hud";
    }
}