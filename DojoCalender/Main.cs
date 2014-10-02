
using System;
namespace DojoCalender
{
    class Main
    {
        private short _month;
        private short _year;
        System.IO.Stream openStandardOutput;
        private StreamOutput output;

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

        private Main(short month, short year)
        {
            openStandardOutput = Console.OpenStandardOutput();
            output = new StreamOutput(openStandardOutput);
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
            switch (args.Length)
            {
                case 1:
                    return new Main(0, short.Parse(args[0]));
                default:
                    return new Main(short.Parse(args[0]), short.Parse(args[1]));
            }

        }

        internal void show()
        {
            if (_month > 0)
            {
                MonatData data = new MonatData(_month, _year);
                output.show(data);
            }
            else
            {
                JahrData data = new JahrData(_year);
                output.show(data);
            }

            openStandardOutput.Close();
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
