using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class DeathForm : Form // форма Смерть
    {
        public DeathForm()
        {
            InitializeComponent();
        }

        private void DeathForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // кнопка Закрыть
        {
            base.Close();
        }
    }
}
