using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Help : Item, IHelp // класс наследник
    {
        private int healRate;
        public string GetEffect() // метод Получить эффект
        {
            return healRate.ToString();
        }
        // конструктор
        public Help(int healRate, int itemWeight, int itemPrice) : base(itemPrice: itemPrice, itemWeight: itemWeight, itemName: "Аптечка")
        {
            this.healRate = healRate;
        }
    }
}
