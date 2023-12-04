namespace Practic._4_практична
{
    partial class _4pract
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
            label1 = new Label();
            Arr = new Label();
            label3 = new Label();
            Ans = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 160);
            button1.Name = "button1";
            button1.Size = new Size(131, 58);
            button1.TabIndex = 0;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 1;
            label1.Text = "Заданий масив";
            // 
            // Arr
            // 
            Arr.AutoSize = true;
            Arr.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Arr.Location = new Point(277, 46);
            Arr.Name = "Arr";
            Arr.Size = new Size(0, 37);
            Arr.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 83);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 3;
            label3.Text = "Відповідь";
            // 
            // Ans
            // 
            Ans.AutoSize = true;
            Ans.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Ans.Location = new Point(383, 120);
            Ans.Name = "Ans";
            Ans.Size = new Size(0, 37);
            Ans.TabIndex = 4;
            // 
            // _4pract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            Controls.Add(Ans);
            Controls.Add(label3);
            Controls.Add(Arr);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "_4pract";
            Text = "_4pract";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label Arr;
        private Label label3;
        private Label Ans;
    }
}