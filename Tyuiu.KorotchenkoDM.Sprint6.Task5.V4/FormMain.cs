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
using Tyuiu.KorotchenkoDM.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task5.V4
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint6\Tyuiu.KorotchenkoDM.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
        private void buttonGet_KDM_Click(object sender, EventArgs e)
        {
            dataGridViewValues_KDM.ColumnCount = 2;
            dataGridViewValues_KDM.Columns[0].Width = 20;
            dataGridViewValues_KDM.Columns[1].Width = 50;

            this.chartDiagram_KDM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram_KDM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagram_KDM.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewValues_KDM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagram_KDM.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KDM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-23-1 Коротченко Д.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
