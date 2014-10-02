
using System;
namespace DojoCalender
{
    class Main
    {
        private short _month;
        private short _year;
        private ConsoleOutput output;

        public short Month
        {
            get
            {
                return _month;
            }
        }
        public short Year
        {
            get
            {
                return _year;
            }
        }

        Main(short month, short year)
        {
            output = new ConsoleOutput();
            _month = month;
            _year = year;
        }

        /// <summary>
        /// Parst aus den Kommando-Parametern das Jahr und den Monat, Es müssen 2 Parameter übergeben werden: Monat und Jahr, wobei der Monat eine Zahl zwischen 1 und 12 sein muss.
        /// </summary>
        /// <param name="args">zwei integer ziffern: erste ist der Monat, zweite ist das Jahr.</param>
        /// <returns></returns>
        public static Main Parse(string[] args)
        {
            return new Main(short.Parse(args[0]), short.Parse(args[1]));
        }

        internal void show()
        {
            MonatData data = new MonatData(_month, _year);
            output.show(data);
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
