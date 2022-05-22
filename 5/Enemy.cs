using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Enemy : Sushestvo // класс наследник
    {
        // конструктор
        public Enemy(int sushestvoHealth = 100, int sushestvoWeight = 1, int sushestvoWallet = 0) : base(sushestvoWallet: sushestvoWallet, sushestvoWeight: sushestvoWeight, sushestvoHealth: sushestvoHealth)
        {

        }
    }
}
