namespace FeedingManagement
{
    partial class CageEntryForm
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
            cbBirds = new ComboBox();
            cbFoods = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            lblCageId = new Label();
            txtID = new TextBox();
            lblId = new Label();
            lbTitle = new Label();
            btnSave = new Button();
            btnAddBird = new Button();
            btnAddFood = new Button();
            cbIsAutomatic = new ComboBox();
            cbStatus = new ComboBox();
            cbNewBirds = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbNewFoods = new ComboBox();
            SuspendLayout();
            // 
            // cbBirds
            // 
            cbBirds.FormattingEnabled = true;
            cbBirds.Location = new Point(159, 327);
            cbBirds.Margin = new Padding(4);
            cbBirds.Name = "cbBirds";
            cbBirds.Size = new Size(410, 33);
            cbBirds.TabIndex = 17;
            // 
            // cbFoods
            // 
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(159, 389);
            cbFoods.Margin = new Padding(4);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(410, 33);
            cbFoods.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 392);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 6;
            label6.Text = "Foods";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 327);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 7;
            label5.Text = "Birds";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 273);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 9;
            label3.Text = "IsAutomatic";
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 155);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(412, 31);
            txtName.TabIndex = 2;
            // 
            // lblCageId
            // 
            lblCageId.AutoSize = true;
            lblCageId.Location = new Point(27, 160);
            lblCageId.Margin = new Padding(4, 0, 4, 0);
            lblCageId.Name = "lblCageId";
            lblCageId.Size = new Size(59, 25);
            lblCageId.TabIndex = 10;
            lblCageId.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(159, 96);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(412, 31);
            txtID.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 101);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // lbTitle
            // 
            lbTitle.AccessibleRole = AccessibleRole.Window;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.DarkSlateGray;
            lbTitle.Location = new Point(369, 25);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(227, 45);
            lbTitle.TabIndex = 18;
            lbTitle.Text = "CAGE ENTRY";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(476, 482);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddBird
            // 
            btnAddBird.Location = new Point(929, 327);
            btnAddBird.Margin = new Padding(4);
            btnAddBird.Name = "btnAddBird";
            btnAddBird.Size = new Size(118, 36);
            btnAddBird.TabIndex = 20;
            btnAddBird.Text = "Add Bird";
            btnAddBird.UseVisualStyleBackColor = true;
            btnAddBird.Click += btnAddBird_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(929, 389);
            btnAddFood.Margin = new Padding(4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(118, 36);
            btnAddFood.TabIndex = 21;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbIsAutomatic
            // 
            cbIsAutomatic.FormattingEnabled = true;
            cbIsAutomatic.Location = new Point(161, 211);
            cbIsAutomatic.Margin = new Padding(4);
            cbIsAutomatic.Name = "cbIsAutomatic";
            cbIsAutomatic.Size = new Size(410, 33);
            cbIsAutomatic.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(159, 273);
            cbStatus.Margin = new Padding(4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(410, 33);
            cbStatus.TabIndex = 4;
            // 
            // cbNewBirds
            // 
            cbNewBirds.FormattingEnabled = true;
            cbNewBirds.Location = new Point(736, 327);
            cbNewBirds.Margin = new Padding(4);
            cbNewBirds.Name = "cbNewBirds";
            cbNewBirds.Size = new Size(185, 33);
            cbNewBirds.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 332);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 25;
            label1.Text = "New bird to cage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 394);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 27;
            label2.Text = "New food to cage";
            // 
            // cbNewFoods
            // 
            cbNewFoods.FormattingEnabled = true;
            cbNewFoods.Location = new Point(736, 389);
            cbNewFoods.Margin = new Padding(4);
            cbNewFoods.Name = "cbNewFoods";
            cbNewFoods.Size = new Size(185, 33);
            cbNewFoods.TabIndex = 26;
            // 
            // CageEntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 601);
            Controls.Add(label2);
            Controls.Add(cbNewFoods);
            Controls.Add(label1);
            Controls.Add(cbNewBirds);
            Controls.Add(cbStatus);
            Controls.Add(cbIsAutomatic);
            Controls.Add(btnAddFood);
            Controls.Add(btnAddBird);
            Controls.Add(btnSave);
            Controls.Add(lbTitle);
            Controls.Add(cbBirds);
            Controls.Add(cbFoods);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(lblCageId);
            Controls.Add(txtID);
            Controls.Add(lblId);
            Name = "CageEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CageEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBirds;
        private ComboBox cbFoods;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label lblCageId;
        private TextBox txtID;
        private Label lblId;
        private Label lbTitle;
        private Button btnSave;
        private Button btnAddBird;
        private Button btnAddFood;
        private ComboBox cbIsAutomatic;
        private ComboBox cbStatus;
        private ComboBox cbNewBirds;
        private Label label1;
        private Label label2;
        private ComboBox cbNewFoods;
    }
}