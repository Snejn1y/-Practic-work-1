namespace Practic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Xn = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            масивиToolStripMenuItem = new ToolStripMenuItem();
            одновимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            двовимірніМасивиToolStripMenuItem = new ToolStripMenuItem();
            labaToolStripMenuItem = new ToolStripMenuItem();
            практинаToolStripMenuItem = new ToolStripMenuItem();
            практичнаToolStripMenuItem = new ToolStripMenuItem();
            практичнаToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 38);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "-1,25";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 38);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 31);
            textBox2.TabIndex = 0;
            textBox2.Text = "9,39";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(350, 38);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 31);
            textBox3.TabIndex = 0;
            textBox3.Text = "0,4";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(491, 38);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(104, 31);
            textBox4.TabIndex = 0;
            textBox4.Text = "0,8";
            // 
            // Xn
            // 
            Xn.AutoSize = true;
            Xn.Location = new Point(17, 43);
            Xn.Margin = new Padding(4, 0, 4, 0);
            Xn.Name = "Xn";
            Xn.Size = new Size(33, 25);
            Xn.TabIndex = 1;
            Xn.Text = "Xn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 1;
            label1.Text = "Xk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 1;
            label2.Text = "h";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 1;
            label3.Text = "a";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridView1.Location = new Point(56, 87);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(400, 643);
            dataGridView1.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 8;
            X.Name = "X";
            X.Width = 150;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.MinimumWidth = 8;
            Y.Name = "Y";
            Y.Width = 150;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(491, 87);
            chart1.Margin = new Padding(4, 5, 4, 5);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(607, 643);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // button1
            // 
            button1.Location = new Point(629, 38);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 4;
            button1.Text = " Сalculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { масивиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // масивиToolStripMenuItem
            // 
            масивиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одновимірніМасивиToolStripMenuItem, двовимірніМасивиToolStripMenuItem, labaToolStripMenuItem, практинаToolStripMenuItem, практичнаToolStripMenuItem, практичнаToolStripMenuItem1 });
            масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            масивиToolStripMenuItem.Size = new Size(96, 29);
            масивиToolStripMenuItem.Text = " Масиви";
            // 
            // одновимірніМасивиToolStripMenuItem
            // 
            одновимірніМасивиToolStripMenuItem.Name = "одновимірніМасивиToolStripMenuItem";
            одновимірніМасивиToolStripMenuItem.Size = new Size(286, 34);
            одновимірніМасивиToolStripMenuItem.Text = "Одновимірні масиви";
            одновимірніМасивиToolStripMenuItem.Click += одновимірніМасивиToolStripMenuItem_Click;
            // 
            // двовимірніМасивиToolStripMenuItem
            // 
            двовимірніМасивиToolStripMenuItem.Name = "двовимірніМасивиToolStripMenuItem";
            двовимірніМасивиToolStripMenuItem.Size = new Size(286, 34);
            двовимірніМасивиToolStripMenuItem.Text = "Двовимірні масиви";
            двовимірніМасивиToolStripMenuItem.Click += двовимірніМасивиToolStripMenuItem_Click;
            // 
            // labaToolStripMenuItem
            // 
            labaToolStripMenuItem.Name = "labaToolStripMenuItem";
            labaToolStripMenuItem.Size = new Size(286, 34);
            labaToolStripMenuItem.Text = "4 Laba";
            labaToolStripMenuItem.Click += labaToolStripMenuItem_Click;
            // 
            // практинаToolStripMenuItem
            // 
            практинаToolStripMenuItem.Name = "практинаToolStripMenuItem";
            практинаToolStripMenuItem.Size = new Size(286, 34);
            практинаToolStripMenuItem.Text = "4 практина";
            практинаToolStripMenuItem.Click += практинаToolStripMenuItem_Click;
            // 
            // практичнаToolStripMenuItem
            // 
            практичнаToolStripMenuItem.Name = "практичнаToolStripMenuItem";
            практичнаToolStripMenuItem.Size = new Size(286, 34);
            практичнаToolStripMenuItem.Text = "5 практична";
            практичнаToolStripMenuItem.Click += практичнаToolStripMenuItem_Click;
            // 
            // практичнаToolStripMenuItem1
            // 
            практичнаToolStripMenuItem1.Name = "практичнаToolStripMenuItem1";
            практичнаToolStripMenuItem1.Size = new Size(286, 34);
            практичнаToolStripMenuItem1.Text = "6 практична";
            практичнаToolStripMenuItem1.Click += практичнаToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Xn);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Xn;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem масивиToolStripMenuItem;
        private ToolStripMenuItem одновимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem двовимірніМасивиToolStripMenuItem;
        private ToolStripMenuItem labaToolStripMenuItem;
        private ToolStripMenuItem практинаToolStripMenuItem;
        private ToolStripMenuItem практичнаToolStripMenuItem;
        private ToolStripMenuItem практичнаToolStripMenuItem1;
    }
}