namespace graph
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.funkce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Vykresli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VzorecForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OdForm = new System.Windows.Forms.TextBox();
            this.KrokForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funkce)).BeginInit();
            this.SuspendLayout();
            // 
            // funkce
            // 
            chartArea1.Name = "ChartArea1";
            this.funkce.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.funkce.Legends.Add(legend1);
            this.funkce.Location = new System.Drawing.Point(94, 124);
            this.funkce.Name = "funkce";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "funkce";
            series1.Points.Add(dataPoint1);
            this.funkce.Series.Add(series1);
            this.funkce.Size = new System.Drawing.Size(543, 232);
            this.funkce.TabIndex = 0;
            this.funkce.Text = "chart1";
            // 
            // Vykresli
            // 
            this.Vykresli.Location = new System.Drawing.Point(482, 372);
            this.Vykresli.Name = "Vykresli";
            this.Vykresli.Size = new System.Drawing.Size(152, 34);
            this.Vykresli.TabIndex = 1;
            this.Vykresli.Text = "Vykresli";
            this.Vykresli.UseVisualStyleBackColor = true;
            this.Vykresli.Click += new System.EventHandler(this.Vykresli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zadejte funkci pro vykreslení:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "f(x)=";
            // 
            // VzorecForm
            // 
            this.VzorecForm.Location = new System.Drawing.Point(124, 47);
            this.VzorecForm.Name = "VzorecForm";
            this.VzorecForm.Size = new System.Drawing.Size(220, 20);
            this.VzorecForm.TabIndex = 5;
            this.VzorecForm.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Počítat od:";
            // 
            // OdForm
            // 
            this.OdForm.Location = new System.Drawing.Point(157, 91);
            this.OdForm.Name = "OdForm";
            this.OdForm.Size = new System.Drawing.Size(100, 20);
            this.OdForm.TabIndex = 7;
            this.OdForm.Text = "0";
            // 
            // KrokForm
            // 
            this.KrokForm.Location = new System.Drawing.Point(330, 91);
            this.KrokForm.Name = "KrokForm";
            this.KrokForm.Size = new System.Drawing.Size(100, 20);
            this.KrokForm.TabIndex = 9;
            this.KrokForm.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "S krokem:";
            // 
            // DoForm
            // 
            this.DoForm.Location = new System.Drawing.Point(503, 91);
            this.DoForm.Name = "DoForm";
            this.DoForm.Size = new System.Drawing.Size(100, 20);
            this.DoForm.TabIndex = 11;
            this.DoForm.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Počítat do:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 448);
            this.Controls.Add(this.DoForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KrokForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OdForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VzorecForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vykresli);
            this.Controls.Add(this.funkce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grafická Kalkulačka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funkce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart funkce;
        private System.Windows.Forms.Button Vykresli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VzorecForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OdForm;
        private System.Windows.Forms.TextBox KrokForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoForm;
        private System.Windows.Forms.Label label5;
    }
}

