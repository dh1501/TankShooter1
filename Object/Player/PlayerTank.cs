using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using TankShooter.General;
using System.Windows.Forms;
using TankShooter.Object.General;
using static TankShooter.General.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TankShooter.Object.Player
{
    class PlayerTank : Tank
    {
        private bool isShield;
        private Bitmap bmpShield;
        int levelTank = 0;
        //int skinTank = 0;
        bool openSkill1 = true; //laze
        bool openSkill2 = false; //tang toc
        bool openSkill3 = false; //unti

        public PlayerTank()
        {
            switch (this.levelTank)
            {
                case 0:
                    this.moveSpeed = 10;
                    this.bulletSpeed = 20;
                    this.power = 100;
                    this.SetLocation();
                    this.DirectionTank = Direction.eUp;
                    this.PlayerSkinTank = PlayerSkin.ePlayerS1;
                    bmpEffect = new Bitmap(Common.path + @"\Images\effect1.png");
                    bmpShield = new Bitmap(Common.path + @"\Images\shield.png");
                    break;
                case 1:
                    this.moveSpeed = 10;
                    this.bulletSpeed = 25;
                    this.power = 120;
                    this.SetLocation();
                    //this.DirectionTank = Direction.eUp;
                    this.PlayerSkinTank = PlayerSkin.ePlayerS2;
                    openSkill2 = true; //tang toc
                    bmpEffect = new Bitmap(Common.path + @"\Images\effect1.png");
                    bmpShield = new Bitmap(Common.path + @"\Images\shield.png");
                    break;
                case 2:
                    this.moveSpeed = 15;
                    this.bulletSpeed = 25;
                    this.power = 130;
                    this.SetLocation();
                    //this.DirectionTank = Direction.eUp;
                    this.PlayerSkinTank = PlayerSkin.ePlayerS3;
                    openSkill3 = true; //unti
                    bmpEffect = new Bitmap(Common.path + @"\Images\effect1.png");
                    bmpShield = new Bitmap(Common.path + @"\Images\shield.png");
                    break;
                case 3:
                    this.levelTank = 2;
                    break;
            }
        }
        public void SetLocation()
        {
            int i = 17, j = 36;
            this.RectX = i * Common.STEP;
            this.RectY = j * Common.STEP;
        }
        public bool IsEnemyTankCollisions(List<Enemy> enemyTanks)
        {
            foreach (Enemy enemyTank in enemyTanks)
            {
                if (this.IsCollision(enemyTank.Rect))
                    return true;
            }
            return false;
        }
        public override void Show(Bitmap bg)
        {
            if (IsActivate)
            {
                switch (directionTank)
                {
                    case Direction.eUp:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y, (int)skinTank * Common.tankSize,
                            frTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                    case Direction.eDown:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y,
                               (MAX_NUMBER_TANK - (int)skinTank) * Common.tankSize, frTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                    case Direction.eLeft:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y,
                                 frTank * Common.tankSize, (MAX_NUMBER_TANK - (int)skinTank) * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                    case Direction.eRight:
                        Common.PaintObject(bg, this.bmpObj, rect.X, rect.Y,
                            frTank * Common.tankSize, (int)skinTank * Common.tankSize, this.RectWidth, this.RectHeight);
                        break;
                }
                if (this.isShield)
                {
                    Common.PaintObject(bg, this.bmpShield, rect.X, rect.Y, 0, 0, 40, 40);
                }
                if (this.isMove)
                {
                    frTank--;
                    if (frTank == -1)
                        frTank = MAX_NUMBER_TANK;
                }
            }
            else
            {
                // hiển thị hiệu ứng xuất hiện
                Common.PaintObject(bg, this.bmpEffect, this.RectX, this.RectY,
                       frXEffect * this.RectWidth, frYEffect * this.RectHeight, this.RectWidth, this.RectHeight);
                frYEffect++;
                if (frYEffect == MAX_NUMBER_EFFECT)
                {
                    frXEffect = 0;
                    frYEffect++;
                    if (frYEffect == MAX_NUMBER_EFFECT)
                    {
                        frYEffect = 0;
                        // hiệu ứng kết thúc, bật lại hoạt động của xe
                        IsActivate = true;
                    }
                }
            }
        }
        public bool IsShield
        {
            get { return isShield; }
            set { isShield = value; }
        }
    }
   
}
