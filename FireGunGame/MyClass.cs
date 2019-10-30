using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FireGunGame
{
    public class MyClass
    {
        
        int Bullet = 0;
        int SAChances = 2;
        int SChances = 4;
        bool Win = false;
        bool Lose = false;

        public void LoadLogic()
        {
            Bullet = 6;
        }

        public int SpinLogic()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7);
            return Bullet;

        }

        public int FireLogic()
        {

            if (Bullet == 1)
            {
                
                MessageBox.Show("Lose, You are Dead");
                Win = true;
            }
            
            else if (SChances > 1)


            {
                Bullet--;
                SChances--;
                MessageBox.Show("Keep Trying");
            }
            else
            {
                Bullet--;
                SChances--;
            }

            return SChances;
        }

        public int FireAwayLogic()
        {
            
            if (Bullet == 1)
            {
                
                MessageBox.Show("you survived");
                Win = true;
            }
            else if (SAChances > 1)
            {
                Bullet--;
                SAChances--;
                MessageBox.Show("Keep Trying");
            }
            else
            {
                Bullet--;
                SAChances--;
            }
            return SAChances;
        }

        public bool ReturnLose()
        {
            return Lose;
        }

        public bool ReturnWin()
        {
            return Win;
        }
    }
}

