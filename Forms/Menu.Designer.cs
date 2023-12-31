namespace TankShooter
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picIntr = new System.Windows.Forms.PictureBox();
            this.pictAbout = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.butLevel1 = new System.Windows.Forms.Button();
            this.butLevel2 = new System.Windows.Forms.Button();
            this.butLevel3 = new System.Windows.Forms.Button();
            this.butLevel4 = new System.Windows.Forms.Button();
            this.butLevel5 = new System.Windows.Forms.Button();
            this.butLevel6 = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.panelIntr = new System.Windows.Forms.Panel();
            this.butMenuIntr = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.butMenuAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelPlay.SuspendLayout();
            this.panelIntr.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlay.BackgroundImage")));
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPlay.InitialImage")));
            this.picPlay.Location = new System.Drawing.Point(157, 201);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(298, 114);
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picIntr
            // 
            this.picIntr.BackColor = System.Drawing.Color.Transparent;
            this.picIntr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIntr.BackgroundImage")));
            this.picIntr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIntr.InitialImage = ((System.Drawing.Image)(resources.GetObject("picIntr.InitialImage")));
            this.picIntr.Location = new System.Drawing.Point(157, 337);
            this.picIntr.Name = "picIntr";
            this.picIntr.Size = new System.Drawing.Size(298, 114);
            this.picIntr.TabIndex = 1;
            this.picIntr.TabStop = false;
            this.picIntr.Click += new System.EventHandler(this.picIntr_Click);
            // 
            // pictAbout
            // 
            this.pictAbout.BackColor = System.Drawing.Color.Transparent;
            this.pictAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictAbout.BackgroundImage")));
            this.pictAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictAbout.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictAbout.InitialImage")));
            this.pictAbout.Location = new System.Drawing.Point(157, 474);
            this.pictAbout.Name = "pictAbout";
            this.pictAbout.Size = new System.Drawing.Size(298, 114);
            this.pictAbout.TabIndex = 2;
            this.pictAbout.TabStop = false;
            this.pictAbout.Click += new System.EventHandler(this.pictAbout_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("picExit.InitialImage")));
            this.picExit.Location = new System.Drawing.Point(157, 611);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(298, 114);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlay.BackgroundImage")));
            this.panelPlay.Controls.Add(this.butMenu);
            this.panelPlay.Controls.Add(this.butLevel6);
            this.panelPlay.Controls.Add(this.butLevel5);
            this.panelPlay.Controls.Add(this.butLevel4);
            this.panelPlay.Controls.Add(this.butLevel3);
            this.panelPlay.Controls.Add(this.butLevel2);
            this.panelPlay.Controls.Add(this.butLevel1);
            this.panelPlay.Location = new System.Drawing.Point(624, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(625, 920);
            this.panelPlay.TabIndex = 4;
            // 
            // butLevel1
            // 
            this.butLevel1.BackColor = System.Drawing.Color.Orange;
            this.butLevel1.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel1.Location = new System.Drawing.Point(102, 201);
            this.butLevel1.Name = "butLevel1";
            this.butLevel1.Size = new System.Drawing.Size(182, 114);
            this.butLevel1.TabIndex = 0;
            this.butLevel1.Text = "LEVEL 1";
            this.butLevel1.UseVisualStyleBackColor = false;
            // 
            // butLevel2
            // 
            this.butLevel2.BackColor = System.Drawing.Color.Orange;
            this.butLevel2.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel2.Location = new System.Drawing.Point(319, 201);
            this.butLevel2.Name = "butLevel2";
            this.butLevel2.Size = new System.Drawing.Size(184, 114);
            this.butLevel2.TabIndex = 1;
            this.butLevel2.Text = "LEVEL 2";
            this.butLevel2.UseVisualStyleBackColor = false;
            // 
            // butLevel3
            // 
            this.butLevel3.BackColor = System.Drawing.Color.Orange;
            this.butLevel3.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel3.Location = new System.Drawing.Point(102, 337);
            this.butLevel3.Name = "butLevel3";
            this.butLevel3.Size = new System.Drawing.Size(182, 114);
            this.butLevel3.TabIndex = 2;
            this.butLevel3.Text = "LEVEL 3";
            this.butLevel3.UseVisualStyleBackColor = false;
            // 
            // butLevel4
            // 
            this.butLevel4.BackColor = System.Drawing.Color.Orange;
            this.butLevel4.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel4.Location = new System.Drawing.Point(319, 337);
            this.butLevel4.Name = "butLevel4";
            this.butLevel4.Size = new System.Drawing.Size(184, 114);
            this.butLevel4.TabIndex = 3;
            this.butLevel4.Text = "LEVEL 4";
            this.butLevel4.UseVisualStyleBackColor = false;
            // 
            // butLevel5
            // 
            this.butLevel5.BackColor = System.Drawing.Color.Orange;
            this.butLevel5.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel5.Location = new System.Drawing.Point(102, 474);
            this.butLevel5.Name = "butLevel5";
            this.butLevel5.Size = new System.Drawing.Size(182, 114);
            this.butLevel5.TabIndex = 4;
            this.butLevel5.Text = "LEVEL 5";
            this.butLevel5.UseVisualStyleBackColor = false;
            // 
            // butLevel6
            // 
            this.butLevel6.BackColor = System.Drawing.Color.Orange;
            this.butLevel6.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLevel6.Location = new System.Drawing.Point(319, 474);
            this.butLevel6.Name = "butLevel6";
            this.butLevel6.Size = new System.Drawing.Size(184, 114);
            this.butLevel6.TabIndex = 5;
            this.butLevel6.Text = "LEVEL 6";
            this.butLevel6.UseVisualStyleBackColor = false;
            // 
            // butMenu
            // 
            this.butMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMenu.BackColor = System.Drawing.Color.Orange;
            this.butMenu.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.Location = new System.Drawing.Point(221, 611);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(182, 114);
            this.butMenu.TabIndex = 6;
            this.butMenu.Text = "MENU";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // panelIntr
            // 
            this.panelIntr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIntr.BackgroundImage")));
            this.panelIntr.Controls.Add(this.butMenuIntr);
            this.panelIntr.Location = new System.Drawing.Point(0, 0);
            this.panelIntr.Name = "panelIntr";
            this.panelIntr.Size = new System.Drawing.Size(607, 882);
            this.panelIntr.TabIndex = 5;
            this.panelIntr.Visible = false;
            // 
            // butMenuIntr
            // 
            this.butMenuIntr.BackColor = System.Drawing.Color.DarkOrange;
            this.butMenuIntr.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenuIntr.Location = new System.Drawing.Point(194, 696);
            this.butMenuIntr.Name = "butMenuIntr";
            this.butMenuIntr.Size = new System.Drawing.Size(212, 46);
            this.butMenuIntr.TabIndex = 0;
            this.butMenuIntr.Text = "MENU";
            this.butMenuIntr.UseVisualStyleBackColor = false;
            this.butMenuIntr.Click += new System.EventHandler(this.butMenuIntr_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.butMenuAbout);
            this.panelAbout.Controls.Add(this.picAbout);
            this.panelAbout.Location = new System.Drawing.Point(0, 0);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(607, 879);
            this.panelAbout.TabIndex = 6;
            this.panelAbout.Visible = false;
            // 
            // picAbout
            // 
            this.picAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAbout.BackgroundImage")));
            this.picAbout.Location = new System.Drawing.Point(0, 0);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(607, 876);
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // butMenuAbout
            // 
            this.butMenuAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.butMenuAbout.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenuAbout.Location = new System.Drawing.Point(194, 636);
            this.butMenuAbout.Name = "butMenuAbout";
            this.butMenuAbout.Size = new System.Drawing.Size(231, 89);
            this.butMenuAbout.TabIndex = 1;
            this.butMenuAbout.Text = "MENU";
            this.butMenuAbout.UseVisualStyleBackColor = false;
            this.butMenuAbout.Click += new System.EventHandler(this.butMenuAbout_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 876);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelIntr);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pictAbout);
            this.Controls.Add(this.picIntr);
            this.Controls.Add(this.picPlay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelPlay.ResumeLayout(false);
            this.panelIntr.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picIntr;
        private System.Windows.Forms.PictureBox pictAbout;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Button butLevel1;
        private System.Windows.Forms.Button butLevel2;
        private System.Windows.Forms.Button butLevel6;
        private System.Windows.Forms.Button butLevel5;
        private System.Windows.Forms.Button butLevel4;
        private System.Windows.Forms.Button butLevel3;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Panel panelIntr;
        private System.Windows.Forms.Button butMenuIntr;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Button butMenuAbout;
        private System.Windows.Forms.PictureBox picAbout;
    }
}

