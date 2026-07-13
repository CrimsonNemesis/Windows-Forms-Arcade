namespace Arcade_Game
{
    partial class SelectProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProfile));
            btnNew = new Button();
            gameDbContextBindingSource = new BindingSource(components);
            playerProfileBindingSource = new BindingSource(components);
            btnLoad = new Button();
            txtName = new TextBox();
            lstProfiles = new ListBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.None;
            btnNew.BackColor = Color.MediumSeaGreen;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(1194, 834);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(198, 69);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Profile";
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
            btnLoad.Anchor = AnchorStyles.None;
            btnLoad.BackColor = Color.LightSeaGreen;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.Black;
            btnLoad.Location = new Point(32, 834);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(206, 69);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Profile";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.Snow;
            txtName.Font = new Font("Kristen ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(613, 858);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 36);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lstProfiles
            // 
            lstProfiles.Anchor = AnchorStyles.None;
            lstProfiles.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProfiles.FormattingEnabled = true;
            lstProfiles.Location = new Point(355, 347);
            lstProfiles.Margin = new Padding(3, 4, 3, 4);
            lstProfiles.Name = "lstProfiles";
            lstProfiles.Size = new Size(747, 411);
            lstProfiles.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Title;
            pictureBox1.Location = new Point(416, 46);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Controls.Add(btnLoad, 0, 2);
            tableLayoutPanel1.Controls.Add(lstProfiles, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNew, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtName, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(1457, 955);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // SelectProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Properties.Resources.SpaceBackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 955);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectProfile";
            Text = "SelectForm";
            FormClosing += SelectProfile_FormClosing;
            VisibleChanged += SelectProfile_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNew;
        private BindingSource gameDbContextBindingSource;
        private BindingSource playerProfileBindingSource;
        private Button btnLoad;
        private TextBox txtName;
        private ListBox lstProfiles;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}