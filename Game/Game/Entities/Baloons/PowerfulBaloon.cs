﻿using Game.FactoryPattern;
using Game.Properties;
using Game.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    class PowerfulBaloon : Baloon
    {
        public readonly int health = 300;

        public readonly string type = "PowerfulBaloon";

        // don't go over 15 mate
        public readonly int speed = 15;

        public static Bitmap BaloonBitmap => Resources.BlackBaloon;

        public bool isPlayer1Baloon;

        public PowerfulBaloon(bool isPlayer1Baloon)
        {
            this.isPlayer1Baloon = isPlayer1Baloon;

            if (isPlayer1Baloon)
                moveStrategy = new Player1Movement();
            else
                moveStrategy = new Player2Movement();
        }
        public override int GetSpeed()
        {
            return speed;
        }

        public override string GetBaloonType()
        {
            return type;
        }

        public override PointF GetCurrentPosition()
        {
            return this.position;
        }

        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public override void Move()
        {
            moveStrategy.Move(ref position, speed,ref isDead);
        }


        public override bool GetIsDead()
        {
            return isDead;
        }

        public override void SetDead()
        {
            isDead = true;
        }
    }
}
