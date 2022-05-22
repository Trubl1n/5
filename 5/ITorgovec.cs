using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public interface ITorgovec // интерфейс Торговец
    {
        void Recive(Sushestvo torgovec, Item item); // метод Получить
        void GiveAway(Sushestvo torgovec, Item item); // метод Отдать
    }
}
