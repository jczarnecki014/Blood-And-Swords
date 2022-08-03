namespace Blood_and_Swords.FORMS
{
    partial class FighArena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FighArena));
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.vsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.Location = new System.Drawing.Point(90, 90);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(400, 400);
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EnemyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyPictureBox.Location = new System.Drawing.Point(1414, 90);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(400, 400);
            this.EnemyPictureBox.TabIndex = 1;
            this.EnemyPictureBox.TabStop = false;
            // 
            // vsPictureBox
            // 
            this.vsPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vsPictureBox.Image")));
            this.vsPictureBox.Location = new System.Drawing.Point(784, 169);
            this.vsPictureBox.Name = "vsPictureBox";
            this.vsPictureBox.Size = new System.Drawing.Size(400, 220);
            this.vsPictureBox.TabIndex = 2;
            this.vsPictureBox.TabStop = false;
            // 
            // FighArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.vsPictureBox);
            this.Controls.Add(this.EnemyPictureBox);
            this.Controls.Add(this.UserPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FighArena";
            this.Text = "FighArena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FighArena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox UserPictureBox;
        private PictureBox EnemyPictureBox;
        private PictureBox vsPictureBox;
    }
}