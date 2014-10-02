using System;

namespace DojoCalender
{
    class ConsoleOutput
    {
        private String head = "So Mo Di Mi Do Fr Sa";

        public void show(MonatData data)
        {
            String title = data.Tage[0].ToString("MMMM yyyy");
            int prefix = (title.Length - head.Length) / 2;
            for (int i = 0; i < prefix; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(title);
            Console.WriteLine(head);

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
                Console.Write(" ");
            }
            foreach (DateTime date in data.Tage)
            {
                Console.Write(date.ToString("dd "));
                if (date.DayOfWeek == DayOfWeek.Saturday)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
