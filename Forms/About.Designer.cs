namespace Arcade_Game
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            backButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackColor = Color.DarkSalmon;
            backButton.BackgroundImageLayout = ImageLayout.Center;
            backButton.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.Location = new Point(872, 38);
            backButton.Name = "backButton";
            backButton.Size = new Size(133, 118);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.IconPNG;
            pictureBox1.Location = new Point(32, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 97);
            label1.Margin = new Padding(10, 10, 10, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 10, 10, 10);
            label1.Size = new Size(424, 82);
            label1.TabIndex = 7;
            label1.Text = "Created By Amir Reza Safari and \r\n           Sina Motamedi Nejad";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 202);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(8, 2, 8, 2);
            label2.Size = new Size(228, 88);
            label2.TabIndex = 8;
            label2.Text = "Student \r\nCodes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(519, 202);
            label4.Margin = new Padding(10, 10, 10, 10);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 10, 4, 10);
            label4.Size = new Size(225, 48);
            label4.TabIndex = 10;
            label4.Text = "404521426";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 351);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 30, 20, 30);
            label5.Size = new Size(773, 123);
            label5.TabIndex = 11;
            label5.Text = "Created with Microsoft Visual Studio, SQLite DB, Pixilart, \r\njsfxr, C#, Entity Framework and Generative AIs ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.Aquamarine;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(519, 242);
            label6.Margin = new Padding(10, 10, 10, 10);
            label6.Name = "label6";
            label6.Padding = new Padding(4, 10, 4, 10);
            label6.Size = new Size(225, 48);
            label6.TabIndex = 10;
            label6.Text = "404522088";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1041, 497);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            Text = "About";
            FormClosing += About_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button backButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}