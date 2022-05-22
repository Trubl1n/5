using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class GameForm : Form
    {
        private Player _player; // поле Игрок
        private string newLine = Environment.NewLine;
        private Random _random = new Random();

        public GameForm(Player player)
        {
            InitializeComponent();
            _player = player;
            ResetStats();
            player.Add(new Spear(40, 7, 240)); // добавление предмета Копьё(40 урона, 7 вес, 240 монет)
            ResetStats(); // метод обновления статистики 
            groupBox1.Parent = this;
            groupBoxDoctor.Parent = this;
            groupBoxEnemy.Parent = this;
            groupBoxTorgovec.Parent = this;
        }
        private void ResetStats()
        {
            labelName.Text = _player.playerName;
            labelHealth.Text = _player.GetHealth();
            labelWallet.Text = _player.GetWallet();
            labelWeight.Text = _player.GetWeight();

            textBox1.Text = "";
            foreach (Item item in _player.GetInventory())
            {
                string addableItem =
                "Название: " + item.GetName() + newLine +
                "Вес: " + item.GetWeight() + newLine +
                "Цена: " + item.GetPrice() + newLine;
                if (item is IGun)
                {
                    addableItem += "Урон: " + ((IGun)item).GetDamage() + newLine + newLine;
                    int damage = Convert.ToInt32(((IGun)item).GetDamage());
                }
                if (item is IHelp)
                    addableItem += "Лечение: " + ((IHelp)item).GetEffect() + newLine + newLine;
                textBox1.Text += addableItem;

            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // использование аптечки
        {
            if (Convert.ToInt32(_player.GetHealth()) < 100) // Если количество здоровья мень 100, можно использовать аптечку
            {
                foreach (object i in _player.GetInventory())
                {
                    if (i is IHelp)
                    {
                        _player.AddHealth(20); // добавление 20 единиц здоровья
                        _player.RemoveAid(); 
                        _player.AddWeight(1); // добавление 1 единицы веса
                        ResetStats(); // обновление статистики
                        break;
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Name == "Воин")
            {
                pictureBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxTorgovec.Visible = true;
            groupBoxEnemy.Visible = false;
            groupBoxDoctor.Visible = false;
            textBox3.Text = "Вы пришли к торговцу." + newLine + "У него можно купить вещи.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Поздравляем! Вы купили аптечку. Тыперь вы можете отправиться к доктору.";
            if (_player.GetAmountMoney() >= 200 && Convert.ToInt32(_player.GetWeight()) > 0) // если денег >= 200 и вес > 0, можно купить аптечку
            {
                _player.RemoveMoney(200); // забрать 200 монет
                _player.Add(new Help(20, 1, 200)); // 20 добавление здоровья, 1 вес, 200 стоимость
                _player.RemoveWeight(1); // добавление веса на 1 единицу
                ResetStats(); // обновление статистики 
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button6.Visible = false;
            button4.Visible = true;
            button10.Visible = true;
            groupBoxEnemy.Visible = true;
            groupBoxDoctor.Visible = false;
            groupBoxTorgovec.Visible = false;
            textBox3.Text = "Это враг!" + newLine + "Убейте его или убегайте" + newLine + "(потеряв часть денег)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = _random.Next(50, 500);
            _player.AddMoney(c);
            int u = _random.Next(1, 80);
            _player.GetDamage(u);
            textBox3.Text = "Поздравляем! Враг убит!" + newLine + "Вы нашли " + c.ToString() + " монет!" + newLine + "Враг нанес " + u.ToString() + " урона.";
            ResetStats();
            button6.Visible = true;
            button4.Visible = false;
            button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBoxEnemy.Visible = false;
            groupBoxDoctor.Visible = false;
            groupBoxTorgovec.Visible = false;
            textBox3.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBoxEnemy.Visible = false;
            groupBoxDoctor.Visible = false;
            groupBoxTorgovec.Visible = false;
            textBox3.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(_player.GetHealth()) < 100) // если здоровье менеше 100, можно использовать аптечку
            {
                foreach (object i in _player.GetInventory())
                {
                    if (i is IHelp)
                    {
                        _player.AddHealth(20); // увеличение здоовья на 20 
                        _player.RemoveAid();
                        _player.AddWeight(1); // увеличение веса на 1
                        ResetStats(); // обновление статистики
                        break;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBoxDoctor.Visible = true;
            groupBoxEnemy.Visible = false;
            groupBoxTorgovec.Visible = false;
            textBox3.Text = "Вы пришли к доктору." + newLine + "Он может вас вылечить.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBoxEnemy.Visible = false;
            groupBoxDoctor.Visible = false;
            groupBoxTorgovec.Visible = false;
            textBox3.Text = " ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Name == "Самурай")
            {
                pictureBox3.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBoxEnemy.Visible = false;
            int x = _random.Next(50, 300);
            textBox3.Text = "Вы убежали от врага." + newLine + "Потяряв " + x.ToString() + "монет.";
            _player.RemoveMoney(x);
            ResetStats();
            button6.Visible = true;
            button4.Visible = false;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
