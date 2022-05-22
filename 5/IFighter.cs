using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public interface IFighter // интерфейс Боец
    {
        void Attack(Sushestvo sushestvo, IGun gun); // метод атаковать
    }
}
