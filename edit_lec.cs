using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace multi_tutorial
{
    public partial class edit_lec : Form
    {
        public static string filename;
        private Lec lec;

        public edit_lec(Lec b)
        {
            lec = b;
            InitializeComponent();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //копируем выбранный файл
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            // читаем файл в строку
            //string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = Path.GetFileName(filename);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Название лекции не должно быть пустым.");
            }
            else
            {
                if (filename != null)
                {
                    if (File.Exists("lec/" + textBox1.Text))
                    {
                        MessageBox.Show("Такой файл существует!");
                    }
                    else
                    {
                        File.Copy(filename, "lec/" + textBox1.Text);
                        lec.listBox1.Items.Insert(0, textBox1.Text);
                        MessageBox.Show("Материал успешно добавлен в базу");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Файл не выбран!");
                }
            }
        }
    }
}
