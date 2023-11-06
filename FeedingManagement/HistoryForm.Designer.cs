namespace FeedingManagement
{
    partial class HistoryForm
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
            label1 = new Label();
            cboBirdName = new ComboBox();
            label2 = new Label();
            cboCageType = new ComboBox();
            label3 = new Label();
            fromDatePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            toDatePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(958, 57);
            label1.Name = "label1";
            label1.Size = new Size(144, 46);
            label1.TabIndex = 0;
            label1.Text = "History";
            // 
            // cboBirdName
            // 
            cboBirdName.FormattingEnabled = true;
            cboBirdName.Location = new Point(174, 188);
            cboBirdName.Name = "cboBirdName";
            cboBirdName.Size = new Size(250, 28);
            cboBirdName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 196);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Bird's Name:";
            // 
            // cboCageType
            // 
            cboCageType.FormattingEnabled = true;
            cboCageType.Location = new Point(174, 142);
            cboCageType.Name = "cboCageType";
            cboCageType.Size = new Size(250, 28);
            cboCageType.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 150);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Cage type:";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(174, 259);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(250, 27);
            fromDatePicker.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 266);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "From:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 322);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 2;
            label5.Text = "To:";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(174, 315);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(250, 27);
            toDatePicker.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1095, 700);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(174, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1558, 829);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(toDatePicker);
            Controls.Add(label5);
            Controls.Add(fromDatePicker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboCageType);
            Controls.Add(cboBirdName);
            Controls.Add(label1);
            Name = "HistoryForm";
            Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboBirdName;
        private Label label2;
        private ComboBox cboCageType;
        private Label label3;
        private DateTimePicker fromDatePicker;
        private Label label4;
        private Label label5;
        private DateTimePicker toDatePicker;
        private DataGridView dataGridView1;
        private Button button1;
    }
}