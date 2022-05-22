using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    public class Message // сообщения
    {
        private string N = Environment.NewLine; // обозначение N за Enviroment.NewLine
        public string welcomeMessage { get; }
        public string buttonReturn { get; }
        public Message(Player player)
        {
            switch (player.Class) // Место появления
            {
                case 0: // Если выбрано первое, в форму пишется это:
                    {
                        welcomeMessage = "Добро пожаловать" + N + "Отправляйтесь в Храм Элле." + Environment.NewLine + " Храм Элле — это разрушенное здание, в котором спрятано место благодати. Крыша обрушилась и не обеспечивает защиты от стихий, а стены заросли сорняками, но это не мешает торговцам искать то небольшое укрытие, что осталось.";
                        break;
                    }
                case 1: // Если выбрано второе, в форму пишется это:
                    {
                        welcomeMessage = "Добро пожаловать" + N + "Отправляйтесь в Форт Хейт." + Environment.NewLine + " Захваченный форт, некогда принадлежавший следующему предположительному правителю Замогилья. Путь к этому оборонительному сооружению преграждает Туманный лес.";
                        break;
                    }
            }
        }
    }
}
