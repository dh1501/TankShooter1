using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankShooter.General
{
    class Enum
    {
        public enum Direction {  eLeft, eRight, eUp, eDown }
        public enum BulletType { eNormalBullet, eRocketBullet, eUntiBullet, eLazeBullet}
        public enum ExplosionSize { eSmallEps, eBigEps}
        public enum EnemyTankType { eNormal, eMedium }
        public enum Skin { eS1, eS2, eS3, eS4, eS5}
        public enum PlayerSkin { ePlayerS1, ePlayerS2, ePlayerS3}
        public enum ItemType { eItemHeart, eItemShield, eItemGrenade, eItemRocket, eItemUpgrade}
        public enum  InfoStyle {eGameOver, eGameNext, eGameWin  }
        
    }
}

