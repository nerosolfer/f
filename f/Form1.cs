using f1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bank_acc sf = new bank_acc() { _fio = "Неизвестно", _balance = 0.0 };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sf._fio = textBox1.Text;
            sf._balance = Convert.ToDouble(textBox2.Text);
            MessageBox.Show($"Вы успешно зарегистрированы как {sf._fio}, баланс на вашем счёте составляет {sf._balance}");
            label4.Text = sf._fio;
            label6.Text = Convert.ToString(sf._balance);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textBox2.Text) <= sf._balance)
            {
                double off = Convert.ToDouble(textBox2.Text);
                sf.off(off);
                MessageBox.Show($"Вы успешно списали {off}. Ваш баланс теперь составляет {sf._balance}");
                label6.Text = Convert.ToString(sf._balance);
            }
            else
            {
                MessageBox.Show($"Сумма, которую вы пытаетесь списать, больше суммы на счёте. Вас баланс {sf._balance}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double add = Convert.ToDouble(textBox2.Text);
            sf.add(add);
            MessageBox.Show($"Вы успешно добавили {add}. Ваш баланс теперь составляет {sf._balance}");
            label6.Text = Convert.ToString(sf._balance);


        }

        private void label4_Click(object sender, EventArgs e) //имя пользователяэ
        {

        }

        private void label6_Click(object sender, EventArgs e) //сумма на счете
        {

        }
    }
}
