using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using TankShooter.General;

namespace TankShooter.General
{
    class Sound
    {
        private static SoundPlayer startS;
        private static SoundPlayer nextLevelS;
        private static SoundPlayer gameOverS;
        private static SoundPlayer gameWinS;
        private static SoundPlayer clickRoomS;
        private static SoundPlayer hitByBulletS;
        private static SoundPlayer eatItemS;
        private static SoundPlayer lowAmmoEnergyS;
        private static SoundPlayer upradeS;
        private static SoundPlayer untiS;
        private static SoundPlayer easyLevelS;
        private static SoundPlayer highLevelS;

        public static void InitSound(String path)
        {
            Sound.startS          = new SoundPlayer(path + @"\Sounds\startS.wav");
            Sound.nextLevelS      = new SoundPlayer(path + @"\Sounds\nextLevelS.wav");
            Sound.gameOverS       = new SoundPlayer(path + @"\Sounds\gameOverS.wav");
            Sound.gameWinS        = new SoundPlayer(path + @"\Sounds\gameWinS.wav");
            Sound.clickRoomS      = new SoundPlayer(path + @"\Sounds\clickRoomS.wav");
            Sound.hitByBulletS    = new SoundPlayer(path + @"\Sounds\hitByBulletS.wav");
            Sound.eatItemS        = new SoundPlayer(path + @"\Sounds\eatItemS.wav");
            Sound.lowAmmoEnergyS  = new SoundPlayer(path + @"\Sounds\lowAmmoEnergyS.wav");
            Sound.upradeS         = new SoundPlayer(path + @"\Sounds\upradeS.wav"); ;
            Sound.untiS           = new SoundPlayer(path + @"\Sounds\eatItemS.wav"); ;
            Sound.easyLevelS      = new SoundPlayer(path + @"\Sounds\easyLevelS.wav"); ;
            Sound.highLevelS      = new SoundPlayer(path + @"\Sounds\highLevelS.wav"); ;
        }
        public static void PlayStartSound()
        {
            Sound.startS.Play();
        }
        public static void PlayNextLevelSound()
        {
            Sound.nextLevelS.Play();
        }
        public static void PlayGameOverSound() 
        {
            Sound.gameOverS.Play();

        }
        public static void PlayGameWinSound()
        {
            Sound.gameWinS.Play();
        }
        public static void PlayClickRoomSound()
        {
            Sound.clickRoomS.Play();
        }
        public static void PlayHitBulletSound()
        {
            Sound.hitByBulletS.Play();
        }
        public static void PlayEatItemSound() 
        {
            Sound.eatItemS.Play();
        }
        public static void PlaylowEnergySound()
        {
            Sound.lowAmmoEnergyS.Play();
        }
        public static void PlayUpgradeSound() 
        {
            Sound.upradeS.Play();
        }
        public static void PlayUntiSound()
        {
            Sound.untiS.Play();
        }
        public static void PlayEasyLevelSound()
        {
            Sound.easyLevelS.Play();
        }
        public static void PlayHighLevelSound()
        {
            Sound.highLevelS.Play();
        }

    }
}
