using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorotchenkoDM.Sprint6.TaskReview.V10.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.TaskReview.V10
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        private void buttonDone_KDM_Click(object sender, EventArgs e)
        {           
                DataService ds = new DataService();
                Random rnd = new Random();

                int m = Convert.ToInt32(textBoxM_KDM.Text);
                int n = Convert.ToInt32(textBoxN_KDM.Text);
                int n1 = Convert.ToInt32(textBoxn1_KDM.Text);
                int n2 = Convert.ToInt32(textBoxn2_KDM.Text);
                int k = Convert.ToInt32(textBoxK_KDM.Text);
                int l = Convert.ToInt32(textBoxL_KDM.Text);
                int c = Convert.ToInt32(textBoxC_KDM.Text);


                int[,] array = new int[m, n];                
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j % 2 == 0)
                            array[i, j] = rnd.Next(n1, n2 + 1);
                        else
                            array[i, j] = Convert.ToInt32(Math.Pow(array[i, j - 1], 3));
                    }
                }

                dataGridViewMatrix_KDM.ColumnCount = m;
                dataGridViewMatrix_KDM.RowCount = n;

                for (int i = 0; i < m; i++)
                {
                    dataGridViewMatrix_KDM.Columns[i].Width = 25;
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridViewMatrix_KDM.Rows[i].Cells[j].Value = array[i, j];
                    }
                }

                textBoxMin_KDM.Text = Convert.ToString(ds.GetMatrix(array, c, k, l));

                if ((n1 > n2) || (k > l))
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                      
        }        
    }
}
