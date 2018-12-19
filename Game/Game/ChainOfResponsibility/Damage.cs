using Game.Entities;

namespace Game.ChainOfResponsibility
{
    public class Damage
    {
        public Baloon AttackBaloon { get; set; }
        public Player DamagedPlayer { get; set; }

        public Damage(Baloon bloon, Player playa)
        {
            AttackBaloon = bloon;
            DamagedPlayer = playa;
        }
    }
}