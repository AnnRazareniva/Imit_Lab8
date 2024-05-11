namespace _8._3
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.auto = new System.Windows.Forms.Button();
            this.Prob1 = new System.Windows.Forms.TextBox();
            this.Prob2 = new System.Windows.Forms.TextBox();
            this.Prob3 = new System.Windows.Forms.TextBox();
            this.Prob4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(303, 90);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(431, 342);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(153, 415);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(61, 21);
            this.auto.TabIndex = 6;
            this.auto.Text = "Авто";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // Prob1
            // 
            this.Prob1.Location = new System.Drawing.Point(153, 238);
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(67, 20);
            this.Prob1.TabIndex = 7;
            this.Prob1.Text = "0,1";
            // 
            // Prob2
            // 
            this.Prob2.Location = new System.Drawing.Point(153, 283);
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(67, 20);
            this.Prob2.TabIndex = 8;
            this.Prob2.Text = "0,2";
            // 
            // Prob3
            // 
            this.Prob3.Location = new System.Drawing.Point(153, 329);
            this.Prob3.Name = "Prob3";
            this.Prob3.Size = new System.Drawing.Size(67, 20);
            this.Prob3.TabIndex = 9;
            this.Prob3.Text = "0,2";
            // 
            // Prob4
            // 
            this.Prob4.Location = new System.Drawing.Point(153, 372);
            this.Prob4.Name = "Prob4";
            this.Prob4.Size = new System.Drawing.Size(67, 20);
            this.Prob4.TabIndex = 10;
            this.Prob4.Text = "0,1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вероятность 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вероятность 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вероятность 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вероятность 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Вероятность 5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(303, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 96);
            this.button1.TabIndex = 16;
            this.button1.Text = "ПОЕХАЛИ!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Количество попыток";
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(196, 470);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(67, 20);
            this.NN.TabIndex = 18;
            this.NN.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prob4);
            this.Controls.Add(this.Prob3);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.TextBox Prob1;
        private System.Windows.Forms.TextBox Prob2;
        private System.Windows.Forms.TextBox Prob3;
        private System.Windows.Forms.TextBox Prob4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NN;
    }
}

