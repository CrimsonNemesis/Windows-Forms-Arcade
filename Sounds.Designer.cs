namespace Arcade_Game
{
    partial class Sounds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sounds));
            trackBarMusic = new TrackBar();
            trackBarSfx = new TrackBar();
            lblMusicVolume = new Label();
            label1 = new Label();
            lblSfxVolume = new Label();
            label3 = new Label();
            Backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSfx).BeginInit();
            SuspendLayout();
            // 
            // trackBarMusic
            // 
            trackBarMusic.BackColor = Color.Black;
            trackBarMusic.Location = new Point(274, 219);
            trackBarMusic.Margin = new Padding(3, 4, 3, 4);
            trackBarMusic.Maximum = 100;
            trackBarMusic.Name = "trackBarMusic";
            trackBarMusic.Size = new Size(550, 56);
            trackBarMusic.TabIndex = 0;
            trackBarMusic.TickStyle = TickStyle.Both;
            trackBarMusic.Value = 80;
            trackBarMusic.Scroll += trackBarMusic_Scroll;
            // 
            // trackBarSfx
            // 
            trackBarSfx.BackColor = Color.Black;
            trackBarSfx.Location = new Point(274, 387);
            trackBarSfx.Margin = new Padding(3, 4, 3, 4);
            trackBarSfx.Maximum = 100;
            trackBarSfx.Name = "trackBarSfx";
            trackBarSfx.Size = new Size(550, 56);
            trackBarSfx.TabIndex = 1;
            trackBarSfx.TickStyle = TickStyle.Both;
            trackBarSfx.Value = 80;
            trackBarSfx.Scroll += trackBarSfx_Scroll;
            // 
            // lblMusicVolume
            // 
            lblMusicVolume.AutoSize = true;
            lblMusicVolume.BackColor = Color.Transparent;
            lblMusicVolume.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMusicVolume.ForeColor = Color.White;
            lblMusicVolume.Location = new Point(81, 219);
            lblMusicVolume.Name = "lblMusicVolume";
            lblMusicVolume.Size = new Size(189, 41);
            lblMusicVolume.TabIndex = 2;
            lblMusicVolume.Text = "Music : 80 %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // lblSfxVolume
            // 
            lblSfxVolume.AutoSize = true;
            lblSfxVolume.BackColor = Color.Transparent;
            lblSfxVolume.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSfxVolume.ForeColor = Color.White;
            lblSfxVolume.Location = new Point(81, 387);
            lblSfxVolume.Name = "lblSfxVolume";
            lblSfxVolume.Size = new Size(202, 41);
            lblSfxVolume.TabIndex = 4;
            lblSfxVolume.Text = "Sounds : 80 %";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Kristen ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(158, 51);
            label3.Name = "label3";
            label3.Size = new Size(660, 65);
            label3.TabIndex = 5;
            label3.Text = "Music and  Sounds Options";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.LightGreen;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Ink Free", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(402, 475);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(175, 87);
            Backbtn.TabIndex = 6;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // Sounds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            ClientSize = new Size(914, 600);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(lblSfxVolume);
            Controls.Add(label1);
            Controls.Add(lblMusicVolume);
            Controls.Add(trackBarSfx);
            Controls.Add(trackBarMusic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Sounds";
            Text = "Sounds";
            FormClosing += Form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSfx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarMusic;
        private TrackBar trackBarSfx;
        private Label lblMusicVolume;
        private Label label1;
        private Label lblSfxVolume;
        private Label label3;
        private Button Backbtn;
    }
}