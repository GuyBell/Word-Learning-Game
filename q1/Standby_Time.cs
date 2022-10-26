using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q1
{
    public partial class Form_StandbyTime : Form
    {
        int seconds = 5;

        public Form_StandbyTime()
        {
            InitializeComponent();
            lblTime.Text = string.Format("{0}", seconds);
            tmrGame.Start();
        }

    

        private void tmrGame_Tick_1(object sender, EventArgs e)
        {
            seconds--;
            lblTime.Text = string.Format("{0}", seconds);
            if (seconds < 0)
            {
                tmrGame.Stop();
                Close();
            }
        }
    }
}
