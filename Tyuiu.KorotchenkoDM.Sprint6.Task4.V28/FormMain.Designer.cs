
namespace Tyuiu.KorotchenkoDM.Sprint6.Task4.V28
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelData_KDM = new System.Windows.Forms.Panel();
            this.buttonHelp_KDM = new System.Windows.Forms.Button();
            this.buttonSave_KDM = new System.Windows.Forms.Button();
            this.buttonGet_KDM = new System.Windows.Forms.Button();
            this.groupBoxInputData_KDM = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KDM = new System.Windows.Forms.Label();
            this.labelStartStep_KDM = new System.Windows.Forms.Label();
            this.textBoxStopStep_KDM = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KDM = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KDM = new System.Windows.Forms.TextBox();
            this.panelFunction_KDM = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KDM = new System.Windows.Forms.TextBox();
            this.splitter_KDM = new System.Windows.Forms.Splitter();
            this.panelResult_KDM = new System.Windows.Forms.Panel();
            this.chartFunction_KDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelData_KDM.SuspendLayout();
            this.groupBoxInputData_KDM.SuspendLayout();
            this.groupBoxCondition_KDM.SuspendLayout();
            this.panelFunction_KDM.SuspendLayout();
            this.groupBoxOutputData_KDM.SuspendLayout();
            this.panelResult_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData_KDM
            // 
            this.panelData_KDM.Controls.Add(this.buttonHelp_KDM);
            this.panelData_KDM.Controls.Add(this.buttonSave_KDM);
            this.panelData_KDM.Controls.Add(this.buttonGet_KDM);
            this.panelData_KDM.Controls.Add(this.groupBoxInputData_KDM);
            this.panelData_KDM.Controls.Add(this.groupBoxCondition_KDM);
            this.panelData_KDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_KDM.Location = new System.Drawing.Point(0, 0);
            this.panelData_KDM.Name = "panelData_KDM";
            this.panelData_KDM.Size = new System.Drawing.Size(1082, 182);
            this.panelData_KDM.TabIndex = 0;
            // 
            // buttonHelp_KDM
            // 
            this.buttonHelp_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDM.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KDM.Location = new System.Drawing.Point(975, 13);
            this.buttonHelp_KDM.Name = "buttonHelp_KDM";
            this.buttonHelp_KDM.Size = new System.Drawing.Size(104, 62);
            this.buttonHelp_KDM.TabIndex = 4;
            this.buttonHelp_KDM.Text = "Справка";
            this.buttonHelp_KDM.UseVisualStyleBackColor = false;
            this.buttonHelp_KDM.Click += new System.EventHandler(this.buttonHelp_KDM_Click);
            // 
            // buttonSave_KDM
            // 
            this.buttonSave_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_KDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave_KDM.Location = new System.Drawing.Point(858, 13);
            this.buttonSave_KDM.Name = "buttonSave_KDM";
            this.buttonSave_KDM.Size = new System.Drawing.Size(111, 62);
            this.buttonSave_KDM.TabIndex = 3;
            this.buttonSave_KDM.Text = "Сохранить";
            this.buttonSave_KDM.UseVisualStyleBackColor = false;
            this.buttonSave_KDM.Click += new System.EventHandler(this.buttonSave_KDM_Click);
            // 
            // buttonGet_KDM
            // 
            this.buttonGet_KDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGet_KDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGet_KDM.Location = new System.Drawing.Point(736, 13);
            this.buttonGet_KDM.Name = "buttonGet_KDM";
            this.buttonGet_KDM.Size = new System.Drawing.Size(116, 62);
            this.buttonGet_KDM.TabIndex = 2;
            this.buttonGet_KDM.Text = "Выполнить";
            this.buttonGet_KDM.UseVisualStyleBackColor = false;
            this.buttonGet_KDM.Click += new System.EventHandler(this.buttonGet_KDM_Click);
            // 
            // groupBoxInputData_KDM
            // 
            this.groupBoxInputData_KDM.Controls.Add(this.labelStopStep_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.labelStartStep_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.textBoxStopStep_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.textBoxStartStep_KDM);
            this.groupBoxInputData_KDM.Location = new System.Drawing.Point(450, 13);
            this.groupBoxInputData_KDM.Name = "groupBoxInputData_KDM";
            this.groupBoxInputData_KDM.Size = new System.Drawing.Size(280, 163);
            this.groupBoxInputData_KDM.TabIndex = 1;
            this.groupBoxInputData_KDM.TabStop = false;
            this.groupBoxInputData_KDM.Text = "Ввод данных:";
            // 
            // labelStopStep_KDM
            // 
            this.labelStopStep_KDM.AutoSize = true;
            this.labelStopStep_KDM.Location = new System.Drawing.Point(145, 39);
            this.labelStopStep_KDM.Name = "labelStopStep_KDM";
            this.labelStopStep_KDM.Size = new System.Drawing.Size(85, 17);
            this.labelStopStep_KDM.TabIndex = 2;
            this.labelStopStep_KDM.Text = "Конец шага";
            // 
            // labelStartStep_KDM
            // 
            this.labelStartStep_KDM.AutoSize = true;
            this.labelStartStep_KDM.Location = new System.Drawing.Point(6, 39);
            this.labelStartStep_KDM.Name = "labelStartStep_KDM";
            this.labelStartStep_KDM.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KDM.TabIndex = 2;
            this.labelStartStep_KDM.Text = "Старт шага:";
            // 
            // textBoxStopStep_KDM
            // 
            this.textBoxStopStep_KDM.Location = new System.Drawing.Point(148, 59);
            this.textBoxStopStep_KDM.Name = "textBoxStopStep_KDM";
            this.textBoxStopStep_KDM.Size = new System.Drawing.Size(126, 22);
            this.textBoxStopStep_KDM.TabIndex = 1;
            // 
            // textBoxStartStep_KDM
            // 
            this.textBoxStartStep_KDM.Location = new System.Drawing.Point(6, 59);
            this.textBoxStartStep_KDM.Name = "textBoxStartStep_KDM";
            this.textBoxStartStep_KDM.Size = new System.Drawing.Size(125, 22);
            this.textBoxStartStep_KDM.TabIndex = 0;
            // 
            // groupBoxCondition_KDM
            // 
            this.groupBoxCondition_KDM.Controls.Add(this.textBoxCondition_KDM);
            this.groupBoxCondition_KDM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_KDM.Name = "groupBoxCondition_KDM";
            this.groupBoxCondition_KDM.Size = new System.Drawing.Size(432, 164);
            this.groupBoxCondition_KDM.TabIndex = 0;
            this.groupBoxCondition_KDM.TabStop = false;
            this.groupBoxCondition_KDM.Text = "Условие:";
            // 
            // textBoxCondition_KDM
            // 
            this.textBoxCondition_KDM.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_KDM.Multiline = true;
            this.textBoxCondition_KDM.Name = "textBoxCondition_KDM";
            this.textBoxCondition_KDM.ReadOnly = true;
            this.textBoxCondition_KDM.Size = new System.Drawing.Size(420, 143);
            this.textBoxCondition_KDM.TabIndex = 0;
            this.textBoxCondition_KDM.Text = resources.GetString("textBoxCondition_KDM.Text");
            // 
            // panelFunction_KDM
            // 
            this.panelFunction_KDM.Controls.Add(this.groupBoxOutputData_KDM);
            this.panelFunction_KDM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunction_KDM.Location = new System.Drawing.Point(0, 182);
            this.panelFunction_KDM.Name = "panelFunction_KDM";
            this.panelFunction_KDM.Size = new System.Drawing.Size(200, 471);
            this.panelFunction_KDM.TabIndex = 0;
            // 
            // groupBoxOutputData_KDM
            // 
            this.groupBoxOutputData_KDM.Controls.Add(this.textBoxResult_KDM);
            this.groupBoxOutputData_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KDM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_KDM.Name = "groupBoxOutputData_KDM";
            this.groupBoxOutputData_KDM.Size = new System.Drawing.Size(200, 471);
            this.groupBoxOutputData_KDM.TabIndex = 0;
            this.groupBoxOutputData_KDM.TabStop = false;
            this.groupBoxOutputData_KDM.Text = "Вывод:";
            // 
            // textBoxResult_KDM
            // 
            this.textBoxResult_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KDM.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_KDM.Multiline = true;
            this.textBoxResult_KDM.Name = "textBoxResult_KDM";
            this.textBoxResult_KDM.ReadOnly = true;
            this.textBoxResult_KDM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KDM.Size = new System.Drawing.Size(194, 450);
            this.textBoxResult_KDM.TabIndex = 0;
            // 
            // splitter_KDM
            // 
            this.splitter_KDM.Location = new System.Drawing.Point(200, 182);
            this.splitter_KDM.Name = "splitter_KDM";
            this.splitter_KDM.Size = new System.Drawing.Size(3, 471);
            this.splitter_KDM.TabIndex = 0;
            this.splitter_KDM.TabStop = false;
            // 
            // panelResult_KDM
            // 
            this.panelResult_KDM.Controls.Add(this.chartFunction_KDM);
            this.panelResult_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_KDM.Location = new System.Drawing.Point(203, 182);
            this.panelResult_KDM.Name = "panelResult_KDM";
            this.panelResult_KDM.Size = new System.Drawing.Size(879, 471);
            this.panelResult_KDM.TabIndex = 1;
            // 
            // chartFunction_KDM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KDM.ChartAreas.Add(chartArea1);
            this.chartFunction_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_KDM.Legends.Add(legend1);
            this.chartFunction_KDM.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_KDM.Name = "chartFunction_KDM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KDM.Series.Add(series1);
            this.chartFunction_KDM.Size = new System.Drawing.Size(879, 471);
            this.chartFunction_KDM.TabIndex = 0;
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartFunction_KDM.Titles.Add(title1);
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panelResult_KDM);
            this.Controls.Add(this.splitter_KDM);
            this.Controls.Add(this.panelFunction_KDM);
            this.Controls.Add(this.panelData_KDM);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | Коротченко Д.М.";
            this.panelData_KDM.ResumeLayout(false);
            this.groupBoxInputData_KDM.ResumeLayout(false);
            this.groupBoxInputData_KDM.PerformLayout();
            this.groupBoxCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.PerformLayout();
            this.panelFunction_KDM.ResumeLayout(false);
            this.groupBoxOutputData_KDM.ResumeLayout(false);
            this.groupBoxOutputData_KDM.PerformLayout();
            this.panelResult_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData_KDM;
        private System.Windows.Forms.Button buttonHelp_KDM;
        private System.Windows.Forms.Button buttonSave_KDM;
        private System.Windows.Forms.Button buttonGet_KDM;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDM;
        private System.Windows.Forms.GroupBox groupBoxCondition_KDM;
        private System.Windows.Forms.Panel panelFunction_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDM;
        private System.Windows.Forms.TextBox textBoxResult_KDM;
        private System.Windows.Forms.Splitter splitter_KDM;
        private System.Windows.Forms.Panel panelResult_KDM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDM;
        private System.Windows.Forms.TextBox textBoxCondition_KDM;
        private System.Windows.Forms.Label labelStopStep_KDM;
        private System.Windows.Forms.Label labelStartStep_KDM;
        private System.Windows.Forms.TextBox textBoxStopStep_KDM;
        private System.Windows.Forms.TextBox textBoxStartStep_KDM;
    }
}

