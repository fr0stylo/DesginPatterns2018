namespace Game.StatePattern
{
    public class UIButtonsHandler
    {
        private DebugLogSingleton _logSingleton;
        private UIState _currentState;

        public UIButtonsHandler()
        {            
            _logSingleton = DebugLogSingleton.GetInstance();
            _currentState = new SpawningMode();
        }
        
        public void SetState(UIState state)
        {
            _currentState = state;
        }

        public bool CanSpawnBaloons()
        {
            return _currentState.CanSpawnBaloons();
        }
        
        public bool CanBuildTowers()
        {
            return _currentState.CanBuildTowers();
        }

        public void NextState()
        {
            _logSingleton.Log<UIButtonsHandler>("State", "Switching UI buttons state");
            _currentState.NextState(this);
        }
    }
}