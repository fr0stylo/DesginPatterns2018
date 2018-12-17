namespace Game.StatePattern
{
    public class BuildingMode : UIState
    {
        public override bool CanSpawnBaloons()
        {
            return false;
        }

        public override bool CanBuildTowers()
        {
            return false;
        }
        
        public override void NextState(UIButtonsHandler buttonsHandler)
        {
            buttonsHandler.SetState(new SpawningMode());
        }
    }
}