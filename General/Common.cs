using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using TankShooter.Object;

namespace TankShooter.General
{
    class Common
    {
        #region PARAMETER DECLARE
        public const int SCREEN_WIDTH = 1100;
        public const int SCREEN_HEIGHT = 900;
        public const int NUMBER_OBJECT_WIDTH = 45;
        public const int NUMBER_OBJECT_HEIGHT = 40;
        public const int MAX_LEVEL = 10;
        public const int STEP = 20;
        public const int tankSize = 40;
        #endregion

        public static string path;

        #region Bitmap processing
        public static Bitmap LoadImage (string fileName)
        {
            return new Bitmap(Common.path + fileName);
        }

        public static void PaintObject (Bitmap bmpBack, Bitmap front, int x, int y, int xFrame, int yFrame, int widthFrame, int heightFrame)
        {
            Graphics graphics = Graphics.FromImage(bmpBack);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawImage(front, x, y, new Rectangle(xFrame, yFrame, widthFrame, heightFrame), GraphicsUnit.Pixel);
            graphics.Dispose();
        }

        public static void PaintClear(Bitmap bmpBack)
        {
            Graphics g = Graphics.FromImage(bmpBack);
            g.Clear(Color.White);
            g.Dispose();
        }
        #endregion

        #region Matrix Processing
        public static int[,] ReadMap (string path, int numObjHeight, int numObjWidth)
        {
            int[,] arrayObj;
            string s = "";
            using (StreamReader reader = new StreamReader(path))
            {
                arrayObj = new int[numObjHeight, numObjWidth];
                for (int i = 0; i<numObjHeight; i++)
                {
                    s = reader.ReadLine();
                    for (int  j = 0; j<numObjWidth; j++)
                        arrayObj[i, j] = int.Parse(s[j].ToString());
                }
                return arrayObj;
            }
        }
        #endregion

        #region Collision Processing
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            // góc dưới phải
            if (rect1.Left > rect2.Left && rect1.Left < rect2.Right)
            {
                if (rect1.Top > rect2.Top && rect1.Top < rect2.Bottom)
                {
                    return true;
                }
            }
            // góc trên phải
            if (rect1.Left > rect2.Left && rect1.Left < rect2.Right)
            {
                if (rect1.Bottom > rect2.Top && rect1.Bottom < rect2.Bottom)
                {
                    return true;
                }
            }
            // góc dưới trái
            if (rect1.Right > rect2.Left && rect1.Right < rect2.Right)
            {
                if (rect1.Top > rect2.Top && rect1.Top < rect2.Bottom)
                {
                    return true;
                }
            }
            // góc trên trái
            if (rect1.Right > rect2.Left && rect1.Right < rect2.Right)
            {
                if (rect1.Bottom > rect2.Top && rect1.Bottom < rect2.Bottom)
                {
                    return true;
                }
            }
            //=============================================================
            // góc dưới phải
            if (rect2.Left > rect1.Left && rect2.Left < rect1.Right)
            {
                if (rect2.Top > rect1.Top && rect2.Top < rect1.Bottom)
                {
                    return true;
                }
            }
            // góc trên phải
            if (rect2.Left > rect1.Left && rect2.Left < rect1.Right)
            {
                if (rect2.Bottom > rect1.Top && rect2.Bottom < rect1.Bottom)
                {
                    return true;
                }
            }
            // góc dưới trái
            if (rect2.Right > rect1.Left && rect2.Right < rect1.Right)
            {
                if (rect2.Top > rect1.Top && rect2.Top < rect1.Bottom)
                {
                    return true;
                }
            }
            // góc trên trái
            if (rect2.Right > rect1.Left && rect2.Right < rect1.Right)
            {
                if (rect2.Bottom > rect1.Top && rect2.Bottom < rect1.Bottom)
                {
                    return true;
                }
            }
            //=============================================================
            if (rect1.Left == rect2.Left && rect1.Right == rect2.Right &&
                rect1.Top == rect2.Top && rect1.Bottom == rect2.Bottom)
                return true;
            return false;
        }
        #endregion
    }
}
