namespace Arcade_Game
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            Guidesbtn = new Button();
            Soundsbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Guidesbtn
            // 
            Guidesbtn.Anchor = AnchorStyles.Top;
            Guidesbtn.BackColor = Color.MediumTurquoise;
            Guidesbtn.BackgroundImageLayout = ImageLayout.None;
            Guidesbtn.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Guidesbtn.Location = new Point(324, 123);
            Guidesbtn.Name = "Guidesbtn";
            Guidesbtn.Size = new Size(183, 85);
            Guidesbtn.TabIndex = 0;
            Guidesbtn.Text = "Guides";
            Guidesbtn.UseVisualStyleBackColor = false;
            Guidesbtn.Click += Guidesbtn_Click;
            // 
            // Soundsbtn
            // 
            Soundsbtn.Anchor = AnchorStyles.None;
            Soundsbtn.BackColor = Color.SandyBrown;
            Soundsbtn.BackgroundImageLayout = ImageLayout.None;
            Soundsbtn.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Soundsbtn.Location = new Point(324, 231);
            Soundsbtn.Name = "Soundsbtn";
            Soundsbtn.Size = new Size(183, 85);
            Soundsbtn.TabIndex = 1;
            Soundsbtn.Text = "Sounds";
            Soundsbtn.UseVisualStyleBackColor = false;
            Soundsbtn.Click += Soundsbtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.LimeGreen;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Comic Sans MS", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 331);
            button1.Name = "button1";
            button1.Size = new Size(183, 86);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            ClientSize = new Size(800, 531);
            Controls.Add(button1);
            Controls.Add(Soundsbtn);
            Controls.Add(Guidesbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Options";
            Text = "Options";
            FormClosing += Options_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button Guidesbtn;
        private Button Soundsbtn;
        private Button button1;
    }
}