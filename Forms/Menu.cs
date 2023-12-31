using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankShooter
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            panelPlay.Top = 0;
            panelPlay.Left = 0;
        }
        private void butMenu_Click(object sender, EventArgs e)
        {
            panelPlay.Top = 900;
            panelPlay.Left = 0;
        }

        private void picIntr_Click(object sender, EventArgs e)
        {
            panelIntr.Visible = true;
        }
        private void butMenuIntr_Click(object sender, EventArgs e)
        {
            panelIntr.Visible = false;
        }
       
        private void pictAbout_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
        }

        private void butMenuAbout_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = false;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
