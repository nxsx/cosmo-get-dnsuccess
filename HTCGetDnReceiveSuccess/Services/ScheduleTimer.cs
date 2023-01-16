using System;
using System.Timers;

namespace HTCGetDnReceiveSuccess.Services
{
    public class ScheduleTimer
    {
        public static Timer timer;

        public static void SetTime()
        {
            DateTime now = DateTime.Now;
            DateTime schedule = new DateTime(now.Year, now.Month, now.Day, 1, 1, 0, 0);

            if (now > schedule)
            {
                schedule = schedule.AddDays(1);
            }

            double ticker = (double)(schedule - now).TotalMilliseconds;
            timer = new Timer(ticker);
            timer.Elapsed += new ElapsedEventHandler(ElapsedEvent.Execute);
            timer.Start();
        }
    }
}
