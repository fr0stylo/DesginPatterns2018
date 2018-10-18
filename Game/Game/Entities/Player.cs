namespace Game.Entities
{
    public class Player
    {
        public string Name { get; }
        public int MoneyPoints { get; private set; }
        public int HealthPoints { get; private set; }


        public Player(string name)
        {
            Name = name;
            MoneyPoints = 1000;
            HealthPoints = 100;
        }

        public void DecreaseHealthPoints(int pointsToDecrease)
        {
            HealthPoints += pointsToDecrease;
        }

        public void AdjustMoneyPoints(int moneyAmount)
        {
            MoneyPoints += moneyAmount;
        }
    }
}