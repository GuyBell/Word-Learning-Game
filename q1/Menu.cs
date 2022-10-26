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
    public partial class form_MenuGame : Form
    {
        private form_SignIn form_SignIn;

        public form_MenuGame()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Game_Instructions gI = new form_Game_Instructions();
            gI.MdiParent = form_MenuGame.ActiveForm;
            gI.Show();
        }


        private void Exit_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_SignIn = new form_SignIn();
            form_SignIn.MdiParent = form_MenuGame.ActiveForm;
            form_SignIn.Show();
        }


    }
}
