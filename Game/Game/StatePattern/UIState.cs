namespace Game.StatePattern
{
    public abstract class UIState
    {
        public abstract bool CanSpawnBaloons();
        public abstract bool CanBuildTowers();
        public abstract void NextState(UIButtonsHandler buttonsHandler);
    }
}