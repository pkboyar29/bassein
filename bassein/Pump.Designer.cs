namespace bassein
{
    partial class Pump
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.workerPump = new System.ComponentModel.BackgroundWorker();
            this.buttonRozetka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerPump
            // 
            this.workerPump.WorkerReportsProgress = true;
            this.workerPump.WorkerSupportsCancellation = true;
            this.workerPump.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerPump_DoWork);
            // 
            // buttonRozetka
            // 
            this.buttonRozetka.BackgroundImage = global::bassein.Properties.Resources.rozetka;
            this.buttonRozetka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRozetka.Location = new System.Drawing.Point(3, 28);
            this.buttonRozetka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRozetka.Name = "buttonRozetka";
            this.buttonRozetka.Size = new System.Drawing.Size(30, 29);
            this.buttonRozetka.TabIndex = 1;
            this.buttonRozetka.UseVisualStyleBackColor = true;
            this.buttonRozetka.Click += new System.EventHandler(this.buttonRozetka_Click);
            // 
            // Pump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::bassein.Properties.Resources.pumpimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.buttonRozetka);
            this.DoubleBuffered = true;
            this.Name = "Pump";
            this.Size = new System.Drawing.Size(148, 60);
            this.Click += new System.EventHandler(this.Pump_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pump_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pump_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker workerPump;
        private System.Windows.Forms.Button buttonRozetka;
    }
}
