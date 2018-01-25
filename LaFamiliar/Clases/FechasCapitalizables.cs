using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.Clases
{
    public class FechasCapitalizables
    {
        List<DateTime> _fechas;

        public List<DateTime> fechas { get { return _fechas; } }

        public FechasCapitalizables(int year)
        {
            _fechas = new List<DateTime>()
            {
                new DateTime(year, 3, 31),
                new DateTime(year, 6, 30), 
                new DateTime(year, 9, 30), 
                new DateTime(year, 12, 31)
            };
        }
    }
}
