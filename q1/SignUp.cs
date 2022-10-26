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
    public partial class form_signUp : Form
    {
        public form_signUp()
        {
            InitializeComponent();
        }

        public Button Button_AddUser { get {return this.button_AddUser; }}

        public String Txt_UserName { get { return this.txt_UserName2.Text; } }

        public String Txt_Password { get { return this.txt_Password2.Text; } }

    }
}
