
namespace q1
{
    partial class Form_StandbyTime
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(297, 151);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(189, 91);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "time";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick_1);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.BackColor = System.Drawing.Color.Red;
            this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWait.ForeColor = System.Drawing.Color.White;
            this.lblWait.Location = new System.Drawing.Point(43, 51);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(601, 46);
            this.lblWait.TabIndex = 1;
            this.lblWait.Text = "Wait 5 seconds Wrong answer!";
            // 
            // Form_StandbyTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 298);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblTime);
            this.Name = "Form_StandbyTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standby time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblWait;
    }
}