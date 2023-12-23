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
using Tyuiu.KorotchenkoDM.Sprint6.Task7.V23.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task7.V23
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();

            openFileDialogTask_KDM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KDM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_KDM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDM.ShowDialog();
            openFilePath = openFileDialogTask_KDM.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KDM.ColumnCount = columns;
            dataGridViewIn_KDM.RowCount = rows;
            dataGridViewOut_KDM.ColumnCount = columns;
            dataGridViewOut_KDM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KDM.Columns[i].Width = 25;
                dataGridViewOut_KDM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_KDM.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_KDM.Enabled = true;
        }

        private void buttonDone_KDM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_KDM.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSaveFile_KDM.Enabled = true;
        }

        private void buttonSaveFile_KDM_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KDM.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KDM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KDM.ShowDialog();

            string path = saveFileDialogMatrix_KDM.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
                File.Delete(path);

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j= 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str = str + dataGridViewOut_KDM.Rows[i].Cells[j].Value + ";";
                    else
                        str = str + dataGridViewOut_KDM.Rows[i].Cells[j].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_KDM_Click(object sender, EventArgs e)
        {
            FormAbout_KDM formAbout = new FormAbout_KDM();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KDM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KDM.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KDM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KDM.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KDM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KDM.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KDM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KDM.ToolTipTitle = "О программе";
        }
    }
}
