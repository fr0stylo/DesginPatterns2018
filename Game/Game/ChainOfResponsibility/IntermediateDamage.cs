using Game.Entities;

namespace Game.ChainOfResponsibility
{
    public class IntermediateDamage : Chain
    {
        private Chain NextChain;
        private DebugLogSingleton _logSingleton;

        public IntermediateDamage()
        {
            _logSingleton = DebugLogSingleton.GetInstance();
        }

        public void SetNextChain(Chain nextChain)
        {
            NextChain = nextChain;
            
        }

        public void Calculate(Damage request)
        {
            if (request.AttackBaloon is IntermediateBaloon)
            {
                request.DamagedPlayer.DecreaseHealthPoints(-2);
                _logSingleton.Log<Chain>("ChainOfResponsibility", $"Intermediately damaging player : HP {request.DamagedPlayer.HealthPoints}");
            }
            else
            {
                NextChain.Calculate(request);
            }
        }
    }
}