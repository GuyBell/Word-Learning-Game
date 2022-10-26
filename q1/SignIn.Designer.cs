
namespace q1
{
    partial class form_SignIn
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.lbl_NewUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.Snow;
            this.lbl_UserName.Location = new System.Drawing.Point(28, 112);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(165, 42);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User name :";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_UserName.Location = new System.Drawing.Point(196, 118);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(272, 30);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_Password.Location = new System.Drawing.Point(196, 161);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(272, 30);
            this.txt_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Password.Location = new System.Drawing.Point(28, 154);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(149, 42);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login :";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Black;
            this.button_Login.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Login.Location = new System.Drawing.Point(49, 233);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(419, 50);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.Black;
            this.button_SignUp.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_SignUp.Location = new System.Drawing.Point(196, 288);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(273, 45);
            this.button_SignUp.TabIndex = 6;
            this.button_SignUp.Text = "SignUp";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // lbl_NewUser
            // 
            this.lbl_NewUser.AutoSize = true;
            this.lbl_NewUser.BackColor = System.Drawing.Color.Red;
            this.lbl_NewUser.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewUser.ForeColor = System.Drawing.Color.Snow;
            this.lbl_NewUser.Location = new System.Drawing.Point(51, 289);
            this.lbl_NewUser.Name = "lbl_NewUser";
            this.lbl_NewUser.Size = new System.Drawing.Size(129, 42);
            this.lbl_NewUser.TabIndex = 7;
            this.lbl_NewUser.Text = "New user";
            // 
            // form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.Controls.Add(this.lbl_NewUser);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "form_SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label lbl_NewUser;
    }
}