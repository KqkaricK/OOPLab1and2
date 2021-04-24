using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Strana a = new Strana();
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Страна: ";
                    richTextBox1.Text += a.GetStrana();
                    richTextBox1.Text += Environment.NewLine;
                }
                else
                {
                    a.SetName(textBox1.Text);
                    a.SetId(Convert.ToInt32(textBox2.Text));
                    a.SetGod(Convert.ToInt32(textBox3.Text));
                    a.SetStrana(textBox4.Text);
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Страна: ";
                    richTextBox1.Text += a.GetStrana();
                    richTextBox1.Text += Environment.NewLine;
                }
            }
            else if (radioButton2.Checked == true)
            {
                Class_Izd a = new Class_Izd();
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                }
                else
                {
                    a.SetName(textBox1.Text);
                    a.SetId(Convert.ToInt32(textBox2.Text));
                    a.SetGod(Convert.ToInt32(textBox3.Text));
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                }
            }
            else if (radioButton3.Checked == true)
            {
                Eks a = new Eks();
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Кол.: ";
                    richTextBox1.Text += a.GetKol();
                    richTextBox1.Text += Environment.NewLine;
                }
                else
                {
                    if (ChekIsNum(textBox4.Text, label4.Text) == true)
                    {
                        a.SetName(textBox1.Text);
                        a.SetId(Convert.ToInt32(textBox2.Text));
                        a.SetGod(Convert.ToInt32(textBox3.Text));
                        a.SetKol(Convert.ToInt32(textBox4.Text));
                        richTextBox1.Text += "Имя: ";
                        richTextBox1.Text += a.GetName();
                        richTextBox1.Text += Environment.NewLine;
                        richTextBox1.Text += "Id: ";
                        richTextBox1.Text += a.GetId();
                        richTextBox1.Text += Environment.NewLine;
                        richTextBox1.Text += "Год: ";
                        richTextBox1.Text += a.GetGod();
                        richTextBox1.Text += Environment.NewLine;
                        richTextBox1.Text += "Кол.: ";
                        richTextBox1.Text += a.GetKol();
                        richTextBox1.Text += Environment.NewLine;
                    }
                }
            }
            else if (radioButton4.Checked == true)
            {
                Tema a = new Tema();
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Тема: ";
                    richTextBox1.Text += a.GetTema();
                    richTextBox1.Text += Environment.NewLine;
                }
                else
                {
                    a.SetName(textBox1.Text);
                    a.SetId(Convert.ToInt32(textBox2.Text));
                    a.SetGod(Convert.ToInt32(textBox3.Text));
                    a.SetTema(textBox4.Text);
                    richTextBox1.Text += "Имя: ";
                    richTextBox1.Text += a.GetName();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Id: ";
                    richTextBox1.Text += a.GetId();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Год: ";
                    richTextBox1.Text += a.GetGod();
                    richTextBox1.Text += Environment.NewLine;
                    richTextBox1.Text += "Тема: ";
                    richTextBox1.Text += a.GetTema();
                    richTextBox1.Text += Environment.NewLine;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Страна";
            ChekRadioButton(sender);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Кол. Экземпляров";
            ChekRadioButton(sender);
        }

        bool ChekIsNum(string sender, string label)
        {
            int num = 0;
            if (Int32.TryParse(sender, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show("В " + label + " должны быть только цифры!");
                return false;
            }
        }

        void ChekRadioButton(object sender)
        {
            RadioButton checkBox = (RadioButton)sender;
            if (checkBox.Checked == true)
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Тема";
            ChekRadioButton(sender);
        }
    }
}
