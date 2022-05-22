using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public interface IDoctor // интерфейс Лекарь
    {
        void Heal(Sushestvo sushestvo, IHelp item); // метод Лечить
    }
}
