using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerController controller;
    private CameraController cameraContoller;

    public PlayerInput.OnMovementActions onMovement;

    private void Awake()
    {
        playerInput = new PlayerInput();
        onMovement = playerInput.OnMovement;
        controller = GetComponent<PlayerController>();
        cameraContoller = GetComponent<CameraController>();
    }

    private void FixedUpdate()
    {
        controller.ProcessInput(onMovement.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        cameraContoller.ProcessLook(onMovement.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onMovement.Enable();
    }

    private void OnDisable()
    {
        onMovement.Disable();
    }
}
