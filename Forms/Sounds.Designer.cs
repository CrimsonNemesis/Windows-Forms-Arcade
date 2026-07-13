namespace Arcade_Game
{
    partial class Sounds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sounds));
            trackBarMusic = new TrackBar();
            trackBarSfx = new TrackBar();
            lblMusicVolume = new Label();
            label1 = new Label();
            lblSfxVolume = new Label();
            label3 = new Label();
            Backbtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSfx).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // trackBarMusic
            // 
            trackBarMusic.Anchor = AnchorStyles.None;
            trackBarMusic.BackColor = Color.Black;
            trackBarMusic.Location = new Point(352, 236);
            trackBarMusic.Margin = new Padding(3, 4, 3, 4);
            trackBarMusic.Maximum = 100;
            trackBarMusic.Name = "trackBarMusic";
            trackBarMusic.Size = new Size(481, 45);
            trackBarMusic.TabIndex = 0;
            trackBarMusic.TickStyle = TickStyle.Both;
            trackBarMusic.Value = 80;
            trackBarMusic.Scroll += trackBarMusic_Scroll;
            // 
            // trackBarSfx
            // 
            trackBarSfx.Anchor = AnchorStyles.None;
            trackBarSfx.BackColor = Color.Black;
            trackBarSfx.Location = new Point(352, 412);
            trackBarSfx.Margin = new Padding(3, 4, 3, 4);
            trackBarSfx.Maximum = 100;
            trackBarSfx.Name = "trackBarSfx";
            trackBarSfx.Size = new Size(481, 45);
            trackBarSfx.TabIndex = 1;
            trackBarSfx.TickStyle = TickStyle.Both;
            trackBarSfx.Value = 80;
            trackBarSfx.Scroll += trackBarSfx_Scroll;
            // 
            // lblMusicVolume
            // 
            lblMusicVolume.Anchor = AnchorStyles.Right;
            lblMusicVolume.AutoSize = true;
            lblMusicVolume.BackColor = Color.Transparent;
            lblMusicVolume.Font = new Font("Monotype Corsiva", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMusicVolume.ForeColor = Color.White;
            lblMusicVolume.Location = new Point(31, 237);
            lblMusicVolume.Name = "lblMusicVolume";
            lblMusicVolume.Size = new Size(194, 43);
            lblMusicVolume.TabIndex = 2;
            lblMusicVolume.Text = "Music : 80 %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // lblSfxVolume
            // 
            lblSfxVolume.Anchor = AnchorStyles.Right;
            lblSfxVolume.AutoSize = true;
            lblSfxVolume.BackColor = Color.Transparent;
            lblSfxVolume.Font = new Font("Monotype Corsiva", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSfxVolume.ForeColor = Color.White;
            lblSfxVolume.Location = new Point(16, 413);
            lblSfxVolume.Name = "lblSfxVolume";
            lblSfxVolume.Size = new Size(207, 43);
            lblSfxVolume.TabIndex = 4;
            lblSfxVolume.Text = "Sounds : 80 %";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Kristen ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(297, 55);
            label3.Name = "label3";
            label3.Size = new Size(521, 51);
            label3.TabIndex = 5;
            label3.Text = "Music and  Sounds Options";
            // 
            // Backbtn
            // 
            Backbtn.Anchor = AnchorStyles.None;
            Backbtn.BackColor = Color.LightGreen;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Ink Free", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.Location = new Point(41, 574);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(192, 85);
            Backbtn.TabIndex = 6;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tableLayoutPanel1.Controls.Add(Backbtn, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(trackBarSfx, 1, 2);
            tableLayoutPanel1.Controls.Add(lblSfxVolume, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMusicVolume, 0, 1);
            tableLayoutPanel1.Controls.Add(trackBarMusic, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1254, 706);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Sounds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            ClientSize = new Size(1254, 706);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Sounds";
            Text = "Sounds";
            FormClosing += Sounds_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBarMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSfx).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarMusic;
        private TrackBar trackBarSfx;
        private Label lblMusicVolume;
        private Label label1;
        private Label lblSfxVolume;
        private Label label3;
        private Button Backbtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}