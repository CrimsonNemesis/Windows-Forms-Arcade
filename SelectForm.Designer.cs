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
            simpText = new Label();
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.MediumSeaGreen;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(602, 339);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(186, 69);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Player";
            btnNew.UseVisualStyleBackColor = false;
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
            btnLoad.Location = new Point(12, 339);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(186, 69);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Player";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(300, 368);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 3;
            // 
            // lstProfiles
            // 
            lstProfiles.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProfiles.FormattingEnabled = true;
            lstProfiles.Location = new Point(12, 22);
            lstProfiles.Name = "lstProfiles";
            lstProfiles.Size = new Size(449, 256);
            lstProfiles.TabIndex = 4;
            // 
            // simpText
            // 
            simpText.AutoSize = true;
            simpText.Font = new Font("Cascadia Code SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpText.Location = new Point(467, 22);
            simpText.Name = "simpText";
            simpText.Size = new Size(351, 245);
            simpText.TabIndex = 5;
            simpText.Text = "Please Choose the \r\nProfile from the \r\nnames on the\r\nleft side and Load \r\nit or make a New \r\nProfile  by clicking \r\non the New Player !";
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(simpText);
            Controls.Add(lstProfiles);
            Controls.Add(txtName);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectForm";
            Text = "SelectForm";
            FormClosing += Form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)gameDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerProfileBindingSource).EndInit();
            btnNew.Click += btnNew_Click;
            Load += SelectForm_Load;
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
        private Label simpText;
    }
}