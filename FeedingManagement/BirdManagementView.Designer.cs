namespace FeedingManagement
{
    partial class BirdManagementView
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
            groupBox1 = new GroupBox();
            cboFoods = new ComboBox();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            txtFeathering = new TextBox();
            txtPregnant = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtCageId = new TextBox();
            lblCageId = new Label();
            txtId = new TextBox();
            lblId = new Label();
            label1 = new Label();
            dgvBirdList = new DataGridView();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBirdList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboFoods);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(txtFeathering);
            groupBox1.Controls.Add(txtPregnant);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCageId);
            groupBox1.Controls.Add(lblCageId);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cboFoods
            // 
            cboFoods.FormattingEnabled = true;
            cboFoods.Location = new Point(131, 369);
            cboFoods.Name = "cboFoods";
            cboFoods.Size = new Size(329, 28);
            cboFoods.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(366, 444);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(209, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(40, 444);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtFeathering
            // 
            txtFeathering.Enabled = false;
            txtFeathering.Location = new Point(130, 325);
            txtFeathering.Name = "txtFeathering";
            txtFeathering.Size = new Size(330, 27);
            txtFeathering.TabIndex = 2;
            // 
            // txtPregnant
            // 
            txtPregnant.Enabled = false;
            txtPregnant.Location = new Point(131, 282);
            txtPregnant.Name = "txtPregnant";
            txtPregnant.Size = new Size(330, 27);
            txtPregnant.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 328);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Feathering";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 285);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 1;
            label5.Text = "Pregant";
            // 
            // txtAge
            // 
            txtAge.Enabled = false;
            txtAge.Location = new Point(131, 239);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(330, 27);
            txtAge.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 242);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 1;
            label4.Text = "Age Period";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(131, 195);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 198);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // txtCageId
            // 
            txtCageId.Enabled = false;
            txtCageId.Location = new Point(131, 148);
            txtCageId.Name = "txtCageId";
            txtCageId.Size = new Size(330, 27);
            txtCageId.TabIndex = 2;
            // 
            // lblCageId
            // 
            lblCageId.AutoSize = true;
            lblCageId.Location = new Point(25, 151);
            lblCageId.Name = "lblCageId";
            lblCageId.Size = new Size(62, 20);
            lblCageId.TabIndex = 1;
            lblCageId.Text = "Cage ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(131, 101);
            txtId.Name = "txtId";
            txtId.Size = new Size(330, 27);
            txtId.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(25, 104);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(115, 23);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 0;
            label1.Text = "BIRD MANAGEMENT";
            // 
            // dgvBirdList
            // 
            dgvBirdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBirdList.Location = new Point(568, 23);
            dgvBirdList.Name = "dgvBirdList";
            dgvBirdList.RowHeadersWidth = 51;
            dgvBirdList.RowTemplate.Height = 29;
            dgvBirdList.Size = new Size(504, 551);
            dgvBirdList.TabIndex = 1;
            dgvBirdList.CellFormatting += DgvBirdList_CellFormatting;
            dgvBirdList.SelectionChanged += DgvBirdList_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 372);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 1;
            label6.Text = "Suitable Food";
            // 
            // BirdManagementView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1074, 586);
            Controls.Add(dgvBirdList);
            Controls.Add(groupBox1);
            Name = "BirdManagementView";
            Text = "BirdManagementView";
            Load += BirdManagementView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBirdList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtId;
        private Label lblId;
        private Label label1;
        private DataGridView dgvBirdList;
        private TextBox txtPregnant;
        private Label label5;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCageId;
        private Label lblCageId;
        private TextBox txtFeathering;
        private Label label2;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnNew;
        private ComboBox cboFoods;
        private Label label6;
    }
}