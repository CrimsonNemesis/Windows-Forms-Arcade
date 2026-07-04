namespace Arcade_Game
{
    partial class Guides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guides));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            Backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.arrows;
            pictureBox1.Location = new Point(494, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Space;
            pictureBox2.Location = new Point(294, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(669, 279);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Kristen ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(51, 26);
            button1.Name = "button1";
            button1.Size = new Size(386, 146);
            button1.TabIndex = 2;
            button1.Text = "Use the ARROWS to move your spaceship !";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Kristen ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(51, 255);
            button2.Name = "button2";
            button2.Size = new Size(386, 169);
            button2.TabIndex = 3;
            button2.Text = "And use the SPACE key to destroy your enemies !";
            button2.UseVisualStyleBackColor = false;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.SpringGreen;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(176, 184);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(160, 62);
            Backbtn.TabIndex = 4;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // Guides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Guides";
            Text = "Guides";
            FormClosing += Form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button Backbtn;
    }
}