namespace FeedingManagement
{
    partial class FoodListForm
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
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            txtId = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(341, 267);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(121, 29);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "&Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(200, 267);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(121, 29);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(48, 267);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(121, 29);
            addBtn.TabIndex = 3;
            addBtn.Text = "&Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 155);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(237, 27);
            txtId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 162);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 188);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 195);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(179, 44);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 0;
            label1.Text = "Food List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(538, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(528, 635);
            dataGridView1.TabIndex = 1;
            // 
            // FoodListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1069, 655);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FoodListForm";
            Text = "FoodListForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
    }
}