namespace Arcade_Game
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            Timer = new System.Windows.Forms.Timer(components);
            playerScore = new Label();
            theCoins = new Label();
            silCoins = new Label();
            wavey = new Label();
            PowerUpPicBox = new PictureBox();
            PowerUpTimer = new Label();
            healthBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)PowerUpPicBox).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 20;
            Timer.Tick += TimerEvent;
            // 
            // playerScore
            // 
            playerScore.AutoSize = true;
            playerScore.BackColor = Color.Transparent;
            playerScore.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerScore.ForeColor = Color.Chartreuse;
            playerScore.Location = new Point(10, 52);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(114, 41);
            playerScore.TabIndex = 3;
            playerScore.Text = "Score : 0";
            // 
            // theCoins
            // 
            theCoins.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            theCoins.BackColor = Color.Transparent;
            theCoins.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            theCoins.ForeColor = Color.Gold;
            theCoins.Location = new Point(495, 17);
            theCoins.Name = "theCoins";
            theCoins.RightToLeft = RightToLeft.No;
            theCoins.Size = new Size(262, 34);
            theCoins.TabIndex = 4;
            theCoins.Text = "0 : Gold Coins";
            theCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // silCoins
            // 
            silCoins.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            silCoins.BackColor = Color.Transparent;
            silCoins.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            silCoins.ForeColor = Color.Silver;
            silCoins.Location = new Point(495, 51);
            silCoins.Name = "silCoins";
            silCoins.RightToLeft = RightToLeft.No;
            silCoins.Size = new Size(262, 34);
            silCoins.TabIndex = 5;
            silCoins.Text = "0 : Silver Coins";
            silCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wavey
            // 
            wavey.Anchor = AnchorStyles.Top;
            wavey.AutoSize = true;
            wavey.BackColor = Color.Transparent;
            wavey.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wavey.ForeColor = Color.Tomato;
            wavey.Location = new Point(319, 16);
            wavey.Name = "wavey";
            wavey.Size = new Size(150, 38);
            wavey.TabIndex = 6;
            wavey.Text = "WAVE 1";
            wavey.TextAlign = ContentAlignment.TopCenter;
            // 
            // PowerUpPicBox
            // 
            PowerUpPicBox.Anchor = AnchorStyles.Top;
            PowerUpPicBox.BackColor = Color.Transparent;
            PowerUpPicBox.Image = Properties.Resources.TrippleShotBulletPowerUp;
            PowerUpPicBox.Location = new Point(565, 17);
            PowerUpPicBox.Name = "PowerUpPicBox";
            PowerUpPicBox.Size = new Size(113, 82);
            PowerUpPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            PowerUpPicBox.TabIndex = 7;
            PowerUpPicBox.TabStop = false;
            PowerUpPicBox.Visible = false;
            // 
            // PowerUpTimer
            // 
            PowerUpTimer.Anchor = AnchorStyles.Top;
            PowerUpTimer.AutoSize = true;
            PowerUpTimer.BackColor = Color.Transparent;
            PowerUpTimer.Font = new Font("Century", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerUpTimer.ForeColor = Color.White;
            PowerUpTimer.Location = new Point(444, 38);
            PowerUpTimer.Name = "PowerUpTimer";
            PowerUpTimer.Size = new Size(107, 38);
            PowerUpTimer.TabIndex = 8;
            PowerUpTimer.Text = "label1";
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.Firebrick;
            healthBar.Location = new Point(19, 16);
            healthBar.Margin = new Padding(3, 2, 3, 2);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(116, 24);
            healthBar.TabIndex = 9;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = Properties.Resources.SpaceBackGround2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(767, 422);
            Controls.Add(healthBar);
            Controls.Add(PowerUpTimer);
            Controls.Add(wavey);
            Controls.Add(silCoins);
            Controls.Add(theCoins);
            Controls.Add(playerScore);
            Controls.Add(PowerUpPicBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Game";
            Text = "Space Invaders";
            FormClosing += Game_FormClosing;
            VisibleChanged += Game_VisibleChanged;
            KeyDown += Game_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PowerUpPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Timer Timer;
        private Label playerScore;
        private Label theCoins;
        private Label silCoins;
        private Label wavey;
        private PictureBox PowerUpPicBox;
        private Label PowerUpTimer;
        private Panel healthBar;
    }
}
