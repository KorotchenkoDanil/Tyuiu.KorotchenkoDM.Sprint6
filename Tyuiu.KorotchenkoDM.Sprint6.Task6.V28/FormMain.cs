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
using Tyuiu.KorotchenkoDM.Sprint6.Task6.V28.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task6.V28
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_KDM_Click(object sender, EventArgs e)
        {
            openFileDialog_KDM.ShowDialog();
            openFilePath = openFileDialog_KDM.FileName;
            textBoxIn_KDM.Text = File.ReadAllText(openFilePath);
            groupBoxIn_KDM.Text = groupBoxIn_KDM.Text + " " + openFileDialog_KDM.FileName;
            buttonGet_KDM.Enabled = true;
        }

        private void buttonGet_KDM_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_KDM.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_KDM_Click(object sender, EventArgs e)
        {
            FormAbout_KDM formAbout = new FormAbout_KDM();
            formAbout.ShowDialog();
        }
    }
}
