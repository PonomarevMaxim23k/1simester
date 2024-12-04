using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Картинка (*.png)|*.png|картинка(*.jpg)|*.jpg";
///            if (dialog.ShowDialog() == DialogResult.Cancel)
///                return;
            if (dialog.ShowDialog() == DialogResult.OK)
                label9.Text = dialog.FileName;
                MessageBox.Show(dialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text != ""&&
                textBox2.Text != ""&&
                textBox3.Text != ""&&
                textBox4.Text != ""&&
                dateTimePicker1.Text != ""&&
                comboBox1.Text!= ""&&
                label9.Text != "."
                ) 
            {
                Form2 form2 = new Form2();
                form2.Show(this);
            }
            else
            {
                label10.Text = "ОШИБКА! ВЫ ВВЕЛИ НЕ ВСЮ ИНФОРМАЦИЮ";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
