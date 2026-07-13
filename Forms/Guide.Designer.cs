namespace Arcade_Game
{
    partial class Guide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Backbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Arrows;
            pictureBox1.Location = new Point(795, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.SpaceKey;
            pictureBox2.Location = new Point(795, 464);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Backbtn
            // 
            Backbtn.Anchor = AnchorStyles.Left;
            Backbtn.BackColor = Color.SpringGreen;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(184, 325);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(183, 83);
            Backbtn.TabIndex = 4;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Kristen ITC", 24F);
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(447, 198);
            label1.TabIndex = 5;
            label1.Text = "Use the ARROW keys to move the spaceship!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Kristen ITC", 24F);
            label2.Location = new Point(49, 481);
            label2.Name = "label2";
            label2.Size = new Size(447, 198);
            label2.TabIndex = 5;
            label2.Text = "Use the SPACE key to destroy your enemies!\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1137, 710);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Guide";
            Text = "Guides";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Backbtn;
        private Label label1;
        private Label label2;
    }
}