using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankShooter.Object;

namespace TankShooter.Objects
{
    class Wall : Base
    {
        private int wallNumber;

        public int WallNumber
        {
            get
            {
                return wallNumber;
            }

            set
            {
                wallNumber = value;
            }
        }
    }
}
