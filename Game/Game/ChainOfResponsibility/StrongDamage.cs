using Game.Entities;

namespace Game.ChainOfResponsibility
{
    public class StrongDamage : Chain
    {
        private Chain NextChain;
        private DebugLogSingleton _logSingleton;

        public StrongDamage()
        {
            _logSingleton = DebugLogSingleton.GetInstance();
        }

        public void SetNextChain(Chain nextChain)
        {
            throw new System.NotImplementedException();
        }

        public void Calculate(Damage request)
        {
            if (request.AttackBaloon is PowerfulBaloon)
            {
                request.DamagedPlayer.DecreaseHealthPoints(-3);
                _logSingleton.Log<Chain>("ChainOfResponsibility", $"Powerfully damaging player : HP {request.DamagedPlayer.HealthPoints}");
            }
            else
            {
                NextChain.Calculate(request);
            }
        }
    }
}