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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)PowerUpPicBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 20;
            Timer.Tick += TimerEvent;
            // 
            // playerScore
            // 
            playerScore.Anchor = AnchorStyles.Left;
            playerScore.AutoSize = true;
            playerScore.BackColor = Color.Transparent;
            playerScore.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerScore.ForeColor = Color.Chartreuse;
            playerScore.Location = new Point(3, 95);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(144, 49);
            playerScore.TabIndex = 3;
            playerScore.Text = "Score : 0";
            // 
            // theCoins
            // 
            theCoins.Anchor = AnchorStyles.Right;
            theCoins.BackColor = Color.Transparent;
            theCoins.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            theCoins.ForeColor = Color.Gold;
            theCoins.Location = new Point(920, 17);
            theCoins.Name = "theCoins";
            theCoins.RightToLeft = RightToLeft.No;
            theCoins.Size = new Size(244, 45);
            theCoins.TabIndex = 4;
            theCoins.Text = "0 : Gold Coins";
            theCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // silCoins
            // 
            silCoins.Anchor = AnchorStyles.Right;
            silCoins.BackColor = Color.Transparent;
            silCoins.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            silCoins.ForeColor = Color.Silver;
            silCoins.Location = new Point(920, 97);
            silCoins.Name = "silCoins";
            silCoins.RightToLeft = RightToLeft.No;
            silCoins.Size = new Size(244, 45);
            silCoins.TabIndex = 5;
            silCoins.Text = "0 : Silver Coins";
            silCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wavey
            // 
            wavey.Anchor = AnchorStyles.None;
            wavey.AutoSize = true;
            wavey.BackColor = Color.Transparent;
            wavey.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wavey.ForeColor = Color.Tomato;
            wavey.Location = new Point(491, 16);
            wavey.Name = "wavey";
            wavey.Size = new Size(185, 47);
            wavey.TabIndex = 6;
            wavey.Text = "WAVE 1";
            wavey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PowerUpPicBox
            // 
            PowerUpPicBox.Anchor = AnchorStyles.Left;
            PowerUpPicBox.BackColor = Color.Transparent;
            PowerUpPicBox.Image = Properties.Resources.TrippleShotBulletPowerUp;
            PowerUpPicBox.Location = new Point(820, 4);
            PowerUpPicBox.Margin = new Padding(3, 4, 3, 4);
            PowerUpPicBox.Name = "PowerUpPicBox";
            PowerUpPicBox.Size = new Size(94, 72);
            PowerUpPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            PowerUpPicBox.TabIndex = 7;
            PowerUpPicBox.TabStop = false;
            PowerUpPicBox.Visible = false;
            // 
            // PowerUpTimer
            // 
            PowerUpTimer.Anchor = AnchorStyles.Left;
            PowerUpTimer.AutoSize = true;
            PowerUpTimer.BackColor = Color.Transparent;
            PowerUpTimer.Font = new Font("Century", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerUpTimer.ForeColor = Color.White;
            PowerUpTimer.Location = new Point(720, 0);
            PowerUpTimer.Name = "PowerUpTimer";
            PowerUpTimer.Size = new Size(77, 80);
            PowerUpTimer.TabIndex = 8;
            PowerUpTimer.Text = "label1";
            PowerUpTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // healthBar
            // 
            healthBar.Anchor = AnchorStyles.Left;
            healthBar.BackColor = Color.Firebrick;
            healthBar.Location = new Point(15, 24);
            healthBar.Margin = new Padding(15, 3, 3, 3);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(133, 32);
            healthBar.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(healthBar, 0, 0);
            tableLayoutPanel1.Controls.Add(silCoins, 6, 1);
            tableLayoutPanel1.Controls.Add(PowerUpTimer, 4, 0);
            tableLayoutPanel1.Controls.Add(theCoins, 6, 0);
            tableLayoutPanel1.Controls.Add(playerScore, 0, 1);
            tableLayoutPanel1.Controls.Add(PowerUpPicBox, 5, 0);
            tableLayoutPanel1.Controls.Add(wavey, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.ForeColor = Color.Transparent;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1167, 160);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = Properties.Resources.SpaceBackGround2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 697);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Game";
            Text = "Space Invaders";
            VisibleChanged += Game_VisibleChanged;
            KeyDown += Game_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PowerUpPicBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
