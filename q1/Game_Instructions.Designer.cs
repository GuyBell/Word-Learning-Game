
namespace q1
{
    partial class form_Game_Instructions
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
            this.lblin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblin.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblin.ForeColor = System.Drawing.Color.Bisque;
            this.lblin.Location = new System.Drawing.Point(229, 121);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(527, 35);
            this.lblin.TabIndex = 5;
            this.lblin.Text = ".במשחק זה השחקן יתרגל את הכתיבה באנגלית";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(44, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = ".יש לכתוב את שם החיה המופיעה בתמונה עם אות גדולה בהתחלה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(39, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "השחקן יתחיל עם 3 נק\' בחיים וכל פסילה, המשחק ייעצר ל-5 שניות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(380, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "!!והחיים ירדו בנק\' אחת, בהצלחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(376, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 59);
            this.label4.TabIndex = 9;
            this.label4.Text = ":הוראות המשחק";
            // 
            // form_Game_Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(779, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Game_Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}