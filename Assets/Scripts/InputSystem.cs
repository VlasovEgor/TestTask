using System;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public event Action<Vector3> PlayerMoved;

    private MovementInput _input;

    private void Awake()
    {
        _input = new MovementInput();
        _input.Enable();
    }

    private void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {   
        var inputDirection = _input.Gameplay.Movement.ReadValue<Vector2>();
        var direction = new Vector3(inputDirection.x, inputDirection.y, 0);
        PlayerMoved?.Invoke(direction);
    }
}
