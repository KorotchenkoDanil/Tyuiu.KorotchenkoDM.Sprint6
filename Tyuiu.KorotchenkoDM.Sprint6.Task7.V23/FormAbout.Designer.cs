
namespace Tyuiu.KorotchenkoDM.Sprint6.Task7.V23
{
    partial class FormAbout_KDM
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
            this.labelInfo_KDM = new System.Windows.Forms.Label();
            this.buttonOk_KDM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_KDM
            // 
            this.labelInfo_KDM.AutoSize = true;
            this.labelInfo_KDM.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_KDM.Name = "labelInfo_KDM";
            this.labelInfo_KDM.Size = new System.Drawing.Size(310, 34);
            this.labelInfo_KDM.TabIndex = 1;
            this.labelInfo_KDM.Text = "Таск 7 выполнил студент группы ИСТНб-23-1\r\nКоротченко Д.М.";
            // 
            // buttonOk_KDM
            // 
            this.buttonOk_KDM.Location = new System.Drawing.Point(271, 107);
            this.buttonOk_KDM.Name = "buttonOk_KDM";
            this.buttonOk_KDM.Size = new System.Drawing.Size(99, 34);
            this.buttonOk_KDM.TabIndex = 2;
            this.buttonOk_KDM.Text = "Ok";
            this.buttonOk_KDM.UseVisualStyleBackColor = true;
            this.buttonOk_KDM.Click += new System.EventHandler(this.buttonOk_KDM_Click);
            // 
            // FormAbout_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.buttonOk_KDM);
            this.Controls.Add(this.labelInfo_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAbout_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_KDM;
        private System.Windows.Forms.Button buttonOk_KDM;
    }
}