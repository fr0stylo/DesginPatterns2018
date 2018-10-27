using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.StrategyPattern
{
    class Player1Movement : IMoveAlgorithm
    {

        public void Move(ref PointF position, int speed,ref bool isDead)
        {
            if (position.X < 135 && position.Y == 0)
                position.X += speed;
            //second line down
            else if (position.X >= 135 && position.X <= 150 && position.Y < 105)
                position.Y += speed;
            //third line right
            else if (position.X >= 135 && position.X < 240 && position.Y >= 105 && position.Y <= 125)
                position.X += speed;
            //fourth line up
            else if (position.X >= 240 && position.X <= 255 && position.Y > 0 && position.Y <= 125)
                position.Y -= speed;
            //fifth line right
            else if (position.X >= 240 && position.X <= 365 && position.Y <= 0)
                position.X += speed;
            // sixth line down 
            else if (position.X > 365 && position.X <= 380 && position.Y < 210)
                position.Y += speed;
            // seventh line left
            else if (position.X > 240 && position.X <= 380 && position.Y >= 210 && position.Y <= 225)
                position.X -= speed;
            // eight line down 
            else if (position.X <= 240 && position.Y >= 210 && position.Y < 390)
                position.Y += speed;
            // ninth line right 
            else if (position.X > 230 && position.X < 365 && position.Y >= 390)
                position.X += speed;
            // tenth line top 
            else if (position.X >= 365 && position.X < 400 && position.Y > 285 && position.Y <= 400)
                position.Y -= speed;
            // eleventh line left 
            else if (position.X >= 365 && position.X < 490 && position.Y >= 280)
                position.X += speed;
            // tvelve line down 
            else if (position.X >= 490 && position.Y >= 280 && position.Y < 380)
                position.Y += speed;
            // last line left
            else if (position.X >= 490 && position.X <= 650 && position.Y >= 380)
                position.X += speed;

            if (position.X >= 650 && position.Y >= 380)
                isDead = true;
        }
    }
}
