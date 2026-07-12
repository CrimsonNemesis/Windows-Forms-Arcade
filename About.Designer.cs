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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(638, 76);
            button1.Name = "button1";
            button1.Size = new Size(133, 126);
            button1.TabIndex = 5;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Untitled_1___Copy;
            pictureBox1.Location = new Point(54, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 46);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(365, 78);
            label1.TabIndex = 7;
            label1.Text = "Created By Amir Reza Safari and \r\n           Sina Motamedi Nejad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 137);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(8, 2, 8, 2);
            label2.Size = new Size(169, 94);
            label2.TabIndex = 8;
            label2.Text = "Student \r\nCodes";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(470, 182);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 10, 1, 10);
            label3.Size = new Size(134, 49);
            label3.TabIndex = 9;
            label3.Text = "404522088";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(470, 137);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 10, 4, 10);
            label4.Size = new Size(134, 49);
            label4.TabIndex = 10;
            label4.Text = "404521426";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 274);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 30, 20, 30);
            label5.Size = new Size(712, 126);
            label5.TabIndex = 11;
            label5.Text = "Created By Microsoft Visual Studio , SQLite DB , Pixilart , \r\njsfxr , C# , Entity Framework and Generative AIs ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            Text = "About";
            FormClosing += Form_FormClosing;
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}