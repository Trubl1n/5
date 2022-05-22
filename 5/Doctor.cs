using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Doctor : Sushestvo, IDoctor // класс наследник
    {
        public void Heal(Sushestvo sushestvo, IHelp item) // метод Лечить
        {
            sushestvo.AddHealth(Convert.ToInt32(item.GetEffect()));
        }
        // конструктор
        public Doctor(int sushestvoHealth = 1, int sushestvoWeight = 1, int sushestvoWallet = 0) : base(sushestvoWallet: sushestvoWallet, sushestvoWeight: sushestvoWeight, sushestvoHealth: sushestvoHealth)
        {

        }
    }
}
