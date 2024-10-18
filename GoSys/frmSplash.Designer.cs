namespace GoSys
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbCarrega = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCarrrega = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbCarrega
            // 
            this.pbCarrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbCarrega.ForeColor = System.Drawing.Color.DarkMagenta;
            this.pbCarrega.Location = new System.Drawing.Point(0, 289);
            this.pbCarrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCarrega.Name = "pbCarrega";
            this.pbCarrega.Size = new System.Drawing.Size(640, 12);
            this.pbCarrega.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCarrrega
            // 
            this.lbCarrrega.AutoSize = true;
            this.lbCarrrega.BackColor = System.Drawing.Color.Transparent;
            this.lbCarrrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarrrega.ForeColor = System.Drawing.Color.Cyan;
            this.lbCarrrega.Location = new System.Drawing.Point(415, 242);
            this.lbCarrrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCarrrega.Name = "lbCarrrega";
            this.lbCarrrega.Size = new System.Drawing.Size(27, 29);
            this.lbCarrrega.TabIndex = 2;
            this.lbCarrrega.Text = "0";
            this.lbCarrrega.Click += new System.EventHandler(this.lbCarrrega_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 310);
            this.Controls.Add(this.lbCarrrega);
            this.Controls.Add(this.pbCarrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbCarrega;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbCarrrega;
    }
}