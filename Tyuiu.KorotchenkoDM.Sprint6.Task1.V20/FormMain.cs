using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorotchenkoDM.Sprint6.Task1.V20.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task1.V20
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_KDM.Text = "";
                textBoxResult_KDM.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KDM.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_KDM.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0, 5:d}     |   {1, 5:f2}  |", startStep, valueArray[i]);
                    textBoxResult_KDM.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KDM.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Коротченко Д.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
