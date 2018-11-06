using System.Drawing;

namespace Game.StrategyPattern
{
    class Player2Movement : IMoveAlgorithm
    {
        private DebugLogSingleton _singleton;

        public Player2Movement()
        {
            _singleton = DebugLogSingleton.GetInstance();
        }

        public void Move(ref PointF position, int speed, ref bool isDead)
        {
            if (position.X >= 675 && position.X < 810 && position.Y == 0)
                position.X += speed;
            //second line down
            else if (position.X >= 810 && position.X < 835 && position.Y < 105)
                position.Y += speed;
            //third line right
            else if (position.X >= 810 && position.X < 935 && position.Y >= 105 && position.Y <= 125)
                position.X += speed;
            //fourth line up
            else if (position.X >= 935 && position.X <= 950 && position.Y > 0 && position.Y <= 125)
                position.Y -= speed;
            //fifth line right
            else if (position.X >= 935 && position.X <= 1055 && position.Y <= 0)
                position.X += speed;
            // sixth line down 
            else if (position.X > 1055 && position.X <= 1070 && position.Y < 210)
                position.Y += speed;
            // seventh line left
            else if (position.X > 940 && position.X <= 1085 && position.Y >= 210 && position.Y <= 225)
                position.X -= speed;
            // eight line down 
            else if (position.X <= 940 && position.Y >= 210 && position.Y < 390)
                position.Y += speed;
            // ninth line right 
            else if (position.X >= 925 && position.X < 1050 && position.Y >= 390)
                position.X += speed;
            // tenth line top 
            else if (position.X >= 1050 && position.X < 1065 && position.Y > 285 && position.Y <= 400)
                position.Y -= speed;
            // eleventh line left 
            else if (position.X >= 1050 && position.X < 1175 && position.Y >= 280)
                position.X += speed;
            // tvelve line down 
            else if (position.X >= 1175 && position.Y >= 280 && position.Y < 380)
                position.Y += speed;
            // last line left
            else if (position.X >= 1175 && position.X <= 1325 && position.Y >= 380)
                position.X += speed;

            if (position.X >= 1325 && position.Y >= 380)
            {
                isDead = true;
                _singleton.Log<IMoveAlgorithm>("Strategy", "Baloon finished moving strategy.");
            }
        }
    }
}
