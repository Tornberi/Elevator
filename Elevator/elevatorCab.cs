using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class elevatorCab
    {
        public enum Status
        {
            Ожидание,
            Подъём,
            ОткрытиеДверей,
            Блокировка
        }
        public int Stage { get; set; }
        public Status status { get; set; }

        
        public elevatorCab ()
        {
            Stage = 1;
        }

        public void goTO(int Stage)
        {
            if (Stage <= 20)
                status = Status.Подъём;
            else
                Console.WriteLine("Подъём на крышу или спуск в подвал временно закрыты.");
        }
    }
}
