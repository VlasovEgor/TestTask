using System;
using UnityEngine;
using Zenject;


public class PlayerMovement : MonoBehaviour, IInitializable, IDisposable
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;

    private InputSystem _inputSystem;
    private MovementArea _movementArea;


    [Inject]
    private void Construct(InputSystem inputSystem, MovementArea movementArea)
    {
        _inputSystem = inputSystem;
        _movementArea = movementArea;
    }

    public void Initialize()
    {
        _inputSystem.PlayerMoved += Move;
    }

    public void Dispose()
    {
        _inputSystem.PlayerMoved -= Move;
    }

    private void Move(Vector3 direction)
    {
        if (_movementArea.IsPlayerInArea(transform.position) == false)
        {
            return;
        }

        //transform.position += direction * Time.deltaTime * 20; //TODO SPEED

        _rigidbody2D.velocity = direction * _speed * Time.deltaTime;
    }
}