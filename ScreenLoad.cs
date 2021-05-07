using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace multi_tutorial
{
    public partial class Screen_load : Form
    {
        public Screen_load()
        {
            InitializeComponent();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _Main Mainform = new _Main();
           
            this.Hide();
            timer1.Stop();
            Mainform.Show();
        }
    }
}
