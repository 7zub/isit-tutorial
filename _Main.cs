using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace multi_tutorial
{
    public partial class _Main : Form
    {
        public _Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ЛекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Lec().ShowDialog();
        }

        private void лабораторныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Prakt().ShowDialog();
        }

        private void презентацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Prez().ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"response.docx");
        }

        private void тестыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"test\test.doc");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PrintPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
