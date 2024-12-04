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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            textBox1.Text = frm1.textBox1.Text;
            textBox2.Text = frm1.textBox2.Text;
            textBox3.Text = frm1.textBox3.Text;
            textBox4.Text = frm1.textBox4.Text;
            textBox5.Text = frm1.dateTimePicker1.Text;
            textBox6.Text = frm1.comboBox1.Text;
            pictureBox1.Image = Bitmap.FromFile(frm1.label9.Text);
            if (frm1.checkBox1.Checked) { label1.Text = "Совершеннолетний(яя)"; } else { label1.Text = "Не Совершеннолетний(яя)"; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
