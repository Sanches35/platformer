using System;
using UnityEngine;
using Cinemachine;

namespace CodeBase.CameraLogic
{
    
    public class CameraFollow : MonoBehaviour
    {
        private const string PlayerTag = "Player";
        private CinemachineVirtualCamera Camera;
        private Transform player;

        private void Awake()
        {
            Camera = GetComponent<CinemachineVirtualCamera>();
            player = GameObject.FindWithTag(PlayerTag).transform;
            Camera.Follow = player;
        }
    }
}