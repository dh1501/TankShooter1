﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TankShooter.Object
{
    class EnemyPrmt
    {
        public int Type { set; get; }
        public int Energy { set; get; }
        public int TankMoveSpeed { set; get; }
        public int TankBulletSpeed { set; get; }
        public int XEnemyTank { set; get; }
        public int YEnemyTank { set; get; }
        public int maxNumberEnemyTank { set; get; }
    }
}
