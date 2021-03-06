using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace multi_tutorial
{
    public partial class Prez : Form
    {
        public Prez()
        {
            InitializeComponent();
        }

        private void Prez_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo("./prez");
            FileInfo[] files = info.GetFiles();
            listBox2.Items.AddRange(files);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
                Process.Start(@"prez\" + listBox2.SelectedItem.ToString());
            else
                MessageBox.Show("Не выбран файл для чтения!");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                File.Delete(@"prez\" + listBox2.SelectedItem.ToString());
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.SetSelected(0, true);
            }
            else
                MessageBox.Show("Не выбран файл для удаления!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new edit_prez(this).ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
