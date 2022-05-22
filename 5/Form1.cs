using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // добавление элементов в комбобокс
            comboBox1.Items.Add("Храм Элле");
            comboBox1.Items.Add("Форт Хейт");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1) // если текстбокс не пустой и комбобокс не пустой
            {
                Player player = new Player(comboBox1.SelectedIndex, textBox1.Text, 100, 20, 1000); // создается игрок со здоровьем 100, переносимым весом 20, 1000 монет
                WelcomeForm form = new WelcomeForm(player); // создание новой формы
                this.Hide();
                form.Show(); // открытие формы
            }
            else // иначе форма ошибки
            {
                Error err = new Error();
                err.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                textBox1.Text = "Воин";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                textBox1.Text = "Самурай";
            }

        }
    }
}
