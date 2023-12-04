namespace Practic._5__практична
{
    partial class Pract5
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
            label2 = new Label();
            pib = new TextBox();
            label3 = new Label();
            posada = new TextBox();
            label4 = new Label();
            zarplata = new TextBox();
            label5 = new Label();
            stage = new TextBox();
            AddButton = new Button();
            label6 = new Label();
            label7 = new Label();
            zarplatamin = new TextBox();
            FindButton = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            dataGridView3 = new DataGridView();
            Column21 = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            ReadButton = new Button();
            WriteButton = new Button();
            RemoveButton = new Button();
            SortButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "Введення даних";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 1;
            label2.Text = "ПІБ";
            // 
            // pib
            // 
            pib.Location = new Point(114, 49);
            pib.Name = "pib";
            pib.Size = new Size(150, 31);
            pib.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Посада";
            // 
            // posada
            // 
            posada.Location = new Point(114, 86);
            posada.Name = "posada";
            posada.Size = new Size(150, 31);
            posada.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 1;
            label4.Text = "Зарплатня";
            // 
            // zarplata
            // 
            zarplata.Location = new Point(114, 123);
            zarplata.Name = "zarplata";
            zarplata.Size = new Size(150, 31);
            zarplata.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 1;
            label5.Text = "Стаж";
            // 
            // stage
            // 
            stage.Location = new Point(114, 160);
            stage.Name = "stage";
            stage.Size = new Size(150, 31);
            stage.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveCaption;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(12, 207);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(252, 43);
            AddButton.TabIndex = 3;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 277);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 0;
            label6.Text = "Пошук";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 320);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 1;
            label7.Text = "Зарплатня";
            // 
            // zarplatamin
            // 
            zarplatamin.Location = new Point(114, 317);
            zarplatamin.Name = "zarplatamin";
            zarplatamin.Size = new Size(150, 31);
            zarplatamin.TabIndex = 2;
            // 
            // FindButton
            // 
            FindButton.BackColor = SystemColors.ActiveCaption;
            FindButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FindButton.Location = new Point(12, 368);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(252, 43);
            FindButton.TabIndex = 3;
            FindButton.Text = "Пошук";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 442);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(252, 300);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "ПІБ";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Посада";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Зарплатня";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Стаж";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(362, 9);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 0;
            label8.Text = "Інформація";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column11, Column12, Column13, Column14 });
            dataGridView2.Location = new Point(313, 49);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(252, 693);
            dataGridView2.TabIndex = 5;
            // 
            // Column11
            // 
            Column11.HeaderText = "ПІБ";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.HeaderText = "Посада";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.HeaderText = "Зарплатня";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.Width = 150;
            // 
            // Column14
            // 
            Column14.HeaderText = "Стаж";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.Width = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(633, 9);
            label9.Name = "label9";
            label9.Size = new Size(239, 25);
            label9.TabIndex = 0;
            label9.Text = "Відсортована інформація";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column21, Column22, Column23, Column24 });
            dataGridView3.Location = new Point(620, 49);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(252, 693);
            dataGridView3.TabIndex = 5;
            // 
            // Column21
            // 
            Column21.HeaderText = "ПІБ";
            Column21.MinimumWidth = 8;
            Column21.Name = "Column21";
            Column21.Width = 150;
            // 
            // Column22
            // 
            Column22.HeaderText = "Посада";
            Column22.MinimumWidth = 8;
            Column22.Name = "Column22";
            Column22.Width = 150;
            // 
            // Column23
            // 
            Column23.HeaderText = "Зарплатня";
            Column23.MinimumWidth = 8;
            Column23.Name = "Column23";
            Column23.Width = 150;
            // 
            // Column24
            // 
            Column24.HeaderText = "Стаж";
            Column24.MinimumWidth = 8;
            Column24.Name = "Column24";
            Column24.Width = 150;
            // 
            // ReadButton
            // 
            ReadButton.BackColor = SystemColors.ActiveCaption;
            ReadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReadButton.Location = new Point(25, 778);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(181, 43);
            ReadButton.TabIndex = 3;
            ReadButton.Text = "Читання";
            ReadButton.UseVisualStyleBackColor = false;
            ReadButton.Click += ReadButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.BackColor = SystemColors.ActiveCaption;
            WriteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WriteButton.Location = new Point(227, 778);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(181, 43);
            WriteButton.TabIndex = 3;
            WriteButton.Text = "Запис";
            WriteButton.UseVisualStyleBackColor = false;
            WriteButton.Click += WriteButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.ActiveCaption;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveButton.Location = new Point(414, 778);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(181, 43);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Видалення";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SortButton
            // 
            SortButton.BackColor = SystemColors.ActiveCaption;
            SortButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SortButton.Location = new Point(601, 778);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(181, 43);
            SortButton.TabIndex = 3;
            SortButton.Text = "Сортування";
            SortButton.UseVisualStyleBackColor = false;
            SortButton.Click += SortButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = SystemColors.ActiveCaption;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.Location = new Point(788, 778);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 43);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Закрити";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // Pract5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 844);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(CloseButton);
            Controls.Add(SortButton);
            Controls.Add(RemoveButton);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(FindButton);
            Controls.Add(AddButton);
            Controls.Add(stage);
            Controls.Add(label5);
            Controls.Add(zarplata);
            Controls.Add(label4);
            Controls.Add(posada);
            Controls.Add(label3);
            Controls.Add(zarplatamin);
            Controls.Add(label7);
            Controls.Add(pib);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "Pract5";
            Text = "Pract5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox pib;
        private Label label3;
        private TextBox posada;
        private Label label4;
        private TextBox zarplata;
        private Label label5;
        private TextBox stage;
        private Button AddButton;
        private Label label6;
        private Label label7;
        private TextBox zarplatamin;
        private Button FindButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Label label9;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private Button ReadButton;
        private Button WriteButton;
        private Button RemoveButton;
        private Button SortButton;
        private Button CloseButton;
    }
}