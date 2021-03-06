using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibreria
{
    public class Fecha
    {
        public readonly DateTime _dateTime;

        public Fecha()
        {
            this._dateTime = DateTime.UtcNow;
        }

        public long GetTicksFecha()
        {
            return _dateTime.Ticks; 
        }

        public override string ToString()
        {
            return this._dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

    }
}
