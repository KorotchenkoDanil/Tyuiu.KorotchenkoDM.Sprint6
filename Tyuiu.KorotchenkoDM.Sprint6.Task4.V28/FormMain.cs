using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint6.Task4.V28.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task4.V28
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonGet_KDM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KDM.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KDM.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KDM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KDM.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KDM.Text = "";

                chartFunction_KDM.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KDM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KDM.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KDM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_KDM.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Коротченко Д.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
