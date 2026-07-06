namespace Arcade_Game
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Timer = new System.Windows.Forms.Timer(components);
            pH = new Label();
            playerScore = new Label();
            theCoins = new Label();
            silCoins = new Label();
            wavey = new Label();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 20;
            Timer.Tick += TimerEvent;
            // 
            // pH
            // 
            pH.AutoSize = true;
            pH.BackColor = Color.Transparent;
            pH.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pH.ForeColor = Color.LightCoral;
            pH.Location = new Point(10, 18);
            pH.Name = "pH";
            pH.Size = new Size(154, 35);
            pH.TabIndex = 0;
            pH.Text = "Health Point : 3";
            // 
            // playerScore
            // 
            playerScore.AutoSize = true;
            playerScore.BackColor = Color.Transparent;
            playerScore.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerScore.ForeColor = Color.Chartreuse;
            playerScore.Location = new Point(10, 52);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(97, 35);
            playerScore.TabIndex = 3;
            playerScore.Text = "Score : 0";
            // 
            // theCoins
            // 
            theCoins.AutoSize = true;
            theCoins.BackColor = Color.Transparent;
            theCoins.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            theCoins.ForeColor = Color.Gold;
            theCoins.Location = new Point(1029, 16);
            theCoins.Name = "theCoins";
            theCoins.RightToLeft = RightToLeft.No;
            theCoins.Size = new Size(144, 35);
            theCoins.TabIndex = 4;
            theCoins.Text = "0 : Gold Coins";
            theCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // silCoins
            // 
            silCoins.AutoSize = true;
            silCoins.BackColor = Color.Transparent;
            silCoins.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            silCoins.ForeColor = Color.Silver;
            silCoins.Location = new Point(1029, 52);
            silCoins.Name = "silCoins";
            silCoins.RightToLeft = RightToLeft.No;
            silCoins.Size = new Size(150, 35);
            silCoins.TabIndex = 5;
            silCoins.Text = "0 : Silver Coins";
            silCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // wavey
            // 
            wavey.AutoSize = true;
            wavey.BackColor = Color.Transparent;
            wavey.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wavey.ForeColor = Color.Tomato;
            wavey.Location = new Point(544, 13);
            wavey.Name = "wavey";
            wavey.Size = new Size(150, 38);
            wavey.TabIndex = 6;
            wavey.Text = "WAVE 1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = Properties.Resources.SpaceBackGround2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 562);
            Controls.Add(wavey);
            Controls.Add(silCoins);
            Controls.Add(theCoins);
            Controls.Add(playerScore);
            Controls.Add(pH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Space Invaders";
            FormClosing += Form_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Timer Timer;
        private Label pH;
        private Label playerScore;
        private Label theCoins;
        private Label silCoins;
        private Label wavey;
    }
}
