using Zenject;
using UnityEngine;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private MovementArea _movementArea;

    public override void InstallBindings()
    {
        BindMovementArea();
    }

    private void BindMovementArea()
    {
        Container.Bind<MovementArea>().FromInstance(_movementArea).AsSingle();
    }
}
