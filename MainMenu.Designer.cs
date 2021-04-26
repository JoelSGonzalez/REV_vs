namespace REVOLUTION_continues
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Logo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rulesheet = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Label();
            this.Tutorial = new System.Windows.Forms.Label();
            this.Bomb1 = new System.Windows.Forms.Label();
            this.Bomb2 = new System.Windows.Forms.Label();
            this.Bomb3 = new System.Windows.Forms.Label();
            this.players3 = new System.Windows.Forms.Label();
            this.players4 = new System.Windows.Forms.Label();
            this.minibomb3 = new System.Windows.Forms.PictureBox();
            this.minibomb4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minibomb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minibomb4)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 202);
            this.Logo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 69);
            this.label2.TabIndex = 2;
            // 
            // Rulesheet
            // 
            this.Rulesheet.BackColor = System.Drawing.Color.Transparent;
            this.Rulesheet.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rulesheet.Image = ((System.Drawing.Image)(resources.GetObject("Rulesheet.Image")));
            this.Rulesheet.Location = new System.Drawing.Point(240, 330);
            this.Rulesheet.Name = "Rulesheet";
            this.Rulesheet.Size = new System.Drawing.Size(305, 135);
            this.Rulesheet.TabIndex = 2;
            this.Rulesheet.Tag = "2";
            this.Rulesheet.Text = "Rulesheet";
            this.Rulesheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rulesheet.Click += new System.EventHandler(this.RuleSheet_Click);
            this.Rulesheet.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Rulesheet.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Font = new System.Drawing.Font("Sitka Subheading", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(240, 195);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(305, 135);
            this.Play.TabIndex = 1;
            this.Play.Tag = "1";
            this.Play.Text = "PLAY";
            this.Play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            this.Play.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Play.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Tutorial
            // 
            this.Tutorial.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.Image = ((System.Drawing.Image)(resources.GetObject("Tutorial.Image")));
            this.Tutorial.Location = new System.Drawing.Point(240, 465);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(305, 135);
            this.Tutorial.TabIndex = 3;
            this.Tutorial.Tag = "3";
            this.Tutorial.Text = "Tutorial";
            this.Tutorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tutorial.Click += new System.EventHandler(this.Tutorial_Click);
            this.Tutorial.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Tutorial.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Bomb1
            // 
            this.Bomb1.BackColor = System.Drawing.Color.Transparent;
            this.Bomb1.Image = ((System.Drawing.Image)(resources.GetObject("Bomb1.Image")));
            this.Bomb1.Location = new System.Drawing.Point(170, 195);
            this.Bomb1.Name = "Bomb1";
            this.Bomb1.Size = new System.Drawing.Size(74, 135);
            this.Bomb1.TabIndex = 6;
            this.Bomb1.Tag = "1";
            this.Bomb1.Visible = false;
            // 
            // Bomb2
            // 
            this.Bomb2.BackColor = System.Drawing.Color.Transparent;
            this.Bomb2.Image = ((System.Drawing.Image)(resources.GetObject("Bomb2.Image")));
            this.Bomb2.Location = new System.Drawing.Point(170, 330);
            this.Bomb2.Name = "Bomb2";
            this.Bomb2.Size = new System.Drawing.Size(74, 135);
            this.Bomb2.TabIndex = 7;
            this.Bomb2.Tag = "2";
            this.Bomb2.Visible = false;
            // 
            // Bomb3
            // 
            this.Bomb3.BackColor = System.Drawing.Color.Transparent;
            this.Bomb3.Image = ((System.Drawing.Image)(resources.GetObject("Bomb3.Image")));
            this.Bomb3.Location = new System.Drawing.Point(170, 465);
            this.Bomb3.Name = "Bomb3";
            this.Bomb3.Size = new System.Drawing.Size(74, 135);
            this.Bomb3.TabIndex = 8;
            this.Bomb3.Tag = "3";
            this.Bomb3.Visible = false;
            // 
            // players3
            // 
            this.players3.BackColor = System.Drawing.Color.Transparent;
            this.players3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.players3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players3.Image = ((System.Drawing.Image)(resources.GetObject("players3.Image")));
            this.players3.Location = new System.Drawing.Point(553, 202);
            this.players3.Name = "players3";
            this.players3.Size = new System.Drawing.Size(160, 59);
            this.players3.TabIndex = 0;
            this.players3.Tag = "3";
            this.players3.Text = "3 PLAYERS";
            this.players3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.players3.Visible = false;
            this.players3.Click += new System.EventHandler(this.Players_Click);
            this.players3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.players3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // players4
            // 
            this.players4.BackColor = System.Drawing.Color.Transparent;
            this.players4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.players4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players4.Image = ((System.Drawing.Image)(resources.GetObject("players4.Image")));
            this.players4.Location = new System.Drawing.Point(553, 271);
            this.players4.Name = "players4";
            this.players4.Size = new System.Drawing.Size(160, 59);
            this.players4.TabIndex = 0;
            this.players4.Tag = "4";
            this.players4.Text = "4 PLAYERS";
            this.players4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.players4.Visible = false;
            this.players4.Click += new System.EventHandler(this.Players_Click);
            this.players4.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.players4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // minibomb3
            // 
            this.minibomb3.BackColor = System.Drawing.Color.Transparent;
            this.minibomb3.Image = ((System.Drawing.Image)(resources.GetObject("minibomb3.Image")));
            this.minibomb3.Location = new System.Drawing.Point(708, 202);
            this.minibomb3.Name = "minibomb3";
            this.minibomb3.Size = new System.Drawing.Size(39, 59);
            this.minibomb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minibomb3.TabIndex = 9;
            this.minibomb3.TabStop = false;
            this.minibomb3.Visible = false;
            // 
            // minibomb4
            // 
            this.minibomb4.BackColor = System.Drawing.Color.Transparent;
            this.minibomb4.Image = ((System.Drawing.Image)(resources.GetObject("minibomb4.Image")));
            this.minibomb4.Location = new System.Drawing.Point(708, 271);
            this.minibomb4.Name = "minibomb4";
            this.minibomb4.Size = new System.Drawing.Size(39, 59);
            this.minibomb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minibomb4.TabIndex = 10;
            this.minibomb4.TabStop = false;
            this.minibomb4.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 671);
            this.Controls.Add(this.minibomb4);
            this.Controls.Add(this.minibomb3);
            this.Controls.Add(this.players4);
            this.Controls.Add(this.players3);
            this.Controls.Add(this.Bomb3);
            this.Controls.Add(this.Bomb2);
            this.Controls.Add(this.Bomb1);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Rulesheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REVOLUTION";
            ((System.ComponentModel.ISupportInitialize)(this.minibomb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minibomb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rulesheet;
        private System.Windows.Forms.Label Play;
        private System.Windows.Forms.Label Tutorial;
        private System.Windows.Forms.Label Bomb1;
        private System.Windows.Forms.Label Bomb2;
        private System.Windows.Forms.Label Bomb3;
        private System.Windows.Forms.Label players3;
        private System.Windows.Forms.Label players4;
        private System.Windows.Forms.PictureBox minibomb3;
        private System.Windows.Forms.PictureBox minibomb4;
    }
}