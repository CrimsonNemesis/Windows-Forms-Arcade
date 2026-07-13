namespace Arcade_Game
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
            startGame = new Button();
            Shop = new Button();
            about = new Button();
            Exit = new Button();
            option = new Button();
            pictureBox1 = new PictureBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startGame
            // 
            startGame.Anchor = AnchorStyles.Top;
            startGame.BackColor = Color.Lime;
            startGame.FlatStyle = FlatStyle.Popup;
            startGame.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            startGame.Location = new Point(567, 260);
            startGame.Name = "startGame";
            startGame.Size = new Size(168, 79);
            startGame.TabIndex = 0;
            startGame.Text = "Start";
            startGame.UseVisualStyleBackColor = false;
            startGame.Click += btnStart_Click;
            // 
            // Shop
            // 
            Shop.Anchor = AnchorStyles.Top;
            Shop.BackColor = Color.Yellow;
            Shop.FlatStyle = FlatStyle.Popup;
            Shop.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            Shop.Location = new Point(567, 345);
            Shop.Name = "Shop";
            Shop.Size = new Size(168, 79);
            Shop.TabIndex = 1;
            Shop.Text = "Shop";
            Shop.UseVisualStyleBackColor = false;
            Shop.Click += Shop_Click;
            // 
            // about
            // 
            about.Anchor = AnchorStyles.Top;
            about.BackColor = Color.DarkCyan;
            about.FlatStyle = FlatStyle.Flat;
            about.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            about.Location = new Point(567, 430);
            about.Name = "about";
            about.Size = new Size(168, 79);
            about.TabIndex = 2;
            about.Text = "About";
            about.UseVisualStyleBackColor = false;
            about.Click += about_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = Color.Tomato;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            Exit.Location = new Point(567, 682);
            Exit.Name = "Exit";
            Exit.Size = new Size(168, 79);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // option
            // 
            option.Anchor = AnchorStyles.Top;
            option.BackColor = Color.Thistle;
            option.FlatStyle = FlatStyle.Flat;
            option.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            option.Location = new Point(567, 514);
            option.Name = "option";
            option.Size = new Size(168, 79);
            option.TabIndex = 4;
            option.Text = "Options";
            option.UseVisualStyleBackColor = false;
            option.Click += option_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Title;
            pictureBox1.Location = new Point(360, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Top;
            Back.BackColor = Color.Coral;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Courier New", 22.2F, FontStyle.Bold);
            Back.Location = new Point(567, 598);
            Back.Margin = new Padding(3, 2, 3, 2);
            Back.Name = "Back";
            Back.Size = new Size(168, 79);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 562);
            Controls.Add(Back);
            Controls.Add(option);
            Controls.Add(Exit);
            Controls.Add(about);
            Controls.Add(Shop);
            Controls.Add(startGame);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            VisibleChanged += MainMenu_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startGame;
        private Button Shop;
        private Button about;
        private Button Exit;
        private Button option;
        private PictureBox pictureBox1;
        private Button Back;
    }
}