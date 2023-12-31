using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.AccessControl;
using TankShooter.General;

namespace TankShooter.Object
{
    class Base
    {
        protected Rectangle rect;
        protected Bitmap bmpObj;

        #region Detect Location
        public Rectangle Rect { get { return rect; } set { rect = value; }
        }

        public int RectX { get { return rect.X; } set { rect.X = value; } }

        public int RectY { get { return rect.Y; } set { rect.Y = value; } }

        public int RectWidth {  get { return rect.Width; } set { rect.Width = value;  } }

        public int RectHeight { get { return rect.Height; } set { rect.Height = value; } }

        #endregion

        #region Image Object
        public Bitmap BmpObj { 
            get { return bmpObj; } 
            set {  bmpObj = value; } 
        }
        public void LoadImage (string path)
        {
            this.bmpObj = new Bitmap (path);
        }

        public virtual void Show (Bitmap bmpBack)
        {
            Common.PaintObject(bmpBack, this.bmpObj, rect.X, rect.Y, 0, 0 , this.RectWidth, this.RectHeight);
        }
     
        #endregion
    }
}
