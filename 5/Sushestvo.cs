using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Sushestvo // базовый класс Существо
    {
        protected int sushestvoHealth; // здоровье
        protected int sushestvoWeight; // вес
        protected int sushestvoWallet; // кошелек
        protected List<object> sushestvoInventory; // инвентарь
        public void AddHealth(int heal) // добавление здоровья
        {
            sushestvoHealth += heal;
        }
        public void GetDamage(int dmg) // получение урона
        {
            sushestvoHealth -= dmg;
        }
        public List<object> GetInventory() // добавление предмета в инвентарь
        {
            return sushestvoInventory;
        }
        public string GetWallet() // увеличение денег
        {
            return sushestvoWallet.ToString();
        }
        public string GetWeight() // увеличение веса
        {
            return sushestvoWeight.ToString();
        }
        public string GetHealth() // здоровье
        {
            return sushestvoHealth.ToString();
        }
        public void AddMoney(int money) // получение денег
        {
            sushestvoWallet += money;
        }
        public void RemoveMoney(int money) // уменьшение денег
        {
            sushestvoWallet -= money;
        }
        public int GetAmountMoney() // получение денег
        {
            return sushestvoWallet;
        }
        public void AddWeight(int i) // добавление веса
        {
            sushestvoWeight += i;
        }
        public void RemoveWeight(int i) // уменьшение веса
        {
            sushestvoWeight -= i;
        }
        
        public void Add(object obj) // добавить
        {
            sushestvoInventory.Add(obj);
        }
        public void RemoveAid() // убрать помощь
        {
            sushestvoInventory.RemoveAt(sushestvoInventory.Count - 1);
        }
        public void Remove(object obj) // убрать
        {
            sushestvoInventory.Remove(obj);
        }

        protected Sushestvo(int sushestvoHealth = 1, int sushestvoWeight = 1, int sushestvoWallet = 0) // конструктор
        {
            this.sushestvoHealth = sushestvoHealth;
            this.sushestvoWallet = sushestvoWallet;
            this.sushestvoWeight = sushestvoWeight;
            this.sushestvoInventory = new List<object>();
        }
    }
}
