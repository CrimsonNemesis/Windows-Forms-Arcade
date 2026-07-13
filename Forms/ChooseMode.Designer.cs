namespace Arcade_Game
{
    partial class ChooseMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseMode));
            NormMode = new Button();
            backBtn = new Button();
            PixMode = new Button();
            SuspendLayout();
            // 
            // NormMode
            // 
            NormMode.Anchor = AnchorStyles.Top;
            NormMode.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NormMode.Location = new Point(298, 58);
            NormMode.Margin = new Padding(3, 4, 3, 4);
            NormMode.Name = "NormMode";
            NormMode.Size = new Size(314, 128);
            NormMode.TabIndex = 0;
            NormMode.Text = "Normal Mode";
            NormMode.UseVisualStyleBackColor = true;
            NormMode.Click += NormMode_Click;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Bottom;
            backBtn.BackColor = Color.SpringGreen;
            backBtn.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.ActiveCaptionText;
            backBtn.Location = new Point(305, 447);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(307, 117);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // PixMode
            // 
            PixMode.Anchor = AnchorStyles.Top;
            PixMode.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PixMode.Location = new Point(298, 257);
            PixMode.Margin = new Padding(3, 4, 3, 4);
            PixMode.Name = "PixMode";
            PixMode.Size = new Size(314, 128);
            PixMode.TabIndex = 2;
            PixMode.Text = "Pixel Mode";
            PixMode.UseVisualStyleBackColor = true;
            PixMode.Click += PixMode_Click;
            // 
            // ChooseMode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(PixMode);
            Controls.Add(backBtn);
            Controls.Add(NormMode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseMode";
            Text = "choose";
            FormClosing += Form_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button NormMode;
        private Button backBtn;
        private Button PixMode;
    }
}