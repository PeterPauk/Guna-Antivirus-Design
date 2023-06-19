namespace GunaUiAntivirus
{
    partial class Scanning
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
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleProgressBar2 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaCircleProgressBar3 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaCircleProgressBar4 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.SuspendLayout();
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(77, 26);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.ForestGreen;
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.SpringGreen;
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(157, 152);
            this.gunaCircleProgressBar1.TabIndex = 0;
            this.gunaCircleProgressBar1.Click += new System.EventHandler(this.gunaCircleProgressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaCircleProgressBar2
            // 
            this.gunaCircleProgressBar2.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.gunaCircleProgressBar2.IdleColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar2.IdleOffset = 20;
            this.gunaCircleProgressBar2.Image = null;
            this.gunaCircleProgressBar2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar2.Location = new System.Drawing.Point(393, 26);
            this.gunaCircleProgressBar2.Name = "gunaCircleProgressBar2";
            this.gunaCircleProgressBar2.ProgressMaxColor = System.Drawing.Color.ForestGreen;
            this.gunaCircleProgressBar2.ProgressMinColor = System.Drawing.Color.SpringGreen;
            this.gunaCircleProgressBar2.ProgressOffset = 20;
            this.gunaCircleProgressBar2.Size = new System.Drawing.Size(157, 152);
            this.gunaCircleProgressBar2.TabIndex = 1;
            // 
            // gunaCircleProgressBar3
            // 
            this.gunaCircleProgressBar3.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.gunaCircleProgressBar3.IdleColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar3.IdleOffset = 20;
            this.gunaCircleProgressBar3.Image = null;
            this.gunaCircleProgressBar3.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar3.Location = new System.Drawing.Point(727, 26);
            this.gunaCircleProgressBar3.Name = "gunaCircleProgressBar3";
            this.gunaCircleProgressBar3.ProgressMaxColor = System.Drawing.Color.ForestGreen;
            this.gunaCircleProgressBar3.ProgressMinColor = System.Drawing.Color.SpringGreen;
            this.gunaCircleProgressBar3.ProgressOffset = 20;
            this.gunaCircleProgressBar3.Size = new System.Drawing.Size(157, 152);
            this.gunaCircleProgressBar3.TabIndex = 2;
            // 
            // gunaCircleProgressBar4
            // 
            this.gunaCircleProgressBar4.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.gunaCircleProgressBar4.IdleColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar4.IdleOffset = 20;
            this.gunaCircleProgressBar4.Image = null;
            this.gunaCircleProgressBar4.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar4.Location = new System.Drawing.Point(1050, 26);
            this.gunaCircleProgressBar4.Name = "gunaCircleProgressBar4";
            this.gunaCircleProgressBar4.ProgressMaxColor = System.Drawing.Color.ForestGreen;
            this.gunaCircleProgressBar4.ProgressMinColor = System.Drawing.Color.SpringGreen;
            this.gunaCircleProgressBar4.ProgressOffset = 20;
            this.gunaCircleProgressBar4.Size = new System.Drawing.Size(157, 152);
            this.gunaCircleProgressBar4.TabIndex = 3;
            // 
            // Scanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1289, 698);
            this.Controls.Add(this.gunaCircleProgressBar4);
            this.Controls.Add(this.gunaCircleProgressBar3);
            this.Controls.Add(this.gunaCircleProgressBar2);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scanning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanning";
            this.Load += new System.EventHandler(this.Scanning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar2;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar3;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar4;
    }
}