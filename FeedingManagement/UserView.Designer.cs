namespace FeedingManagement
{
    partial class UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 153);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 186);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(476, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 219);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(476, 27);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 257);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 0;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 120);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 0;
            label5.Text = "ID";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(139, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 27);
            textBox5.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male ", "Female", "etc.." });
            comboBox1.Location = new Point(139, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(476, 28);
            comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 297);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 0;
            label6.Text = "Date Of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 290);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(476, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 330);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 0;
            label7.Text = "Role";
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Admin ", "User" });
            comboBox2.Location = new Point(139, 327);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(476, 28);
            comboBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(676, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(139, 50);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(255, 50);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 5;
            button2.Text = "Save Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 546);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UserView";
            Text = "User Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}