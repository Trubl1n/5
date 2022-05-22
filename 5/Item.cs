using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Item // базовый класс Предмет
    {
        protected int itemWeight; // вес предмета
        protected int itemPrice; // цена предмета
        protected string itemName; // название предмета
        public string GetName() // метод получения имени
        {
            return itemName;
        }
        public string GetPrice() // метод получения цены
        {
            return itemPrice.ToString();
        }
        public string GetWeight() // метод получения веса
        {
            return itemWeight.ToString();
        }
        protected Item(int itemPrice, int itemWeight, string itemName) // конструктор
        {
            this.itemPrice = itemPrice;
            this.itemWeight = itemWeight;
            this.itemName = itemName;
        }
    }
}
