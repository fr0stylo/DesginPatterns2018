using Game.Entities;

namespace Game.ChainOfResponsibility
{
    public class WeakDamage : Chain
    {
        private Chain NextChain;
        private DebugLogSingleton _logSingleton;

        public WeakDamage()
        {
            _logSingleton = DebugLogSingleton.GetInstance();
        }

        public void SetNextChain(Chain nextChain)
        {
            throw new System.NotImplementedException();
        }

        public void Calculate(Damage request)
        {
            if (request.AttackBaloon is WeakBaloon)
            {
                request.DamagedPlayer.DecreaseHealthPoints(-1);
                _logSingleton.Log<Chain>("ChainOfResponsibility", $"Weakly damaging player : HP {request.DamagedPlayer.HealthPoints}");
            }
            else
            {
                NextChain.Calculate(request);
            }
        }
    }
}