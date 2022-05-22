using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Spear : Item, IGun // 
    {
        private int spearDamage; // урон копья
        public string GetDamage() // метод нанесения урона с копья
        {
            return spearDamage.ToString();
        }
        public Spear(int spearDamage, int itemWeight, int itemPrice) : base(itemPrice: itemPrice, itemWeight: itemWeight, itemName: "Копьё") // конструктор
        {
            this.spearDamage = spearDamage;
        }
    }
}
