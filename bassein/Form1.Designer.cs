namespace bassein
{
    partial class Bassein
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bassein));
            this.buttonCrane = new System.Windows.Forms.Button();
            this.pump1 = new bassein.Pump();
            this.pump2 = new bassein.Pump();
            this.pump3 = new bassein.Pump();
            this.pump4 = new bassein.Pump();
            this.pump5 = new bassein.Pump();
            this.numericUpDownCranePower = new System.Windows.Forms.NumericUpDown();
            this.labelCranePower = new System.Windows.Forms.Label();
            this.labelVolumeWater = new System.Windows.Forms.Label();
            this.verticalProgressBarBassein = new bassein.VerticalProgressBar();
            this.workerCrane = new System.ComponentModel.BackgroundWorker();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCranePower)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrane
            // 
            this.buttonCrane.BackColor = System.Drawing.Color.White;
            this.buttonCrane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCrane.BackgroundImage")));
            this.buttonCrane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCrane.Location = new System.Drawing.Point(613, 75);
            this.buttonCrane.Name = "buttonCrane";
            this.buttonCrane.Size = new System.Drawing.Size(74, 64);
            this.buttonCrane.TabIndex = 2;
            this.buttonCrane.UseVisualStyleBackColor = false;
            this.buttonCrane.Click += new System.EventHandler(this.buttonCrane_Click);
            // 
            // pump1
            // 
            this.pump1.BackColor = System.Drawing.Color.White;
            this.pump1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pump1.BackgroundImage")));
            this.pump1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pump1.Location = new System.Drawing.Point(65, 145);
            this.pump1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pump1.Name = "pump1";
            this.pump1.Size = new System.Drawing.Size(149, 60);
            this.pump1.TabIndex = 5;
            // 
            // pump2
            // 
            this.pump2.BackColor = System.Drawing.Color.White;
            this.pump2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pump2.BackgroundImage")));
            this.pump2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pump2.Location = new System.Drawing.Point(65, 227);
            this.pump2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pump2.Name = "pump2";
            this.pump2.Size = new System.Drawing.Size(149, 60);
            this.pump2.TabIndex = 6;
            // 
            // pump3
            // 
            this.pump3.BackColor = System.Drawing.Color.White;
            this.pump3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pump3.BackgroundImage")));
            this.pump3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pump3.Location = new System.Drawing.Point(65, 310);
            this.pump3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pump3.Name = "pump3";
            this.pump3.Size = new System.Drawing.Size(149, 60);
            this.pump3.TabIndex = 7;
            // 
            // pump4
            // 
            this.pump4.BackColor = System.Drawing.Color.White;
            this.pump4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pump4.BackgroundImage")));
            this.pump4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pump4.Location = new System.Drawing.Point(65, 402);
            this.pump4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pump4.Name = "pump4";
            this.pump4.Size = new System.Drawing.Size(149, 60);
            this.pump4.TabIndex = 8;
            // 
            // pump5
            // 
            this.pump5.BackColor = System.Drawing.Color.White;
            this.pump5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pump5.BackgroundImage")));
            this.pump5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pump5.Location = new System.Drawing.Point(65, 493);
            this.pump5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pump5.Name = "pump5";
            this.pump5.Size = new System.Drawing.Size(149, 60);
            this.pump5.TabIndex = 9;
            // 
            // numericUpDownCranePower
            // 
            this.numericUpDownCranePower.Location = new System.Drawing.Point(184, 9);
            this.numericUpDownCranePower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCranePower.Name = "numericUpDownCranePower";
            this.numericUpDownCranePower.Size = new System.Drawing.Size(45, 23);
            this.numericUpDownCranePower.TabIndex = 10;
            this.numericUpDownCranePower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCranePower
            // 
            this.labelCranePower.AutoSize = true;
            this.labelCranePower.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCranePower.Location = new System.Drawing.Point(10, 7);
            this.labelCranePower.Name = "labelCranePower";
            this.labelCranePower.Size = new System.Drawing.Size(168, 25);
            this.labelCranePower.TabIndex = 11;
            this.labelCranePower.Text = "Мощность крана:";
            // 
            // labelVolumeWater
            // 
            this.labelVolumeWater.AutoSize = true;
            this.labelVolumeWater.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVolumeWater.Location = new System.Drawing.Point(219, 117);
            this.labelVolumeWater.Name = "labelVolumeWater";
            this.labelVolumeWater.Size = new System.Drawing.Size(198, 25);
            this.labelVolumeWater.TabIndex = 12;
            this.labelVolumeWater.Text = "0/2000 литров = 0 %";
            // 
            // verticalProgressBarBassein
            // 
            this.verticalProgressBarBassein.Location = new System.Drawing.Point(219, 145);
            this.verticalProgressBarBassein.Maximum = 2000;
            this.verticalProgressBarBassein.Name = "verticalProgressBarBassein";
            this.verticalProgressBarBassein.Size = new System.Drawing.Size(468, 408);
            this.verticalProgressBarBassein.TabIndex = 13;
            // 
            // workerCrane
            // 
            this.workerCrane.WorkerReportsProgress = true;
            this.workerCrane.WorkerSupportsCancellation = true;
            this.workerCrane.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(128, 38);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(101, 47);
            this.buttonApply.TabIndex = 14;
            this.buttonApply.Text = "Применить изменения";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // Bassein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 565);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.verticalProgressBarBassein);
            this.Controls.Add(this.labelVolumeWater);
            this.Controls.Add(this.labelCranePower);
            this.Controls.Add(this.numericUpDownCranePower);
            this.Controls.Add(this.pump5);
            this.Controls.Add(this.pump4);
            this.Controls.Add(this.pump3);
            this.Controls.Add(this.pump2);
            this.Controls.Add(this.pump1);
            this.Controls.Add(this.buttonCrane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bassein";
            this.Text = "Бассейн";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCranePower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCrane;
        private Pump pump1;
        private Pump pump2;
        private Pump pump3;
        private Pump pump4;
        private Pump pump5;
        private System.Windows.Forms.NumericUpDown numericUpDownCranePower;
        private System.Windows.Forms.Label labelCranePower;
        private System.Windows.Forms.Label labelVolumeWater;
        private VerticalProgressBar verticalProgressBarBassein;
        private System.ComponentModel.BackgroundWorker workerCrane;
        private System.Windows.Forms.Button buttonApply;
    }
}
