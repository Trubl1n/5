using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Player : Sushestvo, IFighter // игрок
    {
        public int Class { get; } 
        public string playerName { get; }
        public void Attack(Sushestvo sushestvo, IGun gun) // Атака игрока
        {
            sushestvo.GetDamage(Convert.ToInt32(gun.GetDamage()));
        }
        // конструктор
        public Player(int Class, string Name, int sushestvoHealth = 1, int sushestvoWeight = 1, int sushestvoWallet = 0) : base(sushestvoWallet: sushestvoWallet, sushestvoWeight: sushestvoWeight, sushestvoHealth: sushestvoHealth)
        {
            this.Class = Class;
            this.playerName = Name;
        }
    }
}
