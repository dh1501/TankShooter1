using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankShooter.General;
using static TankShooter.General.Enum;

namespace TankShooter.Object.Environment
{
    class Item:Base
    {
        #region const
        private const int x_default = -20;
        private const int y_default = -20;
        #endregion

        private bool isOn;
        private ItemType itemType;

        public Item() 
        {
            this.RectX = x_default;
            this.RectY = y_default;
            this.RectWidth = this.RectHeight = Common.tankSize;
            isOn = false;
        }

        public void CreateItem(Point itemPoint)
        {
            this.RectX = itemPoint.X;
            this.RectY = itemPoint.Y;
            Random random = new Random();
            switch (random.Next(0, 4))
            {
                case 0:
                    this.ItemType = ItemType.eItemHeart;
                    this.LoadImage(Common.path + @"\Images\icon_heart.png");
                    break;
                case 1:
                    this.ItemType = ItemType.eItemShield;
                    this.LoadImage(Common.path + @"\Images\icon_shield.png");
                    break;
                case 2:
                    this.ItemType = ItemType.eItemGrenade;
                    this.LoadImage(Common.path + @"\Images\icon_grenade.png");
                    break;
                case 3:
                    this.ItemType = ItemType.eItemRocket;
                    this.LoadImage(Common.path + @"\Images\icon_rocket.png");
                    break;
                case 4:
                    Random rd = new Random();
                    if (rd.Next(0, 6) == 3) { 
                        this.ItemType = ItemType.eItemUpgrade;
                        this.LoadImage(Common.path + @"\Images\icon_upgrade.png");
                    }
                    break;
            }
            random = null;
           
        }
        public ItemType ItemType
        {
            get
            {
                return itemType;
            }

            set
            {
                itemType = value;
            }
        }
        public bool IsOn
        {
            get
            {
                return isOn;
            }

            set
            {
                isOn = value;
            }
        }
    }
}
