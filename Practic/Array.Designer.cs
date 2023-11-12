namespace Practic
{
    partial class Array
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            textBox5 = new TextBox();
            Т = new DataGridViewTextBoxColumn();
            Опади = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Т, Опади });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(380, 426);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 77);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 3;
            label1.Text = " T min";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 31);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 77);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "T max";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(626, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 114);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = " Op min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "Op max";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(511, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(660, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 31);
            textBox4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 184);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 5;
            label5.Text = " Кількість опадів при дощі";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 233);
            label6.Name = "label6";
            label6.Size = new Size(306, 25);
            label6.TabIndex = 5;
            label6.Text = " Кількість опадів при мокрому снігу";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 286);
            label7.Name = "label7";
            label7.Size = new Size(224, 25);
            label7.TabIndex = 5;
            label7.Text = " Кількість опадів при снігу";
            // 
            // button2
            // 
            button2.Location = new Point(666, 12);
            button2.Name = "button2";
            button2.Size = new Size(122, 34);
            button2.TabIndex = 6;
            button2.Text = "Обрахувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 40);
            label8.Name = "label8";
            label8.Size = new Size(25, 25);
            label8.TabIndex = 3;
            label8.Text = "N";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(466, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 31);
            textBox5.TabIndex = 4;
            // 
            // Т
            // 
            Т.HeaderText = "Т";
            Т.MinimumWidth = 8;
            Т.Name = "Т";
            // 
            // Опади
            // 
            Опади.HeaderText = "Опади";
            Опади.MinimumWidth = 8;
            Опади.Name = "Опади";
            // 
            // Array
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Array";
            Text = "Array";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Label label8;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Т;
        private DataGridViewTextBoxColumn Опади;
    }
}