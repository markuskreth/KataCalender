using System;
using System.IO;

namespace DojoCalender
{
    class StreamOutput
    {
        private String head = "So Mo Di Mi Do Fr Sa";
        private StreamWriter writer;

        public StreamOutput(System.IO.Stream stream)
        {
            writer = new StreamWriter(stream);
        }

        public void show(MonatData data)
        {

            String title = data.Tage[0].ToString("MMMM yyyy");
            int prefix = (head.Length - title.Length) / 2;
            for (int i = 0; i < prefix; i++)
            {
                writer.Write(" ");
            }

            writer.WriteLine(title);
            writer.WriteLine(head);

            switch (data.Tage[0].DayOfWeek)
            {
                case DayOfWeek.Friday:
                    prefix = 15;
                    break;
                case DayOfWeek.Monday:
                    prefix = 3;
                    break;
                case DayOfWeek.Saturday:
                    prefix = 18;
                    break;
                case DayOfWeek.Sunday:
                    prefix = 0;
                    break;
                case DayOfWeek.Thursday:
                    prefix = 12;
                    break;
                case DayOfWeek.Tuesday:
                    prefix = 6;
                    break;
                case DayOfWeek.Wednesday:
                    prefix = 9;
                    break;
                default:
                    break;
            }
            for (int i = 0; i < prefix; i++)
            {
                writer.Write(" ");
            }
            foreach (DateTime date in data.Tage)
            {
                writer.Write(date.ToString("dd "));
                if (date.DayOfWeek == DayOfWeek.Saturday)
                    writer.WriteLine();
            }
            writer.WriteLine();
            writer.Flush();
        }
    }
}
