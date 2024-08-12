using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    [SerializeField] private InputSystem _inputSystem;

    public override void InstallBindings()
    {
        BindInputSystem();
    }

    private void BindInputSystem()
    {
        Container.Bind<InputSystem>().FromInstance(_inputSystem).AsSingle();
    }
}
