
namespace DojoCalender
{
    class JahrData
    {
        private MonatData[] _monate = new MonatData[12];

        public MonatData[] Monate
        {
            get
            {
                return _monate;
            }
        }

        public JahrData(short year)
        {
            for (short i = 1; i < 13; i++)
            {
                _monate[i - 1] = new MonatData(i, year);
            }
        }
    }
}
