namespace Arcade_Game
{
    partial class SelectForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            btnNew = new Button();
            gameDbContextBindingSource = new BindingSource(components);
            playerProfileBindingSource = new BindingSource(components);
            btnLoad = new Button();
            txtName = new TextBox();
            lstProfiles = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.MediumSeaGreen;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(554, 357);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(186, 69);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Player";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // gameDbContextBindingSource
            // 
            gameDbContextBindingSource.DataSource = typeof(GameDbContext);
            // 
            // playerProfileBindingSource
            // 
            playerProfileBindingSource.DataSource = typeof(PlayerProfile);
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSeaGreen;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.Black;
            btnLoad.Location = new Point(61, 357);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(186, 69);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Player";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Snow;
            txtName.Font = new Font("Kristen ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(301, 386);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 36);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lstProfiles
            // 
            lstProfiles.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProfiles.FormattingEnabled = true;
            lstProfiles.Location = new Point(124, 113);
            lstProfiles.Name = "lstProfiles";
            lstProfiles.Size = new Size(547, 228);
            lstProfiles.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gameTitle;
            pictureBox1.Location = new Point(149, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(lstProfiles);
            Controls.Add(txtName);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectForm";
            Text = "SelectForm";
            FormClosing += Form_FormClosing;
            Load += SelectForm_Load;
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private BindingSource gameDbContextBindingSource;
        private BindingSource playerProfileBindingSource;
        private Button btnLoad;
        private TextBox txtName;
        private ListBox lstProfiles;
        private PictureBox pictureBox1;
    }
}