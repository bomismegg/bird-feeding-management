﻿namespace FeedingManagement
{
    partial class CageListForm
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
            textBox1 = new TextBox();
            radioManual = new RadioButton();
            radioAuto = new RadioButton();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.CausesValidation = false;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioManual);
            groupBox1.Controls.Add(radioAuto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(436, 497);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 27);
            textBox1.TabIndex = 6;
            // 
            // radioManual
            // 
            radioManual.AutoSize = true;
            radioManual.Location = new Point(256, 290);
            radioManual.Name = "radioManual";
            radioManual.Size = new Size(79, 24);
            radioManual.TabIndex = 4;
            radioManual.TabStop = true;
            radioManual.Text = "Manual";
            radioManual.UseVisualStyleBackColor = true;
            // 
            // radioAuto
            // 
            radioAuto.AutoSize = true;
            radioAuto.Location = new Point(116, 290);
            radioAuto.Name = "radioAuto";
            radioAuto.Size = new Size(99, 24);
            radioAuto.TabIndex = 4;
            radioAuto.TabStop = true;
            radioAuto.Text = "Automatic";
            radioAuto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 203);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 1;
            label3.Text = "Name";
            label3.UseCompatibleTextRendering = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(94, 150);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(94, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 157);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 70);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 0;
            label1.Text = "Cage List ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(488, 497);
            dataGridView1.TabIndex = 1;
            // 
            // CageListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(982, 521);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "CageListForm";
            Text = "CageListForm";
            Load += CageListForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private RadioButton radioManual;
        private RadioButton radioAuto;
        private DataGridView dataGridView1;
        private Button removeBtn;
        private Button updateBtn;
        private Button newBtn;
        private TextBox textBox1;
    }
}