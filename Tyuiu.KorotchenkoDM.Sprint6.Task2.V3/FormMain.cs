using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorotchenkoDM.Sprint6.Task2.V3.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task2.V3
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_KDM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KDM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KDM.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KDM.Titles.Add("График функции");
                this.chartFunction_KDM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KDM.ChartAreas[0].AxisY.Title = "Ось Y";
                
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTable_KDM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KDM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 Коротченко Д.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
