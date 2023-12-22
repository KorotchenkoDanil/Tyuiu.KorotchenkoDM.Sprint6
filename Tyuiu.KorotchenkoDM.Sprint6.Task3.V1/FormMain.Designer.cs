
namespace Tyuiu.KorotchenkoDM.Sprint6.Task3.V1
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
            this.groupBoxInputData_KDM = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_KDM = new System.Windows.Forms.GroupBox();
            this.buttonHelp_KDM = new System.Windows.Forms.Button();
            this.buttonDone_KDM = new System.Windows.Forms.Button();
            this.labelCondition_KDM = new System.Windows.Forms.Label();
            this.dataGridViewMatrix_KDM = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_KDM = new System.Windows.Forms.DataGridView();
            this.groupBoxInputData_KDM.SuspendLayout();
            this.groupBoxOutputData_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputData_KDM
            // 
            this.groupBoxInputData_KDM.Controls.Add(this.dataGridViewMatrix_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.labelCondition_KDM);
            this.groupBoxInputData_KDM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInputData_KDM.Name = "groupBoxInputData_KDM";
            this.groupBoxInputData_KDM.Size = new System.Drawing.Size(654, 378);
            this.groupBoxInputData_KDM.TabIndex = 0;
            this.groupBoxInputData_KDM.TabStop = false;
            this.groupBoxInputData_KDM.Text = "Условие";
            // 
            // groupBoxOutputData_KDM
            // 
            this.groupBoxOutputData_KDM.Controls.Add(this.dataGridViewResult_KDM);
            this.groupBoxOutputData_KDM.Location = new System.Drawing.Point(676, 13);
            this.groupBoxOutputData_KDM.Name = "groupBoxOutputData_KDM";
            this.groupBoxOutputData_KDM.Size = new System.Drawing.Size(294, 314);
            this.groupBoxOutputData_KDM.TabIndex = 1;
            this.groupBoxOutputData_KDM.TabStop = false;
            this.groupBoxOutputData_KDM.Text = "Вывод данных";
            // 
            // buttonHelp_KDM
            // 
            this.buttonHelp_KDM.Location = new System.Drawing.Point(776, 333);
            this.buttonHelp_KDM.Name = "buttonHelp_KDM";
            this.buttonHelp_KDM.Size = new System.Drawing.Size(56, 58);
            this.buttonHelp_KDM.TabIndex = 2;
            this.buttonHelp_KDM.Text = "?";
            this.buttonHelp_KDM.UseVisualStyleBackColor = true;
            this.buttonHelp_KDM.Click += new System.EventHandler(this.buttonHelp_KDM_Click);
            // 
            // buttonDone_KDM
            // 
            this.buttonDone_KDM.Location = new System.Drawing.Point(838, 333);
            this.buttonDone_KDM.Name = "buttonDone_KDM";
            this.buttonDone_KDM.Size = new System.Drawing.Size(132, 58);
            this.buttonDone_KDM.TabIndex = 2;
            this.buttonDone_KDM.Text = "Выполнить";
            this.buttonDone_KDM.UseVisualStyleBackColor = true;
            this.buttonDone_KDM.Click += new System.EventHandler(this.buttonDone_KDM_Click);
            // 
            // labelCondition_KDM
            // 
            this.labelCondition_KDM.AutoSize = true;
            this.labelCondition_KDM.Location = new System.Drawing.Point(7, 22);
            this.labelCondition_KDM.Name = "labelCondition_KDM";
            this.labelCondition_KDM.Size = new System.Drawing.Size(373, 136);
            this.labelCondition_KDM.TabIndex = 0;
            this.labelCondition_KDM.Text = resources.GetString("labelCondition_KDM.Text");
            // 
            // dataGridViewMatrix_KDM
            // 
            this.dataGridViewMatrix_KDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KDM.Location = new System.Drawing.Point(386, 21);
            this.dataGridViewMatrix_KDM.Name = "dataGridViewMatrix_KDM";
            this.dataGridViewMatrix_KDM.ReadOnly = true;
            this.dataGridViewMatrix_KDM.RowHeadersVisible = false;
            this.dataGridViewMatrix_KDM.RowHeadersWidth = 51;
            this.dataGridViewMatrix_KDM.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KDM.Size = new System.Drawing.Size(261, 241);
            this.dataGridViewMatrix_KDM.TabIndex = 1;
            // 
            // dataGridViewResult_KDM
            // 
            this.dataGridViewResult_KDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KDM.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewResult_KDM.Name = "dataGridViewResult_KDM";
            this.dataGridViewResult_KDM.ReadOnly = true;
            this.dataGridViewResult_KDM.RowHeadersVisible = false;
            this.dataGridViewResult_KDM.RowHeadersWidth = 51;
            this.dataGridViewResult_KDM.RowTemplate.Height = 24;
            this.dataGridViewResult_KDM.Size = new System.Drawing.Size(260, 240);
            this.dataGridViewResult_KDM.TabIndex = 0;
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 403);
            this.Controls.Add(this.buttonDone_KDM);
            this.Controls.Add(this.buttonHelp_KDM);
            this.Controls.Add(this.groupBoxOutputData_KDM);
            this.Controls.Add(this.groupBoxInputData_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDM";
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 | Коротченко Д.М.";
            this.Load += new System.EventHandler(this.FormMain_KDM_Load);
            this.groupBoxInputData_KDM.ResumeLayout(false);
            this.groupBoxInputData_KDM.PerformLayout();
            this.groupBoxOutputData_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData_KDM;
        private System.Windows.Forms.Label labelCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDM;
        private System.Windows.Forms.Button buttonHelp_KDM;
        private System.Windows.Forms.Button buttonDone_KDM;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KDM;
        private System.Windows.Forms.DataGridView dataGridViewResult_KDM;
    }
}

