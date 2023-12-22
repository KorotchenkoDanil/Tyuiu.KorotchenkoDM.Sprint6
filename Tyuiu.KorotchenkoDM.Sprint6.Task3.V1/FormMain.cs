using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorotchenkoDM.Sprint6.Task3.V1.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task3.V1
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 25, 20, 28, 2, 6},
                                      { 19, 9, 18, -7, 24},
                                      { 21, 16, 5, -7, -8},
                                      { 30, -13, 1, -15, 2 },
                                      { 31, 9, -3, -9, -18 } };
        private void buttonDone_KDM_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewResult_KDM.ColumnCount = columns;
            dataGridViewResult_KDM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KDM.Columns[i].Width = 25;
            }
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KDM.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_KDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Коротченко Д.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_KDM_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_KDM.ColumnCount = columns;
            dataGridViewMatrix_KDM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KDM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KDM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
