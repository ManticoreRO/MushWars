using JetBrains.Annotations;
using QDS.MushWars;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace QDS.MushWars
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private ScreenConfig screenConfig;
        [SerializeField] private Camera mainCamera;
        [SerializeField] private MainMenuScreen mainMenuScreen;
        [SerializeField] private IntroScreen introScreen;
        [SerializeField] private SelectMissionScreen selectMissionScreen;
        [SerializeField] private PlayGameScreen playGameScreen;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GamePresenter>();

            builder.Register<PlayerStateSystem>(Lifetime.Singleton)
                .As<IPlayerStateSystem>();
            builder.Register<ScreenSystem>(Lifetime.Singleton)
                .As<IScreenSystem>()
                .WithParameter<ScreenConfig>(screenConfig);
            builder.Register<CameraSystem>(Lifetime.Singleton)
                .As<ICameraSystem>();
            builder.Register<EntitiesSystem>(Lifetime.Singleton)
                .As<IEntitiesSystem>();

            builder.RegisterComponentInHierarchy<Camera>();
            builder.RegisterComponent<MainMenuScreen>(mainMenuScreen).As<Screen>();
            builder.RegisterComponent<IntroScreen>(introScreen).As<Screen>();
            builder.RegisterComponent<SelectMissionScreen>(selectMissionScreen).As<Screen>();
            builder.RegisterComponent<PlayGameScreen>(playGameScreen).As<Screen>();
        }
    }
}
