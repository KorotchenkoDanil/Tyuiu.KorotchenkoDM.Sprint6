
namespace Tyuiu.KorotchenkoDM.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCondition_KDM = new System.Windows.Forms.Panel();
            this.groupBoxCondition_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KDM = new System.Windows.Forms.TextBox();
            this.panelOutput_KDM = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_KDM = new System.Windows.Forms.GroupBox();
            this.dataGridViewValues_KDM = new System.Windows.Forms.DataGridView();
            this.splitter_KDM = new System.Windows.Forms.Splitter();
            this.panelDiagram_KDM = new System.Windows.Forms.Panel();
            this.groupBoxDiagram_KDM = new System.Windows.Forms.GroupBox();
            this.chartDiagram_KDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGet_KDM = new System.Windows.Forms.Button();
            this.buttonOpen_KDM = new System.Windows.Forms.Button();
            this.buttonHelp_KDM = new System.Windows.Forms.Button();
            this.ColumnValue_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndex_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCondition_KDM.SuspendLayout();
            this.groupBoxCondition_KDM.SuspendLayout();
            this.panelOutput_KDM.SuspendLayout();
            this.groupBoxOutputData_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_KDM)).BeginInit();
            this.panelDiagram_KDM.SuspendLayout();
            this.groupBoxDiagram_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_KDM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition_KDM
            // 
            this.panelCondition_KDM.Controls.Add(this.buttonHelp_KDM);
            this.panelCondition_KDM.Controls.Add(this.buttonOpen_KDM);
            this.panelCondition_KDM.Controls.Add(this.buttonGet_KDM);
            this.panelCondition_KDM.Controls.Add(this.groupBoxCondition_KDM);
            this.panelCondition_KDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_KDM.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_KDM.Name = "panelCondition_KDM";
            this.panelCondition_KDM.Size = new System.Drawing.Size(982, 106);
            this.panelCondition_KDM.TabIndex = 0;
            // 
            // groupBoxCondition_KDM
            // 
            this.groupBoxCondition_KDM.Controls.Add(this.textBoxCondition_KDM);
            this.groupBoxCondition_KDM.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_KDM.Name = "groupBoxCondition_KDM";
            this.groupBoxCondition_KDM.Size = new System.Drawing.Size(654, 100);
            this.groupBoxCondition_KDM.TabIndex = 0;
            this.groupBoxCondition_KDM.TabStop = false;
            this.groupBoxCondition_KDM.Text = "Условие";
            // 
            // textBoxCondition_KDM
            // 
            this.textBoxCondition_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_KDM.Location = new System.Drawing.Point(3, 18);
            this.textBoxCondition_KDM.Multiline = true;
            this.textBoxCondition_KDM.Name = "textBoxCondition_KDM";
            this.textBoxCondition_KDM.ReadOnly = true;
            this.textBoxCondition_KDM.Size = new System.Drawing.Size(648, 79);
            this.textBoxCondition_KDM.TabIndex = 0;
            this.textBoxCondition_KDM.Text = resources.GetString("textBoxCondition_KDM.Text");
            // 
            // panelOutput_KDM
            // 
            this.panelOutput_KDM.Controls.Add(this.groupBoxOutputData_KDM);
            this.panelOutput_KDM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutput_KDM.Location = new System.Drawing.Point(0, 106);
            this.panelOutput_KDM.Name = "panelOutput_KDM";
            this.panelOutput_KDM.Size = new System.Drawing.Size(200, 447);
            this.panelOutput_KDM.TabIndex = 0;
            // 
            // groupBoxOutputData_KDM
            // 
            this.groupBoxOutputData_KDM.Controls.Add(this.dataGridViewValues_KDM);
            this.groupBoxOutputData_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KDM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_KDM.Name = "groupBoxOutputData_KDM";
            this.groupBoxOutputData_KDM.Size = new System.Drawing.Size(200, 447);
            this.groupBoxOutputData_KDM.TabIndex = 0;
            this.groupBoxOutputData_KDM.TabStop = false;
            this.groupBoxOutputData_KDM.Text = "Вывод данных";
            // 
            // dataGridViewValues_KDM
            // 
            this.dataGridViewValues_KDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues_KDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnValue_KDM,
            this.ColumnIndex_KDM});
            this.dataGridViewValues_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewValues_KDM.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewValues_KDM.Name = "dataGridViewValues_KDM";
            this.dataGridViewValues_KDM.ReadOnly = true;
            this.dataGridViewValues_KDM.RowHeadersVisible = false;
            this.dataGridViewValues_KDM.RowHeadersWidth = 51;
            this.dataGridViewValues_KDM.RowTemplate.Height = 24;
            this.dataGridViewValues_KDM.Size = new System.Drawing.Size(194, 426);
            this.dataGridViewValues_KDM.TabIndex = 0;
            // 
            // splitter_KDM
            // 
            this.splitter_KDM.Location = new System.Drawing.Point(200, 106);
            this.splitter_KDM.Name = "splitter_KDM";
            this.splitter_KDM.Size = new System.Drawing.Size(3, 447);
            this.splitter_KDM.TabIndex = 2;
            this.splitter_KDM.TabStop = false;
            // 
            // panelDiagram_KDM
            // 
            this.panelDiagram_KDM.Controls.Add(this.groupBoxDiagram_KDM);
            this.panelDiagram_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagram_KDM.Location = new System.Drawing.Point(203, 106);
            this.panelDiagram_KDM.Name = "panelDiagram_KDM";
            this.panelDiagram_KDM.Size = new System.Drawing.Size(779, 447);
            this.panelDiagram_KDM.TabIndex = 3;
            // 
            // groupBoxDiagram_KDM
            // 
            this.groupBoxDiagram_KDM.Controls.Add(this.chartDiagram_KDM);
            this.groupBoxDiagram_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDiagram_KDM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDiagram_KDM.Name = "groupBoxDiagram_KDM";
            this.groupBoxDiagram_KDM.Size = new System.Drawing.Size(779, 447);
            this.groupBoxDiagram_KDM.TabIndex = 0;
            this.groupBoxDiagram_KDM.TabStop = false;
            this.groupBoxDiagram_KDM.Text = "Диаграмма";
            // 
            // chartDiagram_KDM
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiagram_KDM.ChartAreas.Add(chartArea2);
            this.chartDiagram_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiagram_KDM.Legends.Add(legend2);
            this.chartDiagram_KDM.Location = new System.Drawing.Point(3, 18);
            this.chartDiagram_KDM.Name = "chartDiagram_KDM";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiagram_KDM.Series.Add(series2);
            this.chartDiagram_KDM.Size = new System.Drawing.Size(773, 426);
            this.chartDiagram_KDM.TabIndex = 0;
            this.chartDiagram_KDM.Text = "chart1";
            // 
            // buttonGet_KDM
            // 
            this.buttonGet_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGet_KDM.BackColor = System.Drawing.Color.Lime;
            this.buttonGet_KDM.Location = new System.Drawing.Point(663, 12);
            this.buttonGet_KDM.Name = "buttonGet_KDM";
            this.buttonGet_KDM.Size = new System.Drawing.Size(106, 71);
            this.buttonGet_KDM.TabIndex = 1;
            this.buttonGet_KDM.Text = "Выполнить";
            this.buttonGet_KDM.UseVisualStyleBackColor = false;
            this.buttonGet_KDM.Click += new System.EventHandler(this.buttonGet_KDM_Click);
            // 
            // buttonOpen_KDM
            // 
            this.buttonOpen_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpen_KDM.Location = new System.Drawing.Point(775, 12);
            this.buttonOpen_KDM.Name = "buttonOpen_KDM";
            this.buttonOpen_KDM.Size = new System.Drawing.Size(104, 71);
            this.buttonOpen_KDM.TabIndex = 1;
            this.buttonOpen_KDM.Text = "Открыть файл";
            this.buttonOpen_KDM.UseVisualStyleBackColor = false;
            this.buttonOpen_KDM.Click += new System.EventHandler(this.buttonOpen_KDM_Click);
            // 
            // buttonHelp_KDM
            // 
            this.buttonHelp_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDM.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KDM.Location = new System.Drawing.Point(885, 12);
            this.buttonHelp_KDM.Name = "buttonHelp_KDM";
            this.buttonHelp_KDM.Size = new System.Drawing.Size(94, 71);
            this.buttonHelp_KDM.TabIndex = 1;
            this.buttonHelp_KDM.Text = "Справка";
            this.buttonHelp_KDM.UseVisualStyleBackColor = false;
            this.buttonHelp_KDM.Click += new System.EventHandler(this.buttonHelp_KDM_Click);
            // 
            // ColumnValue_KDM
            // 
            this.ColumnValue_KDM.HeaderText = "";
            this.ColumnValue_KDM.MinimumWidth = 6;
            this.ColumnValue_KDM.Name = "ColumnValue_KDM";
            this.ColumnValue_KDM.ReadOnly = true;
            this.ColumnValue_KDM.Width = 40;
            // 
            // ColumnIndex_KDM
            // 
            this.ColumnIndex_KDM.HeaderText = "";
            this.ColumnIndex_KDM.MinimumWidth = 6;
            this.ColumnIndex_KDM.Name = "ColumnIndex_KDM";
            this.ColumnIndex_KDM.ReadOnly = true;
            this.ColumnIndex_KDM.Width = 90;
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelDiagram_KDM);
            this.Controls.Add(this.splitter_KDM);
            this.Controls.Add(this.panelOutput_KDM);
            this.Controls.Add(this.panelCondition_KDM);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Коротченко Д.М.";
            this.panelCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.PerformLayout();
            this.panelOutput_KDM.ResumeLayout(false);
            this.groupBoxOutputData_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_KDM)).EndInit();
            this.panelDiagram_KDM.ResumeLayout(false);
            this.groupBoxDiagram_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_KDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxCondition_KDM;
        private System.Windows.Forms.Panel panelOutput_KDM;
        private System.Windows.Forms.Splitter splitter_KDM;
        private System.Windows.Forms.Panel panelDiagram_KDM;
        private System.Windows.Forms.TextBox textBoxCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDM;
        private System.Windows.Forms.DataGridView dataGridViewValues_KDM;
        private System.Windows.Forms.GroupBox groupBoxDiagram_KDM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_KDM;
        private System.Windows.Forms.Button buttonHelp_KDM;
        private System.Windows.Forms.Button buttonOpen_KDM;
        private System.Windows.Forms.Button buttonGet_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex_KDM;
    }
}

