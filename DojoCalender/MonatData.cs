
using System;
using System.Collections.Generic;

namespace DojoCalender
{
    class MonatData
    {
        private IList<DateTime> _Tage;

        public IList<DateTime> Tage
        {
            get
            {
                return _Tage;
            }
        }

        public MonatData(short monat, short jahr)
        {
            _Tage = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(jahr, monat); i++)
            {
                _Tage.Add(new DateTime(jahr, monat, i));
            }
        }
    }
}
