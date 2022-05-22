using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class WelcomeForm : Form
    {
        private Player _player;
        public WelcomeForm(Player player)
        {
            InitializeComponent();
            _player = player;
            Message text = new Message(_player);
            textBox1.Text = text.welcomeMessage;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm form1 = new GameForm(_player);
            form1.Show();
            this.Close();
        }
    }
}
