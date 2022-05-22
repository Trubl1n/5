using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Human : Sushestvo, ITorgovec // класс наследник
    {
        public void Recive(Sushestvo torgovec, Item item) // метод Получить
        {
            torgovec.Add(item);
        }
        public void GiveAway(Sushestvo torgovec, Item item) // метод Отдать
        {
            torgovec.Remove(item);
        }
        // конструктор
        public Human(int sushestvoHealth = 1, int sushestvoWeight = 1, int sushestvoWallet = 0) : base(sushestvoWallet: sushestvoWallet, sushestvoWeight: sushestvoWeight, sushestvoHealth: sushestvoHealth)
        {

        }
    }
}
