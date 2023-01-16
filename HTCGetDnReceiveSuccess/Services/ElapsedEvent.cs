using System;
using System.Timers;

namespace HTCGetDnReceiveSuccess.Services
{
    public class ElapsedEvent
    {
        public static void Execute(object sender, ElapsedEventArgs e)
        {
            ScheduleTimer.timer.Stop();

            try
            {
                TransferDnToMoldShot.DataTransferRF();
                TransferDnToMoldShot.DataTransferWAC();
                TransferDnToMoldShot.DataTransferSAC();

                ScheduleTimer.SetTime();
                Console.WriteLine("Executing...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("System interval 300000msec");
                System.Threading.Thread.Sleep(300000);

                Execute(sender, e);
            }
        }
    }
}
