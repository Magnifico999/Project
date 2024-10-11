namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ExpDate = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 0;
            label1.Text = "TO DO LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(100, 56);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "Task ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(97, 101);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 2;
            label3.Text = "Project Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(97, 141);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 3;
            label4.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(97, 176);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(97, 223);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 5;
            label6.Text = "Expiry Date";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(234, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 29);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(234, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 29);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "High", "Middle ", "Low" });
            comboBox1.Location = new Point(234, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 29);
            comboBox1.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(234, 179);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 25);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Important";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(387, 179);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(127, 25);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Unimportant";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // ExpDate
            // 
            ExpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpDate.Format = DateTimePickerFormat.Short;
            ExpDate.Location = new Point(234, 221);
            ExpDate.Name = "ExpDate";
            ExpDate.Size = new Size(341, 29);
            ExpDate.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(179, 280);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 12;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(611, 150);
            dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(319, 280);
            button2.Name = "button2";
            button2.Size = new Size(105, 38);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(452, 280);
            button3.Name = "button3";
            button3.Size = new Size(105, 38);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(581, 42);
            button4.Name = "button4";
            button4.Size = new Size(105, 38);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 488);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(ExpDate);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker ExpDate;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}