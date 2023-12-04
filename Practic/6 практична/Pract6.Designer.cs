namespace Practic._6_практична
{
    partial class Pract6
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
            startICEngineBtn = new Button();
            stopICEngineBtn = new Button();
            startDieselEngineBtn = new Button();
            stopDieselEngineBtn = new Button();
            startJetEngineBtn = new Button();
            stopJetEngineBtn = new Button();
            Close = new Button();
            PerformMaintenance1 = new Button();
            PerformMaintenance2 = new Button();
            Effective = new Button();
            SuspendLayout();
            // 
            // startICEngineBtn
            // 
            startICEngineBtn.Location = new Point(12, 12);
            startICEngineBtn.Name = "startICEngineBtn";
            startICEngineBtn.Size = new Size(175, 62);
            startICEngineBtn.TabIndex = 0;
            startICEngineBtn.Text = "Запустити ДВЗ";
            startICEngineBtn.UseVisualStyleBackColor = true;
            startICEngineBtn.Click += startICEngineBtn_Click;
            // 
            // stopICEngineBtn
            // 
            stopICEngineBtn.Location = new Point(12, 80);
            stopICEngineBtn.Name = "stopICEngineBtn";
            stopICEngineBtn.Size = new Size(175, 60);
            stopICEngineBtn.TabIndex = 0;
            stopICEngineBtn.Text = "Зупинити ДВЗ";
            stopICEngineBtn.UseVisualStyleBackColor = true;
            stopICEngineBtn.Click += stopICEngineBtn_Click;
            // 
            // startDieselEngineBtn
            // 
            startDieselEngineBtn.Location = new Point(267, 12);
            startDieselEngineBtn.Name = "startDieselEngineBtn";
            startDieselEngineBtn.Size = new Size(175, 62);
            startDieselEngineBtn.TabIndex = 0;
            startDieselEngineBtn.Text = "Запустити Дизель";
            startDieselEngineBtn.UseVisualStyleBackColor = true;
            startDieselEngineBtn.Click += startDieselEngineBtn_Click;
            // 
            // stopDieselEngineBtn
            // 
            stopDieselEngineBtn.Location = new Point(267, 80);
            stopDieselEngineBtn.Name = "stopDieselEngineBtn";
            stopDieselEngineBtn.Size = new Size(175, 60);
            stopDieselEngineBtn.TabIndex = 0;
            stopDieselEngineBtn.Text = "Зупинити Дизель";
            stopDieselEngineBtn.UseVisualStyleBackColor = true;
            stopDieselEngineBtn.Click += stopDieselEngineBtn_Click;
            // 
            // startJetEngineBtn
            // 
            startJetEngineBtn.Location = new Point(514, 12);
            startJetEngineBtn.Name = "startJetEngineBtn";
            startJetEngineBtn.Size = new Size(175, 62);
            startJetEngineBtn.TabIndex = 0;
            startJetEngineBtn.Text = "Запустити Реактивний";
            startJetEngineBtn.UseVisualStyleBackColor = true;
            startJetEngineBtn.Click += startJetEngineBtn_Click;
            // 
            // stopJetEngineBtn
            // 
            stopJetEngineBtn.Location = new Point(514, 80);
            stopJetEngineBtn.Name = "stopJetEngineBtn";
            stopJetEngineBtn.Size = new Size(175, 60);
            stopJetEngineBtn.TabIndex = 0;
            stopJetEngineBtn.Text = "Зупинити Реактивний";
            stopJetEngineBtn.UseVisualStyleBackColor = true;
            stopJetEngineBtn.Click += stopJetEngineBtn_Click;
            // 
            // Close
            // 
            Close.Location = new Point(267, 307);
            Close.Name = "Close";
            Close.Size = new Size(175, 34);
            Close.TabIndex = 1;
            Close.Text = "Закрити";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // PerformMaintenance1
            // 
            PerformMaintenance1.Location = new Point(12, 146);
            PerformMaintenance1.Name = "PerformMaintenance1";
            PerformMaintenance1.Size = new Size(175, 60);
            PerformMaintenance1.TabIndex = 0;
            PerformMaintenance1.Text = "Технічне обслуговування";
            PerformMaintenance1.UseVisualStyleBackColor = true;
            PerformMaintenance1.Click += PerformMaintenance1_Click;
            // 
            // PerformMaintenance2
            // 
            PerformMaintenance2.Location = new Point(267, 146);
            PerformMaintenance2.Name = "PerformMaintenance2";
            PerformMaintenance2.Size = new Size(175, 60);
            PerformMaintenance2.TabIndex = 0;
            PerformMaintenance2.Text = "Технічне обслуговування";
            PerformMaintenance2.UseVisualStyleBackColor = true;
            PerformMaintenance2.Click += PerformMaintenance2_Click;
            // 
            // Effective
            // 
            Effective.Location = new Point(267, 212);
            Effective.Name = "Effective";
            Effective.Size = new Size(175, 60);
            Effective.TabIndex = 0;
            Effective.Text = "Перевірка ефективності";
            Effective.UseVisualStyleBackColor = true;
            Effective.Click += Effective_Click;
            // 
            // Pract6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 399);
            Controls.Add(Close);
            Controls.Add(stopJetEngineBtn);
            Controls.Add(startJetEngineBtn);
            Controls.Add(stopDieselEngineBtn);
            Controls.Add(startDieselEngineBtn);
            Controls.Add(Effective);
            Controls.Add(PerformMaintenance2);
            Controls.Add(PerformMaintenance1);
            Controls.Add(stopICEngineBtn);
            Controls.Add(startICEngineBtn);
            Name = "Pract6";
            Text = "Pract6";
            ResumeLayout(false);
        }

        #endregion

        private Button startICEngineBtn;
        private Button stopICEngineBtn;
        private Button startDieselEngineBtn;
        private Button stopDieselEngineBtn;
        private Button startJetEngineBtn;
        private Button stopJetEngineBtn;
        private Button Close;
        private Button PerformMaintenance1;
        private Button PerformMaintenance2;
        private Button Effective;
    }
}