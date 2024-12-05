using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text != "" &&
                textBox2.Text != "" &&
                textBox3.Text != "" &&
                textBox4.Text != "" &&
                textBox5.Text != "" &&
                textBox6.Text != "" &&
                numericUpDown1.Text != "0" &&
                dateTimePicker1.Text != "" &&
                comboBox1.Text != ""
                
                )
            {
                string Writepath = "C:\\Users\\Admin\\source\\repos\\ПЗ23\\form1\\obj\\Debug\\Страхователи.txt";
                label8.Text = "";
                try
                {
                    using (StreamWriter sw = new StreamWriter(Writepath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Страхователь");
                        sw.WriteLine("Фамилия: " + textBox1.Text);
                        sw.WriteLine("Имя: " + textBox2.Text);
                        sw.WriteLine("Дата рождения: " + dateTimePicker1.Text);
                        sw.WriteLine("Адрес:");
                        sw.WriteLine("    Город: " + textBox3.Text);
                        sw.WriteLine("    Улица: " + textBox4.Text);
                        sw.WriteLine("    Дом: " + textBox5.Text);
                        sw.WriteLine("    Квартира: " + textBox6.Text);
                        sw.WriteLine("Вид страхования: " + comboBox1.Text);
                        sw.WriteLine("Срок страхования: " + numericUpDown1.Text);
                        sw.WriteLine("");
                        sw.WriteLine("");
                    }
                }
                catch { Exception exception; }
                MessageBox.Show(
                "Страхователь успешно занесен в текстовый документ: "+Writepath,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                numericUpDown1.Text = "0";
                dateTimePicker1.Text = "";
                comboBox1.Text = "Страхование имущества";
            }
            else
            {
                label8.Text = "ОШИБКА! ВЫ ВВЕЛИ НЕ ВСЮ ИНФОРМАЦИЮ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
