
namespace Tyuiu.KorotchenkoDM.Sprint6.Task0.V4
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
            this.groupBoxCondition_KDM = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_KDM = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_KDM = new System.Windows.Forms.GroupBox();
            this.buttonGet_KDM = new System.Windows.Forms.Button();
            this.labelCondition_KDM = new System.Windows.Forms.Label();
            this.labelExample_KDM = new System.Windows.Forms.Label();
            this.labelVarX_KDM = new System.Windows.Forms.Label();
            this.textBoxVarX_KDM = new System.Windows.Forms.TextBox();
            this.textBoxResult_KDM = new System.Windows.Forms.TextBox();
            this.labelResult_KDM = new System.Windows.Forms.Label();
            this.groupBoxCondition_KDM.SuspendLayout();
            this.groupBoxInputData_KDM.SuspendLayout();
            this.groupBoxOutputData_KDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KDM
            // 
            this.groupBoxCondition_KDM.Controls.Add(this.labelExample_KDM);
            this.groupBoxCondition_KDM.Controls.Add(this.labelCondition_KDM);
            this.groupBoxCondition_KDM.Location = new System.Drawing.Point(10, 12);
            this.groupBoxCondition_KDM.Name = "groupBoxCondition_KDM";
            this.groupBoxCondition_KDM.Size = new System.Drawing.Size(778, 259);
            this.groupBoxCondition_KDM.TabIndex = 0;
            this.groupBoxCondition_KDM.TabStop = false;
            this.groupBoxCondition_KDM.Text = "Условие";
            // 
            // groupBoxInputData_KDM
            // 
            this.groupBoxInputData_KDM.Controls.Add(this.textBoxVarX_KDM);
            this.groupBoxInputData_KDM.Controls.Add(this.labelVarX_KDM);
            this.groupBoxInputData_KDM.Location = new System.Drawing.Point(12, 277);
            this.groupBoxInputData_KDM.Name = "groupBoxInputData_KDM";
            this.groupBoxInputData_KDM.Size = new System.Drawing.Size(523, 100);
            this.groupBoxInputData_KDM.TabIndex = 1;
            this.groupBoxInputData_KDM.TabStop = false;
            this.groupBoxInputData_KDM.Text = "Ввод данных";
            // 
            // groupBoxOutputData_KDM
            // 
            this.groupBoxOutputData_KDM.Controls.Add(this.labelResult_KDM);
            this.groupBoxOutputData_KDM.Controls.Add(this.textBoxResult_KDM);
            this.groupBoxOutputData_KDM.Location = new System.Drawing.Point(541, 277);
            this.groupBoxOutputData_KDM.Name = "groupBoxOutputData_KDM";
            this.groupBoxOutputData_KDM.Size = new System.Drawing.Size(247, 100);
            this.groupBoxOutputData_KDM.TabIndex = 2;
            this.groupBoxOutputData_KDM.TabStop = false;
            this.groupBoxOutputData_KDM.Text = "Вывод данных";
            // 
            // buttonGet_KDM
            // 
            this.buttonGet_KDM.Location = new System.Drawing.Point(541, 383);
            this.buttonGet_KDM.Name = "buttonGet_KDM";
            this.buttonGet_KDM.Size = new System.Drawing.Size(247, 41);
            this.buttonGet_KDM.TabIndex = 3;
            this.buttonGet_KDM.Text = "Выполнить";
            this.buttonGet_KDM.UseVisualStyleBackColor = true;
            this.buttonGet_KDM.Click += new System.EventHandler(this.buttonGet_KDM_Click);
            // 
            // labelCondition_KDM
            // 
            this.labelCondition_KDM.AutoSize = true;
            this.labelCondition_KDM.Location = new System.Drawing.Point(7, 33);
            this.labelCondition_KDM.Name = "labelCondition_KDM";
            this.labelCondition_KDM.Size = new System.Drawing.Size(241, 17);
            this.labelCondition_KDM.TabIndex = 0;
            this.labelCondition_KDM.Text = "Вычислить выражение по формуле";
            // 
            // labelExample_KDM
            // 
            this.labelExample_KDM.AutoSize = true;
            this.labelExample_KDM.Location = new System.Drawing.Point(7, 50);
            this.labelExample_KDM.Name = "labelExample_KDM";
            this.labelExample_KDM.Size = new System.Drawing.Size(221, 17);
            this.labelExample_KDM.TabIndex = 1;
            this.labelExample_KDM.Text = "F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1";
            // 
            // labelVarX_KDM
            // 
            this.labelVarX_KDM.AutoSize = true;
            this.labelVarX_KDM.Location = new System.Drawing.Point(4, 33);
            this.labelVarX_KDM.Name = "labelVarX_KDM";
            this.labelVarX_KDM.Size = new System.Drawing.Size(104, 17);
            this.labelVarX_KDM.TabIndex = 0;
            this.labelVarX_KDM.Text = "Переменная X";
            // 
            // textBoxVarX_KDM
            // 
            this.textBoxVarX_KDM.Location = new System.Drawing.Point(8, 53);
            this.textBoxVarX_KDM.Name = "textBoxVarX_KDM";
            this.textBoxVarX_KDM.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_KDM.TabIndex = 1;
            this.textBoxVarX_KDM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KDM_KeyPress);
            // 
            // textBoxResult_KDM
            // 
            this.textBoxResult_KDM.Location = new System.Drawing.Point(6, 53);
            this.textBoxResult_KDM.Name = "textBoxResult_KDM";
            this.textBoxResult_KDM.ReadOnly = true;
            this.textBoxResult_KDM.Size = new System.Drawing.Size(235, 22);
            this.textBoxResult_KDM.TabIndex = 0;
            // 
            // labelResult_KDM
            // 
            this.labelResult_KDM.AutoSize = true;
            this.labelResult_KDM.Location = new System.Drawing.Point(6, 33);
            this.labelResult_KDM.Name = "labelResult_KDM";
            this.labelResult_KDM.Size = new System.Drawing.Size(76, 17);
            this.labelResult_KDM.TabIndex = 1;
            this.labelResult_KDM.Text = "Результат";
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGet_KDM);
            this.Controls.Add(this.groupBoxOutputData_KDM);
            this.Controls.Add(this.groupBoxInputData_KDM);
            this.Controls.Add(this.groupBoxCondition_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 4 | Коротченко Д.М.";
            this.groupBoxCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.PerformLayout();
            this.groupBoxInputData_KDM.ResumeLayout(false);
            this.groupBoxInputData_KDM.PerformLayout();
            this.groupBoxOutputData_KDM.ResumeLayout(false);
            this.groupBoxOutputData_KDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KDM;
        private System.Windows.Forms.Label labelExample_KDM;
        private System.Windows.Forms.Label labelCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDM;
        private System.Windows.Forms.TextBox textBoxVarX_KDM;
        private System.Windows.Forms.Label labelVarX_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDM;
        private System.Windows.Forms.Label labelResult_KDM;
        private System.Windows.Forms.TextBox textBoxResult_KDM;
        private System.Windows.Forms.Button buttonGet_KDM;
    }
}

