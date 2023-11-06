namespace FeedingManagement
{
    partial class FeedingPlanListForm
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

            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            cboCageType = new ComboBox();
            label5 = new Label();
            fromDatePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            toDatePicker = new DateTimePicker();
            addBtn = new Button();
            UpdateBtn = new Button();
            deleteBtn = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            cboBirdName = new ComboBox();

            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 

            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(539, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1061, 800);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(952, 56);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 12;
            label1.Text = "Feeding Plan List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 47);
            label2.Name = "label2";
            label2.Size = new Size(304, 46);
            label2.TabIndex = 12;
            label2.Text = "Plan Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 135);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 13;
            label3.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(136, 132);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(133, 27);
            txtId.TabIndex = 14;
            // 
            // cboCageType
            // 
            cboCageType.FormattingEnabled = true;
            cboCageType.Items.AddRange(new object[] { "Automatic", "Manual" });
            cboCageType.Location = new Point(136, 228);
            cboCageType.Name = "cboCageType";
            cboCageType.Size = new Size(304, 28);
            cboCageType.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 236);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 16;
            label5.Text = "Cage Type";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(136, 280);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(250, 27);
            fromDatePicker.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 287);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 16;
            label6.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 329);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 16;
            label7.Text = "To:";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(136, 324);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 17;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(21, 433);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(129, 29);
            addBtn.TabIndex = 18;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(174, 433);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(129, 29);
            UpdateBtn.TabIndex = 18;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(326, 433);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(129, 29);
            deleteBtn.TabIndex = 18;
            deleteBtn.Text = "&Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 191);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 13;
            label8.Text = "Bird's Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromDatePicker);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(toDatePicker);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboBirdName);
            groupBox1.Controls.Add(cboCageType);
            groupBox1.Location = new Point(28, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 525);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // cboBirdName
            // 
            cboBirdName.FormattingEnabled = true;
            cboBirdName.Items.AddRange(new object[] { "Automatic", "Manual" });
            cboBirdName.Location = new Point(136, 183);
            cboBirdName.Name = "cboBirdName";
            cboBirdName.Size = new Size(304, 28);
            cboBirdName.TabIndex = 15;
            // 
            // FeedingPlanListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1612, 918);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);

            Name = "FeedingPlanListForm";
            Text = "FeedingPlanListForm";

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox cboCageType;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker fromDatePicker;
        private Button deleteBtn;
        private Button UpdateBtn;
        private Button addBtn;
        private DateTimePicker toDatePicker;
        private Label label7;
        private Label label8;
        private Label label6;
        private ComboBox cboBirdName;
    }
}