namespace Game.ChainOfResponsibility
{
    public class ChainLinker
    {
        private Chain _weakdamage;
        private Chain _intermediateDamage;
        private Chain _strongDamage;

        public ChainLinker()
        {
            _weakdamage = new WeakDamage();
            _intermediateDamage = new IntermediateDamage();
            _strongDamage = new StrongDamage();
            
            _weakdamage.SetNextChain(_intermediateDamage);
            _intermediateDamage.SetNextChain(_strongDamage);
        }

        public void DoCalculation(Damage request)
        {
            _weakdamage.Calculate(request);
        }
    }
}