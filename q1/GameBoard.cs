using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace q1
{
    public partial class GameBoard : Form
    {
        Image[] animalPhotos;
        string[] animalNames;
        int photoIndex;
        int negativePoint = 3;
        Random rnd;

        public GameBoard(string name)
        {
            InitializeComponent();
            InitializeArrs();
            string hello = string.Format("hello {0}!",name);
            this.lbl_Name.Text = hello;
            string point = string.Format("Life :{0}", negativePoint);
            this.label2.Text = point;
            rnd = new Random();
            runGame();
        }

        private void InitializeArrs()
        {
            string[] animalsPath = File.ReadAllLines("PhotoPath.txt");
            animalPhotos = new Image[animalsPath.Length];
            animalNames = new string[animalsPath.Length];
            for (int i = 0; i < animalsPath.Length; i++)
            {
                string[] currAnimal = animalsPath[i].Split('.');
                animalNames[i] = currAnimal[0];
            }
            for (int i = 0; i < animalPhotos.Length; i++)
            {
                string currPath= string.Format(@"ANIMALS\{0}.png",animalNames[i]);
                animalPhotos[i] = Image.FromFile(currPath);
            }
        }


        private void runGame()
        {
            randPhoto();   
        }

        private void randPhoto()
        {
            this.photoIndex = rnd.Next(0,animalNames.Length);
            this.pictureBoxAnimal.Image = animalPhotos[photoIndex];

        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (txt_Answer.Text==animalNames[photoIndex])
            {
                MessageBox.Show("You succeeded! Continue to the next image.");
                txt_Answer.Text = string.Empty;
                runGame();
            }
            else
            {
                txt_Answer.Text = string.Empty;
                MessageBox.Show("wrong answer! Negative point.");
                negativePoint--;
                label2.Text=string.Format("Life :{0}", negativePoint);
                Form_StandbyTime sT = new Form_StandbyTime();
                sT.ShowDialog();
                if (negativePoint==0)
                {
                    MessageBox.Show("GAME-OVER!");
                    this.Close();
                }
                runGame();
            }
        }

        
    }
}
