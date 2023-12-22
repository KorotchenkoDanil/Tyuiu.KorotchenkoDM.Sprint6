
namespace Tyuiu.KorotchenkoDM.Sprint6.Task2.V3
{
    partial class FormMain_KDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KDM));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_KDM = new System.Windows.Forms.GroupBox();
            this.labelCondition_KDM = new System.Windows.Forms.Label();
            this.groupBoxInputData_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KDM = new System.Windows.Forms.TextBox();
            this.textBoxStart_KDM = new System.Windows.Forms.TextBox();
            this.labelStop_KDM = new System.Windows.Forms.Label();
            this.labelStart_KDM = new System.Windows.Forms.Label();
            this.buttonInfo_KDM = new System.Windows.Forms.Button();
            this.buttonDone_KDM = new System.Windows.Forms.Button();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.chartFunction_KDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTable_KDM = new System.Windows.Forms.DataGridView();
            this.X_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_KDM.SuspendLayout();
            this.groupBoxInputData_KDM.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KDM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KDM
            // 
            this.groupBoxCondition_KDM.Controls.Add(this.labelCondition_KDM);
            this.groupBoxCondition_KDM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_KDM.Name = "groupBoxCondition_KDM";
            this.groupBoxCondition_KDM.Size = new System.Drawing.Size(544, 330);
            this.groupBoxCondition_KDM.TabIndex = 0;
            this.groupBoxCondition_KDM.TabStop = false;
            this.groupBoxCondition_KDM.Text = "Условие";
            // 
            // labelCondition_KDM
            // 
            this.labelCondition_KDM.AutoSize = true;
            this.labelCondition_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCondition_KDM.Location = new System.Drawing.Point(3, 18);
            this.labelCondition_KDM.Name = "labelCondition_KDM";
            this.labelCondition_KDM.Size = new System.Drawing.Size(476, 102);
            this.labelCondition_KDM.TabIndex = 0;
            this.labelCondition_KDM.Text = resources.GetString("labelCondition_KDM.Text");
            // 
            // groupBoxInputData_KDM
            // 
            this.groupBoxInputData_KDM.Controls.Add(this.textBoxStop_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.textBoxStart_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.labelStop_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.labelStart_KDM);
            this.groupBoxInputData_KDM.Location = new System.Drawing.Point(12, 348);
            this.groupBoxInputData_KDM.Name = "groupBoxInputData_KDM";
            this.groupBoxInputData_KDM.Size = new System.Drawing.Size(297, 93);
            this.groupBoxInputData_KDM.TabIndex = 1;
            this.groupBoxInputData_KDM.TabStop = false;
            this.groupBoxInputData_KDM.Text = "Ввод данных";
            // 
            // textBoxStop_KDM
            // 
            this.textBoxStop_KDM.Location = new System.Drawing.Point(157, 53);
            this.textBoxStop_KDM.Name = "textBoxStop_KDM";
            this.textBoxStop_KDM.Size = new System.Drawing.Size(134, 22);
            this.textBoxStop_KDM.TabIndex = 1;
            // 
            // textBoxStart_KDM
            // 
            this.textBoxStart_KDM.Location = new System.Drawing.Point(6, 53);
            this.textBoxStart_KDM.Name = "textBoxStart_KDM";
            this.textBoxStart_KDM.Size = new System.Drawing.Size(145, 22);
            this.textBoxStart_KDM.TabIndex = 1;
            // 
            // labelStop_KDM
            // 
            this.labelStop_KDM.AutoSize = true;
            this.labelStop_KDM.Location = new System.Drawing.Point(154, 33);
            this.labelStop_KDM.Name = "labelStop_KDM";
            this.labelStop_KDM.Size = new System.Drawing.Size(85, 17);
            this.labelStop_KDM.TabIndex = 0;
            this.labelStop_KDM.Text = "Конец шага";
            // 
            // labelStart_KDM
            // 
            this.labelStart_KDM.AutoSize = true;
            this.labelStart_KDM.Location = new System.Drawing.Point(6, 33);
            this.labelStart_KDM.Name = "labelStart_KDM";
            this.labelStart_KDM.Size = new System.Drawing.Size(83, 17);
            this.labelStart_KDM.TabIndex = 0;
            this.labelStart_KDM.Text = "Старт шага";
            // 
            // buttonInfo_KDM
            // 
            this.buttonInfo_KDM.BackColor = System.Drawing.Color.Blue;
            this.buttonInfo_KDM.Location = new System.Drawing.Point(315, 370);
            this.buttonInfo_KDM.Name = "buttonInfo_KDM";
            this.buttonInfo_KDM.Size = new System.Drawing.Size(71, 65);
            this.buttonInfo_KDM.TabIndex = 2;
            this.buttonInfo_KDM.Text = "Справка";
            this.buttonInfo_KDM.UseVisualStyleBackColor = false;
            this.buttonInfo_KDM.Click += new System.EventHandler(this.buttonInfo_KDM_Click);
            // 
            // buttonDone_KDM
            // 
            this.buttonDone_KDM.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_KDM.Location = new System.Drawing.Point(392, 370);
            this.buttonDone_KDM.Name = "buttonDone_KDM";
            this.buttonDone_KDM.Size = new System.Drawing.Size(164, 65);
            this.buttonDone_KDM.TabIndex = 3;
            this.buttonDone_KDM.Text = "Выполнить";
            this.buttonDone_KDM.UseVisualStyleBackColor = false;
            this.buttonDone_KDM.Click += new System.EventHandler(this.buttonDone_KDM_Click);
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.chartFunction_KDM);
            this.groupBoxOutputData.Controls.Add(this.dataGridViewTable_KDM);
            this.groupBoxOutputData.Location = new System.Drawing.Point(562, 6);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(708, 429);
            this.groupBoxOutputData.TabIndex = 4;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "вывод данных";
            // 
            // chartFunction_KDM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KDM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KDM.Legends.Add(legend1);
            this.chartFunction_KDM.Location = new System.Drawing.Point(185, 82);
            this.chartFunction_KDM.Name = "chartFunction_KDM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KDM.Series.Add(series1);
            this.chartFunction_KDM.Size = new System.Drawing.Size(517, 341);
            this.chartFunction_KDM.TabIndex = 1;
            this.chartFunction_KDM.Text = "chart1";
            // 
            // dataGridViewTable_KDM
            // 
            this.dataGridViewTable_KDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_KDM,
            this.fx_KDM});
            this.dataGridViewTable_KDM.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewTable_KDM.Name = "dataGridViewTable_KDM";
            this.dataGridViewTable_KDM.ReadOnly = true;
            this.dataGridViewTable_KDM.RowHeadersVisible = false;
            this.dataGridViewTable_KDM.RowHeadersWidth = 51;
            this.dataGridViewTable_KDM.RowTemplate.Height = 24;
            this.dataGridViewTable_KDM.Size = new System.Drawing.Size(173, 402);
            this.dataGridViewTable_KDM.TabIndex = 0;
            // 
            // X_KDM
            // 
            this.X_KDM.HeaderText = "X";
            this.X_KDM.MinimumWidth = 6;
            this.X_KDM.Name = "X_KDM";
            this.X_KDM.ReadOnly = true;
            this.X_KDM.Width = 50;
            // 
            // fx_KDM
            // 
            this.fx_KDM.HeaderText = "f(x)";
            this.fx_KDM.MinimumWidth = 6;
            this.fx_KDM.Name = "fx_KDM";
            this.fx_KDM.ReadOnly = true;
            this.fx_KDM.Width = 50;
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 453);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.buttonDone_KDM);
            this.Controls.Add(this.buttonInfo_KDM);
            this.Controls.Add(this.groupBoxInputData_KDM);
            this.Controls.Add(this.groupBoxCondition_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Коротченко Д.М.";
            this.groupBoxCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.PerformLayout();
            this.groupBoxInputData_KDM.ResumeLayout(false);
            this.groupBoxInputData_KDM.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KDM;
        private System.Windows.Forms.Label labelCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDM;
        private System.Windows.Forms.TextBox textBoxStop_KDM;
        private System.Windows.Forms.TextBox textBoxStart_KDM;
        private System.Windows.Forms.Label labelStop_KDM;
        private System.Windows.Forms.Label labelStart_KDM;
        private System.Windows.Forms.Button buttonInfo_KDM;
        private System.Windows.Forms.Button buttonDone_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDM;
        private System.Windows.Forms.DataGridView dataGridViewTable_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx_KDM;
    }
}

