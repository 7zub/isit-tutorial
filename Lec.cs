using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace multi_tutorial
{
    public partial class Lec : Form
    {
        public Lec()
        {
            InitializeComponent();
        }

        private void Lec_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo("./lec");
            FileInfo[] files = info.GetFiles();
            listBox1.Items.AddRange(files);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                Process.Start(@"lec\" + listBox1.SelectedItem.ToString());
            else
                MessageBox.Show("Не выбран файл для чтения!");
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                File.Delete(@"lec\" + listBox1.SelectedItem.ToString());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SetSelected(0, true);
            } else
                MessageBox.Show("Не выбран файл для удаления!");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new edit_lec(this).ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
