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
    public partial class form_SignIn : Form
    {
        Player[] arr_Player;

        private form_signUp form_signUp;

        public form_SignIn()
        {
            arr_Player = new Player[3];
            arr_Player[0] = new Player(123456789, "Moshe");
            arr_Player[1] = new Player(987654321, "Ron");
            arr_Player[2] = new Player(312127269, "Guy");
            InitializeComponent();
        }


        private void button_SignUp_Click(object sender, EventArgs e)
        {
            form_signUp = new form_signUp();
            form_signUp.MdiParent = form_MenuGame.ActiveForm;
            form_signUp.Button_AddUser.Click += Button_AddUser_Click;
            form_signUp.Show();
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(form_signUp.Txt_Password);
            string name = form_signUp.Txt_UserName;
            form_signUp.Close();
            Player playerToAdd = new Player(id,name);
            addNewPlayer(playerToAdd);
        }

        private void addNewPlayer(Player playerToAdd)
        {
            Player[] newArr_Player = new Player[arr_Player.Length+1];
            Array.Copy(arr_Player, newArr_Player, arr_Player.Length);
            newArr_Player[arr_Player.Length] = playerToAdd;
            arr_Player = newArr_Player;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool registered = false;
            for (int i = 0; i < arr_Player.Length; i++)
            {
                if (arr_Player[i].Id.ToString()==txt_Password.Text && arr_Player[i].Name==txt_UserName.Text )
                {
                    registered = true;
                }
            }
            if (registered)
            {
                GameBoard gB = new GameBoard(txt_UserName.Text);
                gB.MdiParent = form_MenuGame.ActiveForm;
                gB.Show();
                Close();
            }
            else
            {
                MessageBox.Show("One or more of the details are incorrect. \nIf you are not registered, please register for the game.");
            }
        }


    }
}
