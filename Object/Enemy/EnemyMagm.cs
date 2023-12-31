using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using TankShooter.General;
using TankShooter.Object;
using System.IO;
using static TankShooter.General.Enum;
using TankShooter.Object.Player;
using TankShooter.Objects;

namespace TankShooter.Object
{
    class EnemyMagm
    {
        private List<Enemy> enemyTanks;
        private List<EnemyPrmt> enemyPrmtTanks;
        private int numberEnemyTankDestroy;

        public EnemyMagm() 
        {
            EnemyTanks = new List<Enemy>();
            EnemyTankParameters = new List<EnemyPrmt>();
        }

        #region list tank enemy
        public void Init_EnemyTank(string path)
        {
            this.numberEnemyTankDestroy = 0;
            this.ReadEnemyTankParameters(path);
            this.CreateListEnemyTank();
        }
        public void EnemyTankClear()
        {
            this.enemyPrmtTanks.Clear();
            this.enemyTanks.Clear();
        }
        private void ReadEnemyTankParameters(string path)
        {
            string s = "";
            using (StreamReader reader = new StreamReader(path))
            {
                EnemyPrmt enemyTankParameter;
                while ((s = reader.ReadLine()) != null)
                {
                    string[] token = s.Split('#');
                    enemyTankParameter = new EnemyPrmt();
                    enemyTankParameter.Type = int.Parse(token[0]);
                    enemyTankParameter.Energy = int.Parse(token[1]);
                    enemyTankParameter.TankMoveSpeed = int.Parse(token[2]);
                    enemyTankParameter.TankBulletSpeed = int.Parse(token[3]);
                    enemyTankParameter.XEnemyTank = int.Parse(token[4]);
                    enemyTankParameter.YEnemyTank = int.Parse(token[5]);
                    enemyTankParameter.maxNumberEnemyTank = int.Parse(token[6]);
                    this.EnemyTankParameters.Add(enemyTankParameter);
                }
                enemyTankParameter = null;
                s = null;
            }
            //Console.WriteLine("Số lượng địch: " + this.enemyTankParameters.Count);
        }
        private void CreateListEnemyTank()
        {
            foreach (EnemyPrmt enemyTankParameter in EnemyTankParameters)
            {
                // thêm từng xe tăng địch vào danh sách
                this.EnemyTanks.Add(this.CreateOneEnemyTank(enemyTankParameter));
                // đếm số lượng địch cần tiêu diệt
                numberEnemyTankDestroy += enemyTankParameter.maxNumberEnemyTank;
            }
            //Console.WriteLine("Số lượng địch cần tiêu diệt: " + numberEnemyTankDestroy);
            //Console.WriteLine("Đã tạo " + this.NumberEnemyTank() + " xe tăng địch");
        }

        public Skin SkinEnemyTank(Enemy enemyTank)
        {
            switch (enemyTank.Power)
            {
                case 70:
                    // skin màu đỏ
                    return Skin.eS1;
                case 50:
                    // skin màu xanh cam
                    return Skin.eS2;
                case 30:
                    // skin màu xanh dương
                    return Skin.eS3;
                case 20:
                    // skin màu tím
                    return Skin.eS4;
            }
            return Skin.eS5;
        }
        private Enemy CreateOneEnemyTank(EnemyPrmt enemyTankParameter)
        {
            Enemy enemyTank;
            enemyTank = new Enemy();
            this.UpdateParameter(enemyTank, enemyTankParameter);
            return enemyTank;
        }
        #endregion list tank enemy

        #region manage list tank
        public void UpdateParameter(Enemy enemyTank, EnemyPrmt enemyTankParameter)
        {

            enemyTank.DirectionTank = Direction.eUp;
            enemyTank.IsMove = true;
            // thiết lập loại xe tăng (0: normal; 1: medium)
            switch (enemyTankParameter.Type)
            {
                case 0:
                    enemyTank.EnemyType = EnemyTankType.eNormal;
                    enemyTank.LoadImage(Common.path + @"\Images\tank0.png");
                    break;
                case 1:
                    enemyTank.EnemyType = EnemyTankType.eMedium;
                    enemyTank.LoadImage(Common.path + @"\Images\tank1.png");
                    break;
            }
            enemyTank.Power = enemyTankParameter.Energy;
            enemyTank.MoveSpeed = enemyTankParameter.TankMoveSpeed;
            enemyTank.BulletSpeed = enemyTankParameter.TankBulletSpeed;
            // update skin xe tăng địch khi biết năng lượng
            enemyTank.EnemySkinTank = this.SkinEnemyTank(enemyTank);
            enemyTank.RectX = enemyTankParameter.XEnemyTank * Common.STEP;
            enemyTank.RectY = enemyTankParameter.YEnemyTank * Common.STEP;
        }

        public void MoveAllEnemyTank(List<Wall> walls, PlayerTank playerTank)
        {
            bool isMove_local = false;
            foreach (Enemy enemyTank in EnemyTanks)
            {
                switch (enemyTank.EnemyType)
                {
                    case EnemyTankType.eNormal:
                        isMove_local = enemyTank.HandleMoveNormal(walls, playerTank, this.EnemyTanks);
                        break;
                    case EnemyTankType.eMedium:
                        isMove_local = enemyTank.HandleMoveMedium(walls, playerTank, this.EnemyTanks);
                        break;
                }
                // di chuyển xe tăng địch khi đã qua xử lí là đã được phép di chuyển
                if (isMove_local)
                    enemyTank.Move();
            }
        }
        public void ShowAllEnemyTank(Bitmap background)
        {
            foreach (Enemy enemyTank in EnemyTanks)
            {
                enemyTank.Show(background);
            }
        }
        public int NumberEnemyTank()
        {
            return this.numberEnemyTankDestroy;
        }
        #endregion manage list tank

        #region properties
        public List<Enemy> EnemyTanks
        {
            get
            {
                return enemyTanks;
            }

            set
            {
                enemyTanks = value;
            }
        }
        public List<EnemyPrmt> EnemyTankParameters
        {
            get
            {
                return enemyPrmtTanks;
            }

            set
            {
                enemyPrmtTanks = value;
            }
        }
        public int NumberEnemyTankDestroy
        {
            set { numberEnemyTankDestroy = value; }
            get { return numberEnemyTankDestroy; }
        }
        #endregion properties
    }
}
