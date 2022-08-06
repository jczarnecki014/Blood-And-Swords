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
            this.UserItemPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SkipFightButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsPictureBox)).BeginInit();
            this.MenuPanel.SuspendLayout();
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
            this.vsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.vsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vsPictureBox.Image")));
            this.vsPictureBox.Location = new System.Drawing.Point(794, 120);
            this.vsPictureBox.Name = "vsPictureBox";
            this.vsPictureBox.Size = new System.Drawing.Size(400, 220);
            this.vsPictureBox.TabIndex = 2;
            this.vsPictureBox.TabStop = false;
            // 
            // UserItemPanel
            // 
            this.UserItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.UserItemPanel.Location = new System.Drawing.Point(90, 518);
            this.UserItemPanel.Name = "UserItemPanel";
            this.UserItemPanel.Size = new System.Drawing.Size(400, 80);
            this.UserItemPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(1414, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 80);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(490, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 249);
            this.panel2.TabIndex = 4;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))), ((int)(((byte)(84)))));
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuPanel.Controls.Add(this.CloseButton);
            this.MenuPanel.Controls.Add(this.SkipFightButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1904, 65);
            this.MenuPanel.TabIndex = 5;
            // 
            // SkipFightButton
            // 
            this.SkipFightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.SkipFightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipFightButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipFightButton.Location = new System.Drawing.Point(1780, 10);
            this.SkipFightButton.Name = "SkipFightButton";
            this.SkipFightButton.Size = new System.Drawing.Size(110, 34);
            this.SkipFightButton.TabIndex = 0;
            this.SkipFightButton.Text = "Skip Fight";
            this.SkipFightButton.UseVisualStyleBackColor = false;
            this.SkipFightButton.Click += new System.EventHandler(this.SkipFightButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(10, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 34);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FighArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserItemPanel);
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
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox UserPictureBox;
        private PictureBox EnemyPictureBox;
        private PictureBox vsPictureBox;
        private Panel UserItemPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel MenuPanel;
        private Button SkipFightButton;
        private Button CloseButton;
    }
}