namespace Game.ChainOfResponsibility
{
    public interface Chain
    {
        void SetNextChain(Chain nextChain);
        void Calculate(Damage request);
    }
}