using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using TankShooter.General;
using static TankShooter.General.Enum;

namespace TankShooter.Object.Explosion
{
    class Explosion:Base
    {
        #region const
        private const int maxFrameX = 5;
        private const int maxFrameY = 2;

        //trans frame
        private int framex = 0;
        private int framey = 0;
        #endregion

        private ExplosionSize explosionSize;
        private bool isExplosion;
        public override void Show(Bitmap bmpBack)
        {
            Common.PaintObject(bmpBack, this.bmpObj, this.RectX, this.RectY, 
                this.framex * this.RectWidth, this.framey * this.RectHeight, this.RectWidth, this.RectHeight);
            this.framex++;
            if (framex == maxFrameX)
            {
                framex = 0;
                framey++;
                if (framey == maxFrameY)
                {
                    this.isExplosion = false;
                }
            }
        }
        public bool IsExplosion
        {
            get
            {
                return isExplosion;
            }

            set
            {
                isExplosion = value;
            }
        }
        public ExplosionSize ExplosionSize
        {
            get
            {
                return explosionSize;
            }

            set
            {
                explosionSize = value;
            }
        }
    }
}
