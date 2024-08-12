using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerMovement _playerMovement;

    public override void InstallBindings()
    {
        BindPlayerMovement();
    }

    private void BindPlayerMovement()
    {
        Container.BindInterfacesAndSelfTo<PlayerMovement>().FromInstance(_playerMovement).AsSingle();
    }
}
