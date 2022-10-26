
namespace q1
{
    partial class form_signUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password2 = new System.Windows.Forms.TextBox();
            this.lbl_Password2 = new System.Windows.Forms.Label();
            this.txt_UserName2 = new System.Windows.Forms.TextBox();
            this.lbl_UserName2 = new System.Windows.Forms.Label();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add a user :";
            // 
            // txt_Password2
            // 
            this.txt_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_Password2.Location = new System.Drawing.Point(203, 163);
            this.txt_Password2.Name = "txt_Password2";
            this.txt_Password2.Size = new System.Drawing.Size(272, 30);
            this.txt_Password2.TabIndex = 8;
            // 
            // lbl_Password2
            // 
            this.lbl_Password2.AutoSize = true;
            this.lbl_Password2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password2.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Password2.Location = new System.Drawing.Point(35, 156);
            this.lbl_Password2.Name = "lbl_Password2";
            this.lbl_Password2.Size = new System.Drawing.Size(149, 42);
            this.lbl_Password2.TabIndex = 7;
            this.lbl_Password2.Text = "Password :";
            // 
            // txt_UserName2
            // 
            this.txt_UserName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_UserName2.Location = new System.Drawing.Point(203, 120);
            this.txt_UserName2.Name = "txt_UserName2";
            this.txt_UserName2.Size = new System.Drawing.Size(272, 30);
            this.txt_UserName2.TabIndex = 6;
            // 
            // lbl_UserName2
            // 
            this.lbl_UserName2.AutoSize = true;
            this.lbl_UserName2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_UserName2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName2.ForeColor = System.Drawing.Color.Snow;
            this.lbl_UserName2.Location = new System.Drawing.Point(35, 114);
            this.lbl_UserName2.Name = "lbl_UserName2";
            this.lbl_UserName2.Size = new System.Drawing.Size(165, 42);
            this.lbl_UserName2.TabIndex = 5;
            this.lbl_UserName2.Text = "User name :";
            // 
            // button_AddUser
            // 
            this.button_AddUser.BackColor = System.Drawing.Color.Black;
            this.button_AddUser.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_AddUser.Location = new System.Drawing.Point(42, 235);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(433, 50);
            this.button_AddUser.TabIndex = 10;
            this.button_AddUser.Text = "Add";
            this.button_AddUser.UseVisualStyleBackColor = false;
            // 
            // form_signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password2);
            this.Controls.Add(this.lbl_Password2);
            this.Controls.Add(this.txt_UserName2);
            this.Controls.Add(this.lbl_UserName2);
            this.Name = "form_signUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password2;
        private System.Windows.Forms.Label lbl_Password2;
        private System.Windows.Forms.TextBox txt_UserName2;
        private System.Windows.Forms.Label lbl_UserName2;
        private System.Windows.Forms.Button button_AddUser;
    }
}