using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FireGunGame
{
    public partial class Form1 : Form
    {
        MyClass GClass = new MyClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(FireGunGame.Resource1.load1);
            sp.Play();
            pictureBox1.Image = FireGunGame.Resource1.load;
            Spin.Enabled = true;
            GClass.LoadLogic();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(FireGunGame.Resource1.spin1);
            sp.Play();
            Load.Enabled = false;
            pictureBox1.Image = FireGunGame.Resource1.spin;
            GClass.SpinLogic();
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = FireGunGame.Resource1.shoot;
            SoundPlayer sp = new SoundPlayer(FireGunGame.Resource1.fire1);
            sp.Play();


            int chances = GClass.FireLogic();

            if (chances == 0)
            {
                FireAway.Enabled = false;
                Fire.Enabled = false;
                //you survived
                MessageBox.Show("you survived");
            }

            bool Lose = GClass.ReturnLose();
            if (Lose == true)
            {
                FireAway.Enabled = false;
                Fire.Enabled = false;
                MessageBox.Show("you are Dead");
            }
        }

        private void FireAway_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(FireGunGame.Resource1.fire1);
            sp.Play();
            int chances = GClass.FireAwayLogic();
            

            if (chances == 0)
            {

                FireAway.Enabled = false;
                Fire.Enabled = false;
                
                MessageBox.Show("opps!! you are dead");
            }

            bool survived = GClass.ReturnWin();
            if (survived == true)
            {
                FireAway.Enabled = false;
                Fire.Enabled = false;

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
