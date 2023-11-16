namespace FeedingManagement
{
    partial class CageManagement
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
            dtgvCages = new DataGridView();
            cbCageFoods = new ComboBox();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            label6 = new Label();
            label5 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            txtAutomatic = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            lblCageId = new Label();
            txtID = new TextBox();
            lblId = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbBirds = new ComboBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvCages).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCages
            // 
            dtgvCages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCages.Location = new Point(704, 29);
            dtgvCages.Margin = new Padding(4);
            dtgvCages.Name = "dtgvCages";
            dtgvCages.RowHeadersWidth = 51;
            dtgvCages.RowTemplate.Height = 29;
            dtgvCages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCages.Size = new Size(630, 689);
            dtgvCages.TabIndex = 3;
            dtgvCages.CellFormatting += dtgvCages_CellFormatting;
            dtgvCages.SelectionChanged += dtgvCages_SelectionChanged;
            // 
            // cbCageFoods
            // 
            cbCageFoods.FormattingEnabled = true;
            cbCageFoods.Location = new Point(166, 422);
            cbCageFoods.Margin = new Padding(4);
            cbCageFoods.Name = "cbCageFoods";
            cbCageFoods.Size = new Size(410, 33);
            cbCageFoods.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(342, 555);
            btnRemove.Margin = new Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 36);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(196, 555);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(50, 555);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 427);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 1;
            label6.Text = "CageFoods";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 357);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 1;
            label5.Text = "Birds";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(164, 299);
            txtStatus.Margin = new Padding(4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(412, 31);
            txtStatus.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 303);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 1;
            label4.Text = "Status";
            // 
            // txtAutomatic
            // 
            txtAutomatic.Location = new Point(164, 244);
            txtAutomatic.Margin = new Padding(4);
            txtAutomatic.Name = "txtAutomatic";
            txtAutomatic.ReadOnly = true;
            txtAutomatic.Size = new Size(412, 31);
            txtAutomatic.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 1;
            label3.Text = "IsAutomatic";
            // 
            // txtName
            // 
            txtName.Location = new Point(164, 185);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(412, 31);
            txtName.TabIndex = 2;
            // 
            // lblCageId
            // 
            lblCageId.AutoSize = true;
            lblCageId.Location = new Point(32, 190);
            lblCageId.Margin = new Padding(4, 0, 4, 0);
            lblCageId.Name = "lblCageId";
            lblCageId.Size = new Size(59, 25);
            lblCageId.TabIndex = 1;
            lblCageId.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(164, 126);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(412, 31);
            txtID.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(32, 131);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(145, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 45);
            label1.TabIndex = 0;
            label1.Text = "CAGE MANAGEMENT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(cbBirds);
            groupBox1.Controls.Add(cbCageFoods);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAutomatic);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblCageId);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(669, 702);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // cbBirds
            // 
            cbBirds.FormattingEnabled = true;
            cbBirds.Location = new Point(164, 357);
            cbBirds.Margin = new Padding(4);
            cbBirds.Name = "cbBirds";
            cbBirds.Size = new Size(410, 33);
            cbBirds.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(491, 555);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CageManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 732);
            Controls.Add(dtgvCages);
            Controls.Add(groupBox1);
            Name = "CageManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CageManagement";
            ((System.ComponentModel.ISupportInitialize)dtgvCages).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvCages;
        private ComboBox cbCageFoods;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnNew;
        private Label label6;
        private Label label5;
        private TextBox txtStatus;
        private Label label4;
        private TextBox txtAutomatic;
        private Label label3;
        private TextBox txtName;
        private Label lblCageId;
        private TextBox txtID;
        private Label lblId;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbBirds;
        private Button btnExit;
    }
}