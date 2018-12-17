namespace Game.StatePattern
{
    public class SpawningMode : UIState
    {
        public override bool CanSpawnBaloons()
        {
            return true;
        }

        public override bool CanBuildTowers()
        {
            return true;
        }

        public override void NextState(UIButtonsHandler buttonsHandler)
        {
            buttonsHandler.SetState(new BuildingMode());
        }
    }
}