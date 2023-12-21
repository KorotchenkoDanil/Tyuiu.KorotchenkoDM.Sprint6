
namespace Tyuiu.KorotchenkoDM.Sprint6.Task1.V20
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
            this.groupBoxCondition_KDM = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOutput_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KDM = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KDM = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KDM = new System.Windows.Forms.TextBox();
            this.textBoxStart_KDM = new System.Windows.Forms.TextBox();
            this.labelStop_KDM = new System.Windows.Forms.Label();
            this.labelStart_KDM = new System.Windows.Forms.Label();
            this.buttonInfo_KDM = new System.Windows.Forms.Button();
            this.buttonDone_KDM = new System.Windows.Forms.Button();
            this.groupBoxCondition_KDM.SuspendLayout();
            this.groupBoxOutput_KDM.SuspendLayout();
            this.groupBoxInput_KDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KDM
            // 
            this.groupBoxCondition_KDM.Controls.Add(this.label1);
            this.groupBoxCondition_KDM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_KDM.Name = "groupBoxCondition_KDM";
            this.groupBoxCondition_KDM.Size = new System.Drawing.Size(467, 318);
            this.groupBoxCondition_KDM.TabIndex = 0;
            this.groupBoxCondition_KDM.TabStop = false;
            this.groupBoxCondition_KDM.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxOutput_KDM
            // 
            this.groupBoxOutput_KDM.Controls.Add(this.textBoxResult_KDM);
            this.groupBoxOutput_KDM.Location = new System.Drawing.Point(485, 12);
            this.groupBoxOutput_KDM.Name = "groupBoxOutput_KDM";
            this.groupBoxOutput_KDM.Size = new System.Drawing.Size(303, 426);
            this.groupBoxOutput_KDM.TabIndex = 1;
            this.groupBoxOutput_KDM.TabStop = false;
            this.groupBoxOutput_KDM.Text = "Вывод данных";
            // 
            // textBoxResult_KDM
            // 
            this.textBoxResult_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KDM.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KDM.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_KDM.Multiline = true;
            this.textBoxResult_KDM.Name = "textBoxResult_KDM";
            this.textBoxResult_KDM.ReadOnly = true;
            this.textBoxResult_KDM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KDM.Size = new System.Drawing.Size(297, 405);
            this.textBoxResult_KDM.TabIndex = 0;
            // 
            // groupBoxInput_KDM
            // 
            this.groupBoxInput_KDM.Controls.Add(this.textBoxStop_KDM);
            this.groupBoxInput_KDM.Controls.Add(this.textBoxStart_KDM);
            this.groupBoxInput_KDM.Controls.Add(this.labelStop_KDM);
            this.groupBoxInput_KDM.Controls.Add(this.labelStart_KDM);
            this.groupBoxInput_KDM.Location = new System.Drawing.Point(12, 336);
            this.groupBoxInput_KDM.Name = "groupBoxInput_KDM";
            this.groupBoxInput_KDM.Size = new System.Drawing.Size(274, 102);
            this.groupBoxInput_KDM.TabIndex = 2;
            this.groupBoxInput_KDM.TabStop = false;
            this.groupBoxInput_KDM.Text = "Ввод данных";
            // 
            // textBoxStop_KDM
            // 
            this.textBoxStop_KDM.Location = new System.Drawing.Point(138, 53);
            this.textBoxStop_KDM.Name = "textBoxStop_KDM";
            this.textBoxStop_KDM.Size = new System.Drawing.Size(124, 22);
            this.textBoxStop_KDM.TabIndex = 1;
            // 
            // textBoxStart_KDM
            // 
            this.textBoxStart_KDM.Location = new System.Drawing.Point(6, 53);
            this.textBoxStart_KDM.Name = "textBoxStart_KDM";
            this.textBoxStart_KDM.Size = new System.Drawing.Size(126, 22);
            this.textBoxStart_KDM.TabIndex = 1;
            // 
            // labelStop_KDM
            // 
            this.labelStop_KDM.AutoSize = true;
            this.labelStop_KDM.Location = new System.Drawing.Point(135, 33);
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
            this.buttonInfo_KDM.Location = new System.Drawing.Point(292, 351);
            this.buttonInfo_KDM.Name = "buttonInfo_KDM";
            this.buttonInfo_KDM.Size = new System.Drawing.Size(80, 60);
            this.buttonInfo_KDM.TabIndex = 3;
            this.buttonInfo_KDM.Text = "Справка";
            this.buttonInfo_KDM.UseVisualStyleBackColor = false;
            this.buttonInfo_KDM.Click += new System.EventHandler(this.buttonInfo_KDM_Click);
            // 
            // buttonDone_KDM
            // 
            this.buttonDone_KDM.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_KDM.Location = new System.Drawing.Point(378, 351);
            this.buttonDone_KDM.Name = "buttonDone_KDM";
            this.buttonDone_KDM.Size = new System.Drawing.Size(101, 60);
            this.buttonDone_KDM.TabIndex = 3;
            this.buttonDone_KDM.Text = "Выполнить";
            this.buttonDone_KDM.UseVisualStyleBackColor = false;
            this.buttonDone_KDM.Click += new System.EventHandler(this.buttonDone_KDM_Click);
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.buttonDone_KDM);
            this.Controls.Add(this.buttonInfo_KDM);
            this.Controls.Add(this.groupBoxInput_KDM);
            this.Controls.Add(this.groupBoxOutput_KDM);
            this.Controls.Add(this.groupBoxCondition_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Коротченко Д.М.";
            this.groupBoxCondition_KDM.ResumeLayout(false);
            this.groupBoxCondition_KDM.PerformLayout();
            this.groupBoxOutput_KDM.ResumeLayout(false);
            this.groupBoxOutput_KDM.PerformLayout();
            this.groupBoxInput_KDM.ResumeLayout(false);
            this.groupBoxInput_KDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutput_KDM;
        private System.Windows.Forms.TextBox textBoxResult_KDM;
        private System.Windows.Forms.GroupBox groupBoxInput_KDM;
        private System.Windows.Forms.TextBox textBoxStop_KDM;
        private System.Windows.Forms.TextBox textBoxStart_KDM;
        private System.Windows.Forms.Label labelStop_KDM;
        private System.Windows.Forms.Label labelStart_KDM;
        private System.Windows.Forms.Button buttonInfo_KDM;
        private System.Windows.Forms.Button buttonDone_KDM;
        private System.Windows.Forms.Label label1;
    }
}

