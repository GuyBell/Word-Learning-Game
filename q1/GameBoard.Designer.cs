
namespace q1
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnimal
            // 
            this.pictureBoxAnimal.BackColor = System.Drawing.Color.Black;
            this.pictureBoxAnimal.Location = new System.Drawing.Point(220, 31);
            this.pictureBoxAnimal.Name = "pictureBoxAnimal";
            this.pictureBoxAnimal.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnimal.TabIndex = 0;
            this.pictureBoxAnimal.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(12, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(160, 32);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "User name!";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.BackColor = System.Drawing.Color.Black;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_Answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Answer.Location = new System.Drawing.Point(59, 424);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(413, 29);
            this.lbl_Answer.TabIndex = 2;
            this.lbl_Answer.Text = "Try writing the name of the animal:";
            // 
            // txt_Answer
            // 
            this.txt_Answer.BackColor = System.Drawing.Color.White;
            this.txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_Answer.ForeColor = System.Drawing.Color.Black;
            this.txt_Answer.Location = new System.Drawing.Point(493, 424);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(237, 30);
            this.txt_Answer.TabIndex = 3;
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(320, 474);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(152, 41);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Check!";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(672, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Life : ";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(826, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBoxAnimal);
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnimal;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label label2;
    }
}