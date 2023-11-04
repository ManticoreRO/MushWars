namespace QDS.MushWars
{
    public enum GameScreens
    {
        MainMenu,
        Options,
        Intro,
        SelectMission,
        PlayGame,
        EndGame
    }

    public interface IScreenSystem
    {
        public void ShowScreen(GameScreens view, bool switchScreens = true);   
        public void HideScreen();
        public void HideAll();
    }
}